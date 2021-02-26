<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="sql" uri="http://java.sun.com/jsp/jstl/sql" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<sql:setDataSource var="conn" dataSource="jdbc/OracleDB"/>
<sql:update dataSource="${conn }"
	sql="insert into test (num, name) values (?,?)">
	<sql:param value="5"/>
	<sql:param value="홍길동"/>
</sql:update>
<sql:update dataSource="${conn }">
	INSERT INTO test (num, name) VALUES (6, '조준동')
</sql:update>
<sql:update dataSource="${conn }">
	INSERT INTO test (num, name) VALUES (7, '홍길동')
</sql:update>
<sql:update dataSource="${conn }">
	INSERT INTO test (num, name) VALUES (8, '홍길순')
</sql:update>
<sql:query var="rs" dataSource="${conn }">
	select * from test where name=?
	<sql:param>홍길동</sql:param>
</sql:query>
<c:forEach var="data" items="${rs.rows }">
	<c:out value="${data['num'] }"/>
	<c:out value="${data['name'] }"/>
	<br>
</c:forEach>
</body>
</html>