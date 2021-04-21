<%@page import="java.sql.*" %>
<%@page import="javax.sql.*"%>
<%@page import="javax.naming.*"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%

	request.setCharacterEncoding("utf-8");
	String name = request.getParameter("name");

	Connection conn = null;
	CallableStatement cs = null;
	try{
		Context init = new InitialContext();
		DataSource ds = (DataSource)init.lookup("java:comp/env/jdbc/OracleDB");
		conn = ds.getConnection();
		cs = conn.prepareCall("{call Get_Annual_income(?,?)}");
		cs.setString(1, name);
		cs.registerOutParameter(2, java.sql.Types.VARCHAR);
		cs.execute();
		out.println("<h3> "+ name + "의 연봉은 " + cs.getInt(2) + "입니다.</h3>");
	}catch(Exception e){
		out.println("<h3>레코드 등록에 실패하였습니다.</h3>");
		e.printStackTrace();
	}
	finally{
		try{
			cs.close();
			conn.close();
		}catch(Exception e){
			e.printStackTrace();
		}
	}
%>