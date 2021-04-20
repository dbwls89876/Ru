<%@ page import="java.sql.*" %>
<%@ page import="javax.sql.*" %>
<%@ page import = "javax.naming.*" %>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<%
	String id = null;
	if(session.getAttribute("id")!=null){
		id=(String)session.getAttribute("id");
	}else{
		out.println("<script>");
		out.println("alert('아이디를 입력해주세요')");
		out.println("location.href='loginForm.jsp'");
		out.println("</script>");
	}
	
 	Connection conn=null;
	PreparedStatement pstmt=null;
	ResultSet rs = null;
	
	
	try{
		Context init = new InitialContext();
		DataSource ds = (DataSource) init.lookup("java:comp/env/jdbc/OracleDB");
		conn = ds.getConnection();
		
		pstmt = conn.prepareStatement("select * from member where id=?");
		pstmt.setString(1, id);
		rs = pstmt.executeQuery();
		rs.next();
	
	}catch(Exception e){
		e.printStackTrace();
	} 
%>
<html>
<head>
<meta charset="UTF-8">
<title>회원 관리 시스템 메인 페이지</title>
</head>
<body>
<input type="hidden" name="id" value=<%=rs.getString("id") %>> 

<h3><%=id %>로 로그인하셨습니다.</h3>
<a href="logout.jsp">로그아웃</a>&nbsp;&nbsp;

<a href="member_mod.jsp?id=<%=rs.getString("id")%>">회원 정보 수정</a>&nbsp;&nbsp; 
<%if(id.equals("admin")){ %>
	<a href="member_list.jsp">관리자모드 접속(회원목록보기)</a>
<%} %>
</body>
</html>