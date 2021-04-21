<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<%session.setAttribute("id", request.getParameter("id")); %>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<%
String id = request.getParameter("id");
if(id==null || id.equals("")){
%>
	<script>
	alert("아이디 없음");
	if(confirm("새로 로그인하시겠습니까?")){
		location.href="sessionLogin1.jsp"
	}
	</script>
	<a href="sessionLogin1.jsp">로그인 페이지로 이동</a>
<%
}%>
<h3>로그인되었습니다.</h3>
<h3>로그인 아이디 : <%=(String)session.getAttribute("id") %></h3>
<a href="sessionLogout.jsp">로그아웃</a>
</body>
</html>