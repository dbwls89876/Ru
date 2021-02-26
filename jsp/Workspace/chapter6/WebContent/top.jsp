<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
</head>
<body>
	<%	String id = (String)session.getAttribute("id"); %>
	
	<%if(id==null){%>
		<a href="./template.jsp?page=login">Login</a>
		<a href="./template.jsp?page=join">Join</a>
	<%}else{ %>
	<%=id %>님 환영합니다.
	<a href="logout.jsp">logout</a>
	<%} %>
</body>
</html>
