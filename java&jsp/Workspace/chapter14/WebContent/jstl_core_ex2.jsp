<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    <%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>JSTL core 라이브러리 사용 예제 2</title>
</head>
<body>
<c:forEach var="test" begin="1" end="10" step="2">
	<b>${test }</b>&nbsp;
</c:forEach>
<br>
<c:forTokens var="alphabet" items="a, b, c, d, e, f, g, h, i, j, k, l, m, n" delims=",">
	<b>${alphabet }</b>&nbsp;
</c:forTokens>
<br>
<c:set var="data" value="홍길동, 김길동, 고길동"/>
<c:forTokens var="varData" items="${data }" delims=",">
	<b>${varData }</b>&nbsp;
</c:forTokens>
<%String str = "http://localhost:8088/Chapter14/jstl_core_ex2.jsp"; %>
<c:forTokens var="strTest" items="<%=str %>" delims="/" begin="0" end="5" varStatus="st">
	<c:if test="${st.index<2 }">
	<b>${strTest }</b>&nbsp; ${st.index }</c:if>
</c:forTokens><br>
<c:forTokens var="strTest" items="<%=str %>" delims="/" begin="1" end="5" step="2">
	<b>${strTest }</b>&nbsp;
</c:forTokens><br>

</body>
</html>