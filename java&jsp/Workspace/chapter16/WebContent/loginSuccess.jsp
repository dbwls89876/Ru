<%@page import="vo.Member"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<%
	Member member = (Member)request.getAttribute("member");
%>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<style>
	table{
		margin : auto;
		width : 400px;
		border : 1px solid gray;
		text-align: center;
	}
	.td_title{
		font-weight: bold;
		font-size: x-large;
	}
</style>
</head>
<body>
<table>
	<tr>
		<td>아이디 : </td>
		<td><%=member.getId() %></td>
	</tr>
	<tr>
		<td>비밀번호 : </td>
		<td><%=member.getPassword() %></td>
	</tr>
	<tr>
		<td>이름 : </td>
		<td><%=member.getName() %></td>
	</tr>
	<tr>
		<td>나이 : </td>
		<td><%=member.getAge() %></td>
	</tr>
	<tr>
		<td>성별 : </td>
		<td><%=member.getGender() %></td>
	</tr>
	<tr>
		<td>이메일 주소 : </td>
		<td><%=member.getEmail() %></td>
	</tr>
	<tr>
		<td colspan="2"><a href="login.jsp">리스트로 돌아가기</a></td>
	</tr>
</table>
</body>
</html>