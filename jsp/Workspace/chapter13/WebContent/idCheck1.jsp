<%@ page import="java.sql.*" %>
<%@ page import="javax.sql.*" %>
<%@ page import = "javax.naming.*" %>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>

<%
	request.setCharacterEncoding("UTF-8");
	String openInit = "false";
	if(request.getParameter("openInit")!=null){
		openInit = "true";
	}
%>
<script>
function init() {
	if(<%=openInit%>){
		document.getElementById("id").value=opener.document.getElementById("id").value;
	}
}
function ok(v){
	opener.idcheck = v.trim();
	opener.document.getElementById("id").value=v;
	opener.chkId = true;
	window.close();
}
</script>

<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body onload = "init()">
 <form action="idCheck1.jsp" method="post" name=f>
	<input type="text" name="id" id="id">
	<input type="submit" value="중복확인">
</form>
<%
if(request.getParameter("id") != null && !request.getParameter("id").trim().equals("")){
	String chk_id = request.getParameter("id");
	String useble = null;
	
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
		if(rs.next()){
			out.println("<h3>" + chk_id+" 는 사용 불가능한 아이디입니다. 다시 검색하세요.</h3>");
		}else{
			out.print("<h3>" + chk_id + "는 사용 가능한 아이디입니다.");
		}
	}catch(Exception e){
		e.printStackTrace();
	}finally{
		if(rs != null) rs.close();
		if(pstmt != null)pstmt.close();
		if(conn != null) conn.close();
	}
}
%>
</body>
</html>