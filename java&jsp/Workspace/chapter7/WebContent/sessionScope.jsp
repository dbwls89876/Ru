<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<jsp:useBean id="testsession" class="scope.Counter" scope="session"></jsp:useBean>
<body>
현재 방문자 수 : 
<jsp:getProperty property="cnt" name="testsession"/>
<input type="button" value="초기화" onclick="location.href='cntReset.jsp?page=sessionScope';">
</body>
</html>