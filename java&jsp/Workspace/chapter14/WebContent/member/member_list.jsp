<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
<%@ taglib prefix="sql" uri="http://java.sun.com/jsp/jstl/sql" %>
<%@ taglib prefix="fn" uri="http://java.sun.com/jsp/jstl/functions" %>
<!DOCTYPE html>
<c:if test="${id == null or id ne 'admin'}">
		<script>
		alert('관리자로 로그인하세요');
		location.href='loginForm.jsp';
	</script>
</c:if>

<sql:setDataSource var="con" dataSource="jdbc/OracleDB"/>
<sql:query var="rs" dataSource="${con }">
	select * from member
</sql:query>

<html>
<head>
<meta charset="UTF-8">
<title>회원 관리 시스템 관리자모드(회원 목록 보기)</title>
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
	<tr><td colspan=2 class="td_title">회원 목록</td></tr>
	<c:forEach var="row" items="${rs.rows }" >
	<tr>
		<td>
			<a href="member_info.jsp?id=${row.id }">${row.id }</a>
		</td>
		<td>
			<a href="member_mod.jsp?id=${row.id }">수정</a>
			<a href="member_delete.jsp?id=${row.id }">삭제</a>
		</td>
	</tr>
</c:forEach>
</table>
</body>
</html>