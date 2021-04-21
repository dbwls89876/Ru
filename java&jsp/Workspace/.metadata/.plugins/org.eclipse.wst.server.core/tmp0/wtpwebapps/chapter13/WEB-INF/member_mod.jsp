<%@page import="java.sql.*" %>
<%@page import="javax.sql.*"%>
<%@page import="javax.naming.*"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<%
	String id = null;
	if((session.getAttribute("id")==null) || (!((String)session.getAttribute("id")).equals("admin"))){
		out.println("<script>");
		out.println("alert('관리자로 로그인하세요0')");
		out.println("location.href='loginForm.jsp'");
		out.println("</script>");
	}
	
	String mod_id = request.getParameter("id");
	Connection conn=null;
	PreparedStatement pstmt=null;
	ResultSet rs = null;
	
	try{
		Context init = new InitialContext();
		DataSource ds = (DataSource) init.lookup("java:comp/env/jdbc/OracleDB");
		conn = ds.getConnection();

		pstmt = conn.prepareStatement("select * from member where id=?");
		pstmt.setString(1, mod_id);
		rs = pstmt.executeQuery();
		rs.next();
%>
<html>
<head>
<meta charset="UTF-8">
<title>회원 수정 페이지</title>
<style >
	table{
		margin : auto;
		width : 800px;
		border : 1px solid gray;
		text-align: left;
	}
	.td_title{
		font-weight: bold;
		font-size: x-large;
	}
</style>
</head>
<body>
<form name="modform" action="modifyProcess.jsp" method="post">
	<table border=1>
		<tr><td colspan="2" class="td_title">회원 수정 페이지</td></tr>
		<tr>
			<td><label for="id">아이디 : </label></td>
			<td align = left><%=rs.getString("id") %>
			</td>
			
		</tr>
		<tr>
			<td><label for="pass">비밀번호 : </label></td>
			<td><input type="password" name="pass" id="pass" value='<%=rs.getString("password") %>'></td>
		</tr>
		<tr>
			<td><label for="passcheck">비밀번호 확인 : </label></td>
			<td><input type="password" name="passcheck" id="passcheck"/></td>
		</tr>
		<tr>
			<td><label for="name">이름 : </label></td>
			<td><input type="text" name="name" id="name" value='<%=rs.getString("name") %>'></td>
		</tr>
		<tr>
			<td><label for="age">나이 : </label></td>
			<td><input type="text" name="age" id="age" value='<%=rs.getString("age") %>'></td>
		</tr>
		<tr>
			<td><label for="gender1"></label>성별 : </td>
			<td>
				<input type="radio" name="gender" value="남" <%=rs.getString("gender").equals("남")?"checked":"" %> id="gender1"/>남자
				<input type="radio" name="gender" value="여" <%=rs.getString("gender").equals("여")?"checked":"" %> id="gender2"/>여자
			</td>
		</tr>
		<tr>
			<td><label for="email">이메일 주소 : </label></td>
			<td><input type="text" name="email" id="email" value='<%=rs.getString("email") %>'></td>
		</tr>
		<tr>
			<td><label for="post">우편번호 : </label></td>
			<td><input type="text" name="post" id="post"/> <input type="button" value="검색"></td>
		</tr>
		<tr>
			<td><label for="adress1" >주소 : </label></td>
			<td><input type="text" name="address1" id="address1" width=80%/></td>
		</tr>
		<tr>
			<td><label for="address2" >주소 상세 : </label></td>
			<td><input type="text" name="address2" id="address2" width=80%/></td>
		</tr>
		<tr>
			<td colspan="2">
				<!-- <form onsubmit = "return 함수()" -->
				<a href="javascript:modform.submit()">수정</a>&nbsp;&nbsp;
				<a href="javascript:modform.reset()">다시작성</a>&nbsp;&nbsp;
			</td>
		</tr>
	</table>
</form>
</body>
</html>
<%
	}catch(Exception e){
		e.printStackTrace();
	}
%>