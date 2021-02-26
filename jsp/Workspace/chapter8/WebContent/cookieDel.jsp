<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>	
<%
	String name = request.getParameter("cname");

	if(name != null){
		Cookie cookie = new Cookie(name, "");
		cookie.setMaxAge(0);
		response.addCookie(cookie);
	}
	
/* 	Cookie cookies[] = null;
	if(cookie!=null){
		cookies = request.getCookies();
	}
	for(int i = 0; i<cookies.length; i++){
		cookies[i].setMaxAge(0); 
		response.addCookie(cookies[i]);
	}
*/
response.sendRedirect("cookieTest2.jsp"); 
%>