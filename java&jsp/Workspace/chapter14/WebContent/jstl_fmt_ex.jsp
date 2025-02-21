<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
<jsp:useBean id="date" class="java.util.Date"/>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<a href="jstl_fmt.jsp?na=en_US">영문보기</a>
<a href="jstl_fmt.jsp?na=ko_KR">영문보기</a>
<fmt:setLocale value="${param.na eq null?'en_US':param.na}"/>
<fmt:setLocale value="ko_KR"/>
<fmt:bundle basename="test">
<fmt:message key="name"/><br>
<fmt:message key="say"/><br>
<fmt:message key="say2">
<fmt:param value="고길동"/>
</fmt:message>
</fmt:bundle>
<p>
<fmt:formatNumber value="50000" type="currency"/><br>
<fmt:formatNumber value="0.15" type="percent"/><br>
<fmt:formatNumber value="500567300" pattern="###,###,###"/><br>

<fmt:formatDate value="${date }" type="date"/><br>
<fmt:formatDate value="${date }" type="time"/><br>
<fmt:formatDate value="${date }" type="both"/><br>

<fmt:formatDate value="${date }" type="both" timeStyle="short" dateStyle="short"/><br>
		<fmt:formatDate value="${date }" type="both" timeStyle="long"
			dateStyle="long" /><br>
</body>
</html>