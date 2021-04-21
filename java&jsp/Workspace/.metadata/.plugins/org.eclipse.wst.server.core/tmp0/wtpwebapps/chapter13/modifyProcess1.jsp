<%@ page import="java.sql.*" %>
<%@ page import = "javax.sql.*" %>
<%@ page import = "javax.naming.*" %>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<%
request.setCharacterEncoding("utf-8");
if(session.getAttribute("id")!=null&&((String)session.getAttribute("id")).equals("admin")){
	out.println("<script>");
	out.println("alert('관리자로 로그인해주세요.' + id)");
	out.println("location.href='loginForm.jsp'");
	out.println("</script>");
}

String mod_id = request.getParameter("id");
String pass=request.getParameter("pass");
String name=request.getParameter("name");
int age=Integer.parseInt(request.getParameter("age")==null || request.getParameter("age").trim().equals("") ? "0" : request.getParameter("age"));
String gender=request.getParameter("gender");
String email=request.getParameter("email");


Connection conn=null;
PreparedStatement pstmt=null;

try{
	Context init = new InitialContext();
	DataSource ds = (DataSource) init.lookup("java:comp/env/jdbc/OracleDB");
	conn = ds.getConnection();
	conn.setAutoCommit(false);
	
	pstmt=conn.prepareStatement("update member set password = ?, name = ?, age = ?, gender = ?, email = ? where id = ?");
	pstmt.setString(1, pass);
	pstmt.setString(2, name);
	pstmt.setInt(3, age);
	pstmt.setString(4, gender);
	pstmt.setString(5, email);
	pstmt.setString(6, mod_id);

	int result = pstmt.executeUpdate();
	out.println(result);
	out.println(1);
	if(result>0){
		conn.commit();
		out.println("<script>");
		out.println("alert('수정이 완료되었습니다.')");
		out.println("location.href='main.jsp'");
		out.println("</script>");
	}else{
		conn.rollback();
		out.println("<script>");
		out.println("alert('오류가 발생했습니다. 다시 수정해주세요.')");
		out.println("history.back();");
		out.println("</script>");
	}
}catch(Exception e){
	e.printStackTrace();
	if(conn!=null){
		conn.rollback();
	}
}
finally{
	try{
		if(pstmt!=null)
			pstmt.close();
		if(conn!=null)
			conn.close();
	}catch(Exception e){
		e.printStackTrace();
	}
}
%>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>

</body>
</html>