<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
       <%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<c:forEach var="num1" begin="1" end="9" >
	<c:forEach var="num2" begin="1" end="9" >
	<b>${num1 } * ${num2 } = ${num1*num2 }</b>&nbsp;&nbsp;
	</c:forEach>
	<br>
</c:forEach>
</body>
</html>