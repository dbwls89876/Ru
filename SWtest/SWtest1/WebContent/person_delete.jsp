<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@page import="java.sql.*,javax.sql.*, javax.naming.*"%>
<%
	Class.forName("oracle.jdbc.OracleDriver");
	Connection con = DriverManager.getConnection("jdbc:oracle:thin:@//localhost:1521/xe", "java", "java");
	PreparedStatement pstmt = null;
	
	String sql = "delete from personnel where id=? and name=?";
	pstmt = con.prepareStatement(sql);
	pstmt.setString(1, request.getParameter("num"));
	pstmt.setString(2, request.getParameter("name"));
	ResultSet rs = pstmt.executeQuery();
	response.sendRedirect("person_out.jsp");
%>