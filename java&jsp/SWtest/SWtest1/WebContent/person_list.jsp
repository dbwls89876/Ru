<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<h1>인사관리조회화면</h1>
<form action="person_list_result.jsp">
<input type="radio" value="1" id="search" name="search">사원번호로 조회 <input type="text" name="num" id="num"> <br>
<input type="radio" value="2" id="search" name="search">부서명으로 조회
<select name="dept" id="dept">
	<option>인사부</option>
	<option>기획부</option>
	<option>홍보부</option>
	<option>영업부</option>
	<option>경리부</option>
</select>
<input type="submit" value="조회">
<input type="button" value="취소" onclick="location.href='index.jsp'">
</form>
</body>
</html>