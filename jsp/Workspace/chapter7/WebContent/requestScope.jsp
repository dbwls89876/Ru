<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>request scope</title>
</head>
<body>
	<% request.setCharacterEncoding("utf-8"); %>
	<jsp:useBean id="req" class="scope.RequestScopeBean" scope="request"/>
	<jsp:setProperty property="*" name="req"/>
	
	<!--  머릿말이 들어갈 부분 -->
	<jsp:include page="scope/header.jsp"></jsp:include>
	<hr/>
	
	<h1>머릿말과 꼬릿말을 직접 입력을 해서 설정</h1>
	<form action="requestScope.jsp" method="post">
		머릿말에 들어갈 내용 : <br/>
		<textarea rows="2" cols="60" name="header"></textarea><p/>
		꼬리말에 들어갈 내용 : <br/>
		<textarea rows="2" cols="60" name="footer"></textarea><p/>
		<input type="submit" value="새로고침"/>
	</form>
	<hr/>
	<!-- 꼬리말이 들어갈 부분 -->
	<jsp:include page="scope/footer.jsp"></jsp:include>
	
</body>
</html>