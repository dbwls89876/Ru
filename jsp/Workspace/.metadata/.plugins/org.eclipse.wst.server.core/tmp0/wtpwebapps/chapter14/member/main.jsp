<%@ page import="java.sql.*" %>
<%@ page import="javax.sql.*" %>
<%@ page import = "javax.naming.*" %>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fn" uri="http://java.sun.com/jsp/jstl/functions" %>
<c:set var="userID"/>
<c:choose>
	<c:when test="${id ne null }">
		<c:set var="userID" value="${fn:trim(id) }"/>
	</c:when>
</c:choose>
<c:if test="${id eq null }">
	<script>
		alert('로그인을 하세요');
		location.href='loginForm.jsp';
	</script>
</c:if>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>회원 관리 시스템 메인 페이지</title>
</head>
<body>
<h3>${userID }로 로그인하셨습니다.</h3>
<a href="logout.jsp">로그아웃</a>&nbsp;&nbsp;
<a href="member_mod.jsp?id">회원 정보 수정</a>&nbsp;&nbsp; 
<c:choose>
	<c:when test="${userID ne null and id eq 'admin'}">
		<a href="member_list.jsp">관리자모드 접속(회원목록보기)</a>
	</c:when>
	<c:when test="${userID ne null }">
		<a href="member_info.jsp?id=${userID }">내 정보 보기</a>
	</c:when>
</c:choose>
</body>
</html>