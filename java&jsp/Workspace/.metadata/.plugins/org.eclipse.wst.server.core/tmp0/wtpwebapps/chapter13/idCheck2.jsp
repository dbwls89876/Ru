<%@ page import="java.sql.*" %>
<%@ page import="javax.sql.*" %>
<%@ page import = "javax.naming.*" %>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<%
	request.setCharacterEncoding("UTF-8");
	String openInit = "false";
	if(request.getParameter("openInit")!=null){
		openInit = "true";
	}
%>
<script>
function init() {
	if(<%=openInit%>){
		document.getElementById("id").value=opener.document.getElementById("id").value;
	}
}
function ok(v){
	opener.idcheck = v.trim();
	opener.document.getElementById("id").value=v;
	opener.chkId = true;
	window.close();
}
</script>

<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body onload = "init()">
<form action="idCheckProcess.jsp" method="post" name=f>
	<input type="text" name="id" id="id">
	<input type="submit" value="중복확인">
</form>
<%
	if(request.getParameter("chk_id")!=null){
		String chk_id = request.getParameter("chk_id");
		String useble = request.getParameter("useble");
		out.println("<hr>");
		if(useble.equals("yes")){
			out.print("<h3>" + chk_id + "는 사용 가능한 아이디입니다.");
			out.print(" <a href='#' onclick=\"ok('"+chk_id+"')\">사용하기</a><h3>");
		}else{
			out.println("<h3>" + chk_id+" 는 사용 불가능한 아이디입니다. 다시 검색하세요.</h3>");
		}
	}
%>
</body>
</html>