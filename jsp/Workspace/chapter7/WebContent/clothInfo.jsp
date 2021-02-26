<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<jsp:useBean id="binfo" class="mall.Cloth"></jsp:useBean>
<jsp:setProperty property="*" name="binfo"/>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<jsp:include page="productInfo.jsp"></jsp:include>
사이즈 : <jsp:getProperty property="size" name="binfo"/>
색 : <jsp:getProperty property="color" name="binfo"/>

</body>
</html>