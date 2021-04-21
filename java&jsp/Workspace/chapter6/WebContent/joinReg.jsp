<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<%
	String id = request.getParameter("id");
	String pw = request.getParameter("password");
	String name = request.getParameter("name");
	String tel = request.getParameter("tel");
	out.println("아이디" + id + "<br>");
	out.println("패스워드 : " + pw + "<br>");
	out.println("이름 : " + name + "<br>");
	out.println("전화번호 : " + tel + "<br>");
	%>
	<a href=javascript:saveData()">저장</a>
<script>
	function saveData(){
		alert('데이터를 저장합니다.');
		location.href="template.jsp?page=login";
	}
</script>

</body>
</html>