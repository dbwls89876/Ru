<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
<%@ taglib prefix="sql" uri="http://java.sun.com/jsp/jstl/sql" %>
<fmt:requestEncoding value="utf-8"/>
<c:set var="loginId" value="${param.id }"/>
<c:set var="pass" value="${param.pass }"/>

<sql:setDataSource var="con" dataSource="jdbc/OracleDB"/>
<sql:query var="rs" dataSource="${con}">
	select * from member where id=?
	<sql:param>${loginId }</sql:param>
</sql:query>
<c:forEach var="row" items="${rs.rows }">
	<c:if test="${row.password == pass}">
		<c:set var="id" value="${loginId }" scope="session"/>
		<c:redirect url="main.jsp"/>
	</c:if>
</c:forEach>
<script>
alert('아이디나 비밀번호가 일치하지 않습니다.')
location.href="loginForm.jsp";
</script>