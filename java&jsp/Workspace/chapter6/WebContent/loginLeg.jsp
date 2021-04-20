<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<%		String id = request.getParameter("id");
		String passwd = request.getParameter("passwd");
		if(id.equals("java")&&passwd.equals("java")) {
			session.setAttribute("id", id);
			response.sendRedirect("template.jsp");
		}
		else {
			out.println("<script>");
			out.println("alert('아이디나 비밀번호가 일치하지 않습니다')");
			out.println("history.back()");
			out.println("</script>");
		}
	%>
</body>
</html>