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
String sql;
if(text==""){
	sql = "select * from student";
}
else if(text.length()==1){
	sql = "select * from student where " + student + " like '%" + text + "'";
}
else{
	sql ="select * from student where " + student + " = " + text;
}

out.println(sql);
PreparedStatement pstmt = null;
ResultSet rs = null;

try{
	Context init = new InitialContext();
	DataSource ds = (DataSource) init.lookup("java:comp/env/jdbc/OracleDB");
	conn = ds.getConnection();
	
	pstmt = conn.prepareStatement(sql);
	rs = pstmt.executeQuery();
	
	while(rs.next()){
		out.println("<h3>" + rs.getInt(1) + "," + rs.getString(2) + "</h3>");
	}
}catch(Exception e){
	out.println("<h3>데이터 가져오기에 실패하였습니다.</h3>");
	e.printStackTrace();
}finally{
	try{
		if(rs!=null)
			rs.close();
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