<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="test/html; charset=EUC-KR">
<title>Insert title here</title>
</head>
<body>
<%
pageContext.setAttribute("pageScope", "pageValue");
request.setAttribute("requestScope", "requestValue");
%>
<jsp:forward page="attributeTest5Result.jsp"></jsp:forward>
</body>
</html>