<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<h1>인사관리 사원등록화면</h1>
인사관리 사원등록<br>
<form action="person_register_rg.jsp">
<table>
	<tr>
		<td>성명:</td>
		<td><input type="text" name="name" id="name"></td>
	</tr>
	<tr>
		<td>사원번호:</td>
		<td><input type="text" name="num" id="num"></td>
	</tr>
	<tr>
		<td>소속부서:</td>
		<td>
			<select name="dept" id="dept">
				<option value="인사부">인사부</option>
				<option value="기획부">기획부</option>
				<option value="홍보부">홍보부</option>
				<option value="영업부">영업부</option>
				<option value="경리부">경리부</option>
			</select>
		</td>
	</tr>
		<tr>
		<td>직급:</td>
		<td>
			<select name="position" id="position">
				<option value="1">1급</option>
				<option value="2">2급</option>
				<option value="3">3급</option>
				<option value="4">4급</option>
			</select>
		</td>
	</tr>
	<tr>
		<td>직책:</td>
		<td><input type="text" name="duty" id="duty"></td>
	</tr>
	<tr>
		<td>연락처:</td>
		<td><input type="text" name="tel" id="tel"></td>
	</tr>
</table>
<input type="submit" value="등록">
<input type="button" value="취소" onclick="location.href='index.jsp'">
</form>
</body>
</html>