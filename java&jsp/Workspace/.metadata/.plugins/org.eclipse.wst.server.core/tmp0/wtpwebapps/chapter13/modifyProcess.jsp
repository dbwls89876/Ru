<%@page import="java.sql.*" %>
<%@page import="javax.sql.*"%>
<%@page import="javax.naming.*"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<%
request.setCharacterEncoding("utf-8");
if(session.getAttribute("id")!=null&&((String)session.getAttribute("id")).equals("admin")){
	out.println("<script>");
	out.println("alert('관리자로 로그인해주세요3.' + id)");
	out.println("location.href='loginForm.jsp'");
	out.println("</script>");
}
String id=request.getParameter("id");
String pass=request.getParameter("pass");
String name=request.getParameter("name");
int age=Integer.parseInt(request.getParameter("age"));
String gender=request.getParameter("gender");
String email=request.getParameter("email");

Connection conn=null;
PreparedStatement pstmt=null;

try{
	Context init = new InitialContext();
	DataSource ds = (DataSource) init.lookup("java:comp/env/jdbc/OracleDB");
	conn = ds.getConnection();
	pstmt=conn.prepareStatement("update member set password = ?, name = ?, age = ?, gender = ?, email = ? where id = ?");
	pstmt.setString(1, pass);
	pstmt.setString(2, name);
	pstmt.setInt(3, age);
	pstmt.setString(4, gender);
	pstmt.setString(5, email);
	pstmt.setString(6, id);

	int result = pstmt.executeUpdate();
	if(result>0){
		out.println("<script>");
		out.println("location.href='member_list.jsp'");
		out.println("</script>");
	}else{
		out.println("<script>");
		out.println("alert('수정되지 않았습니다')");
		out.println("location.href='member_mod.jsp'");
		out.println("</script>");
	}
}catch(Exception e){
	e.printStackTrace();
}
finally{
	try{
		pstmt.close();
		conn.close();
	}catch(Exception e){
		e.printStackTrace();
	}
}
%>