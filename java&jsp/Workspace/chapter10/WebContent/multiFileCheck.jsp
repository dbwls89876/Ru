<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<%
	request.setCharacterEncoding("UTF-8");
	String name=request.getParameter("name");
	String subject = request.getParameter("subject");
	String[] filename=request.getParameterValues("filename1");
	String[] origfilename=request.getParameterValues("origfilename1");
%>
<html>
<head>
<title>파일 업로드 확인 및 다운로드</title>
</head>
<body>
올린사람 : <%=name %><br>
제목 : <%=subject %><br>
<%for(int i = 0; i<filename.length; i++){ %>
	파일명 : <a href="file_down.jsp?file_name=<%=filename[i] %>"><%=origfilename[i] %></a><br>
<%} %>

</body>
</html>