<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<form action="statementTest.jsp" method="post">
	번호 : <input type="text" name="num" id=num pattern="[0-9]*" required><br>
	이름 : <input type="text" name="name" id="name" required>
	<input type=submit value="입력"> 
</form>
</body>
</html>