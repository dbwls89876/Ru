<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@page import="java.sql.*" %>
<%@page import="javax.sql.*"%>
<%@page import="javax.naming.*"%>
<!DOCTYPE html>
<%
Connection conn = null;
String sql = "select * from student";
PreparedStatement pstmt = null;
ResultSet rs = null;

try{
	Context init = new InitialContext();
	DataSource ds = (DataSource) init.lookup("java:comp/env/jdbc/OracleDB");
	conn = ds.getConnection();
	
	pstmt = conn.prepareStatement(sql, ResultSet.TYPE_SCROLL_SENSITIVE, ResultSet.CONCUR_UPDATABLE);
	
	rs = pstmt.executeQuery();
	
	rs.last();
	out.println(rs.getInt(1) + "," + rs.getString(2) + "<br>");
	
	rs.first();
	out.println(rs.getInt(1) + "," + rs.getString(2) + "<br>");
	
	rs.absolute(3);
	out.println(rs.getInt(1) + "," + rs.getString(2) + "<br>");
}catch(Exception e){
	e.printStackTrace();
}finally{
	try{
		rs.close();
		pstmt.close();
		conn.close();
	}catch(Exception e){
		e.printStackTrace();
	}
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