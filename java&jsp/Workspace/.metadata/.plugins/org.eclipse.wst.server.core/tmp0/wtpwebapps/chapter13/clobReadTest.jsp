<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@page import="java.sql.*" %>
<%@page import="javax.sql.*"%>
<%@page import="javax.naming.*"%>
<!DOCTYPE html>
<%
request.setCharacterEncoding("UTF-8");
String student = request.getParameter("student");
String text = request.getParameter("text");
Connection conn=null;

PreparedStatement pstmt = null;
StringBuffer sb = null;
ResultSet rs = null;

try{
	Context init = new InitialContext();
	DataSource ds = (DataSource) init.lookup("java:comp/env/jdbc/OracleDB");
	conn = ds.getConnection();
	pstmt = conn.prepareStatement("select * from clobtable where num=1");
	rs = pstmt.executeQuery();
	if(rs.next()){
		out.println(rs.getString("content"));
	}
}catch(Exception e){
	out.println("<h3>데이터 가져오기에 실패하였습니다.</h3>");
	e.printStackTrace();
}finally{
	try{
		pstmt.close();
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