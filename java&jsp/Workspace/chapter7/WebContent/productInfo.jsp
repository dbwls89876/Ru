<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<jsp:useBean id="pinfo" class="mall.ProductInfo" scope="request"></jsp:useBean>
<jsp:setProperty property="*" name="pinfo"/>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
코드 : <jsp:getProperty property="code" name="pinfo"/>
제품명 : <jsp:getProperty property="name" name="pinfo"/>
가격 : <jsp:getProperty property="price" name="pinfo"/>
</body>
</html>