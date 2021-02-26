<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<jsp:useBean id="binfo" class="mall.Book"></jsp:useBean>
<jsp:setProperty property="*" name="binfo"/>
<html>
<head>
<meta charset="UTF-8">
<title>책 정보 관리</title>
</head>
<body>
책 정보가 저장되었습니다.<br>
-------------------------------<br>
<h3>제품 정보</h3>
<jsp:include page="productInfo.jsp"></jsp:include>
페이지수 : <jsp:getProperty property="page" name="binfo"/>
저자 : <jsp:getProperty property="writer" name="binfo"/>
</body>
</html>