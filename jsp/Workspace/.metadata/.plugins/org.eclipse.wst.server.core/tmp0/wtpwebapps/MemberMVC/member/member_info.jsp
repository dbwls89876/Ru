<%@page import="vo.Member"%>
<%@page import="java.util.ArrayList"%>
<%@page import="dao.MemberDAO"%>
<%@page import="java.sql.*" %>
<%@page import="javax.sql.*"%>
<%@page import="javax.naming.*"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<%
	Member member = (Member)request.getAttribute("member");
%>
<html>
<head>
<meta charset="UTF-8">
<title>회원 관리 시스템 관리자모드(회원 정보 보기)</title>
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
		<td colspan="2"><a href="memberList.mem">리스트로 돌아가기</a></td>
	</tr>
</table>
</body>
</html>