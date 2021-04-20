<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@page import="java.sql.*,javax.sql.*, javax.naming.*"%>
<%
	request.setCharacterEncoding("utf-8");
	Class.forName("oracle.jdbc.OracleDriver");
	Connection con = DriverManager.getConnection("jdbc:oracle:thin:@//localhost:1521/xe", "java", "java");
	PreparedStatement pstmt = null;
	String sql = null;
	ResultSet rs = null;
	if(request.getParameter("search").equals("1")){
		sql = "select * from personnel where id=?";
		pstmt = con.prepareStatement(sql);
		pstmt.setString(1, request.getParameter("num"));
		rs = pstmt.executeQuery();
	}else{
		sql = "select * from personnel where dept=?";
		pstmt = con.prepareStatement(sql);
		pstmt.setString(1, request.getParameter("dept"));
		rs = pstmt.executeQuery();
	}	
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<h1>직원 정보 조회 결과</h1>
<table border="1">
	<tr>
		<td>성명</td><td>사번</td><td>직급</td>
		<td>직책</td><td>연락처</td><td>소속부서</td>
	</tr>
	
	<%
	if(rs.next())
	do{ %>
	<tr>
		<td><%=rs.getString(2) %></td>
		<td><%=rs.getString(1) %></td>
		<td><%=rs.getString(4) %></td>
		<td><%=rs.getString(5) %></td>
		<td><%=rs.getString(6) %></td>
		<td><%=rs.getString(3) %></td>
	</tr>
	<%}while(rs.next()); %>
</table>
</body>
</html>