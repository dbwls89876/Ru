<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<%
	request.setCharacterEncoding("utf-8");
	String name = request.getParameter("cname");
	String value = request.getParameter("cvalue");
	Cookie cookie = null;
	
	if(name!=null&&value!=null){
		cookie = new Cookie(name, value);
	}else{
		cookie = new Cookie("name", "홍길동");
	}
	response.addCookie(cookie);
	response.sendRedirect("cookieTest2.jsp");
%>
