<%@page import="vo.Member"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<%
String id = (String)session.getAttribute("id");
String grade = (String)session.getAttribute("grade");
Member member = (Member)session.getAttribute("member");
if(id == null){
%>
	<a href="loginForm.jsp">로그인</a>
<%}else{ %>
	[등급 : ] <%if(grade!=null && grade.equals("S")){ %>관리자
	<%}else if(grade!=null && grade.equals("N")){ %>일반<%} %>]<br>
	${id}님 환영합니다.
	주소 : ${member.addr }
	
	<a href="logout">로그아웃</a>	
<%} %>
</body>
</html>