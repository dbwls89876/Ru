<%@ page import="java.sql.*" %>
<%@ page import="javax.sql.*" %>
<%@ page import = "javax.naming.*" %>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<%
	String id = null;
	if(session.getAttribute("id")!=null){
		id=((String)session.getAttribute("id")).trim();
	}
	
%>
<html>
<head>
<meta charset="UTF-8">
<title>회원 관리 시스템 메인 페이지</title>
</head>
<body>
<%if(id != null){ %>
<h3><%=id %>로 로그인하셨습니다.</h3>
<a href="logout.log">로그아웃</a>&nbsp;&nbsp;
<%if(id!=null && id.equals("admin")){ %>
	<a href="memberList.mem">관리자모드 접속(회원목록보기)</a>
<%}
}else{%>
<a href='loginForm.log'>로그인</a>
<%} %>

</body>
</html>