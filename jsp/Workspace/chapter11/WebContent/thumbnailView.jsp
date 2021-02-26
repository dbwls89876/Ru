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
request.setCharacterEncoding("utf-8");
String filename = (String)request.getAttribute("filename");
//String filename = request.getParameter("filename");, sendredirect이용 시 사용
%>
-원본 이미지-<br>
<img src="image/<%=filename %>"><p>
-썸네일 이미지-<br>
<img src="image/sm_<%=filename %>">
</body>
</html>