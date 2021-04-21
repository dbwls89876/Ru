<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%
	String name="";
	String value="";
	String cookie = request.getHeader("Cookie");
	Cookie cookies[] = null;
	if(cookie!=null){
		cookies = request.getCookies();
		
		for(int i = 0; i<cookies.length; i++){
/* 			if(cookies[i].getName().equals("name")){
				name=cookies[i].getName();
				value=cookies[i].getValue(); */
				out.println("<h2>쿠키 이름 = " + cookies[i].getName() + "<h2>");
				out.println("<h2>쿠키 값 = " + cookies[i].getValue()+"<h2>");
			}
		}
	
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Cookie Test</title>
</head>
<body>
<%-- <h2>쿠키 이름 = <%=name %></h2>
<h2>쿠키 값 = <%=value %></h2> --%>
<form action="cookieModify.jsp" name="f" method="get">
	쿠키 선택 :
	<select name="cname">
		<%
		if(cookies!=null){
		for(int i = 0; i<cookies.length; i++){
				if(!cookies[i].getName().equals("JSESSIONID")){
					%>
					<option value="<%=cookies[i].getName() %>"><%=cookies[i].getName() %></option>
		<%
		}}}	%>
	</select>
	변경 값 : <input type="text" name="cvalue">
	<br>
	<input type="submit" value="쿠키값 수정하기"/>
	<input type="button" value="쿠키 삭제하기" onclick="f.action='cookieDel.jsp';f.submit();">
</form>
<a href="javascript:f.submit();">name 쿠키 값 수정하기</a>
<a href="cookieDel.jsp">쿠키 삭제하기</a>
</body>
</html>