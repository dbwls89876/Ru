<%@ page import="java.sql.*" %>
<%@ page import="javax.sql.*" %>
<%@ page import = "javax.naming.*" %>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<%
String chk_id = request.getParameter("id");
Connection conn=null;
PreparedStatement pstmt=null;
ResultSet rs = null;
try{
	Context init = new InitialContext();
	DataSource ds = (DataSource) init.lookup("java:comp/env/jdbc/OracleDB");
	conn = ds.getConnection();

	pstmt = conn.prepareStatement("select * from member where id=?");
	pstmt.setString(1, chk_id);
	rs = pstmt.executeQuery();
	request.setAttribute("chk_id", chk_id);
	if(rs.next()){
		response.sendRedirect("idCheck1.jsp?chk_id=" + chk_id + "&useble=no");
	}else{
		response.sendRedirect("idCheck1.jsp?chk_id=" + chk_id +  "&useble=yes");
	}
}catch(Exception e){
	e.printStackTrace();
}finally{
	if(rs != null) rs.close();
	if(pstmt != null)pstmt.close();
	if(conn != null) conn.close();
}
%>
