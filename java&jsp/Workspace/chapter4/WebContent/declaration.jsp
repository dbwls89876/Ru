<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>

<h1><%=getStr() %></h1>
<%! private String getStr(){ 
	str+="테스트입니다.";
	return str;
}
private String str = "선언문 ";
%>

<%! private String str1="jsp 스터디"; %>
<%!
	public String checkStr(){
		if(str1==null) return"no";
		else return "ok";
}
%>


