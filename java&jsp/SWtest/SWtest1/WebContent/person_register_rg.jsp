<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@page import="java.sql.*,javax.sql.*, javax.naming.*"%>
<%
	Class.forName("oracle.jdbc.OracleDriver");
	Connection con = DriverManager.getConnection("jdbc:oracle:thin:@//localhost:1521/xe", "java", "java");
	PreparedStatement pstmt = null;
	
	String sql = "insert into personnel values (?,?,?,?,?,?)";
	pstmt = con.prepareStatement(sql);
	pstmt.setString(1, request.getParameter("num"));
	pstmt.setString(2, request.getParameter("name"));
	pstmt.setString(3, request.getParameter("dept"));
	pstmt.setString(4, request.getParameter("position"));
	pstmt.setString(5, request.getParameter("duty"));
	pstmt.setString(6, request.getParameter("tel"));
	pstmt.executeUpdate();
	response.sendRedirect("person_register.jsp");
%>
