<%@page import="java.sql.*" %>
<%@page import="javax.sql.*"%>
<%@page import="javax.naming.*"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<%
	Connection conn = null;

try{
	Context init = new InitialContext();
	DataSource ds = (DataSource)init.lookup("java:comp/env/jdbc/OracleDB");
	conn = ds.getConnection();
	out.println("<h3>연결되었습니다.</h3>");
	conn.close();
}catch(Exception e){
	out.println("<h3>연결에 실패하였습니다.</h3>");
	e.printStackTrace();
}
%>
<html>
<head>

<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>

</body>
</html>