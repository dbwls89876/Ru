<%@page import="java.util.ArrayList"%>
<%@page import="vo.FileValue"%>
<%@page import="java.util.Enumeration"%>
<%@page import="com.oreilly.servlet.multipart.DefaultFileRenamePolicy"%>
<%@page import="com.oreilly.servlet.MultipartRequest"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<%
	String uploadPath= application.getRealPath("/upload");
	int size=10*1024*1024;
	
	MultipartRequest multi = new MultipartRequest(request, uploadPath, size, "UTF-8", new DefaultFileRenamePolicy());
	String name = multi.getParameter("name");
	String subject = multi.getParameter("subject");
	
//	ArrayList<FileValue> list = new ArrayList<FileValue>();
	Enumeration files = multi.getFileNames();
/* 	while(files.hasMoreElements()){
		FileValue fv = new FileValue();
		String file = (String)files.nextElement();
		fv.setFileName(multi.getFilesystemName(file));
		fv.setOrigFileName(multi.getOriginalFileName(file));
		list.add(fv);
	} */
%>
<html>
<head>
<meta charset="UTF-8">
<title>파일 업로드</title>
</head>
<body>
<form name="filecheck" action="multiFileCheck.jsp" method="post">
		<input type="hidden" name="name" value="<%=name %>">
	<input type="hidden" name="subject" value="<%=subject %>">
	<%// for(int i = 0; i<list.size(); i++) {%>
	<%-- <input type="hidden" name="filename1" value="<%=//list.get(i).getFileName() %>">
	<input type="hidden" name="origfilename1" value="<%=//list.get(i).getFileName() %>"> --%>
<%//} %>
<%while(files.hasMoreElements()){ 
	String file=(String)files.nextElement();
%>
	<input type="hidden" name="filename1" value="<%=multi.getFilesystemName(file)%>" >
	<input type="hidden" name="origfilename1" value="<%=multi.getOriginalFileName(file) %>">
 <%} %>
</form>
<a href="#" onclick="filecheck.submit()">업로드 확인 및 다운로드 페이지 이동</a>
</body>
</html>