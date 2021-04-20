<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>

<%@ page import ="java.util.*" %>
<%
Calendar c = Calendar.getInstance();
int hour = c.get(Calendar.HOUR_OF_DAY);
int minute=c.get(Calendar.MINUTE);
int second = c.get(Calendar.SECOND);
%>
<html>
<head>
<meta charset="UTF-8">
<title>Scriptlet Test2</title>
</head>
<body>
<h1>현재시간 <%=hour %>시 <%=minute %>분 <%=second %>초</h1>
<% if(hour>=12){ %>
<h1>오후입니다.</h1>
<%} else{ %>
<h2>오전입니다.</h2>
<%} %>
</body>
</html>