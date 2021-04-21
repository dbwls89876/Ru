<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@page import="java.sql.*" %>
<%@page import="javax.sql.*"%>
<%@page import="javax.naming.*"%>
<!DOCTYPE html>
<%
	request.setCharacterEncoding("utf-8");
	String[] num = request.getParameterValues("num");
	String[] name = request.getParameterValues("name");

	Connection conn = null;
	String sql = "insert into student (num, name) values (?, ?)";
	PreparedStatement pstmt = null;
	try{
		Context init = new InitialContext();
		DataSource ds = (DataSource) init.lookup("java:comp/env/jdbc/OracleDB");
		conn = ds.getConnection();
		conn.setAutoCommit(false);
		pstmt = conn.prepareStatement(sql);
		
		for(int i = 0; i<=num.length; i++){
			pstmt.setInt(1, Integer.parseInt(num[i])); // 숫자는 속성을 의미
			pstmt.setString(2, name[i]);
			if(pstmt.executeUpdate()!=0){
				out.println("<h3>" + num[i] + "번 레코드를 등록하였습니다.</h3>");
			}
		}
		conn.commit();
	}catch(Exception e){
		conn.rollback();
		out.println("<h3>레코드 등록에 실패하였습니다.</h3>");
		e.printStackTrace();
	}
	finally{
		try{
			pstmt.close();
			conn.close();
		}catch(Exception e){
			e.printStackTrace();
		}
	}
%>
