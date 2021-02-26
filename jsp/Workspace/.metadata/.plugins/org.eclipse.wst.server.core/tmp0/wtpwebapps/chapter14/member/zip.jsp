<%@ page import="java.sql.*" %>
<%@ page import="javax.sql.*" %>
<%@ page import="javax.naming.*" %>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<script>
function ok(f){
	opener.document.getElementById("zip").value=f.zip.value;
	opener.document.getElementById("addr1").value=f.zip.value;
	window.close();
}
</script>
<body>
<!-- 시도, 시군구 , (연?면리?) 도로? 빌딩번호1,2-->
	<form action="zip.jsp" name="zipform" method="post">
		도로명 검색 : 
		<input type="text" id="search" name="search"> <input type="submit" value="검색">
	</form>
	<p>

<%
request.setCharacterEncoding("utf-8");
Connection conn=null;
PreparedStatement pstmt=null;
ResultSet rs = null;
String doro = request.getParameter("search");
if(doro!=null){
try{
	Context init = new InitialContext();
	DataSource ds = (DataSource) init.lookup("java:comp/env/jdbc/mySQLDB");
	conn = ds.getConnection();
	
	String sql = "select * from zipcode where doro like ";
	String[] arr = doro.split(" "); // 공백 기준 주소값을 나눔
	for(int i = 0; i<arr.length; i++){
		switch(i){
		case 0 : sql = sql + "'" + arr[0] + "%'";break;
		case 1 : sql = sql + " and buildingNo1 like '" + arr[1] + "%'";break;
		case 2 : sql = sql + " and buildingNo2 like '" + arr[2] + "%'";break;
		}
	}
	sql += " order by sido, sigungu, doro, buildingNo1, buildingNo2";
	out.println(sql);
	pstmt = conn.prepareStatement(sql);
	rs = pstmt.executeQuery();
	%>
			<table border="1">
				<tr>
					<td>우편번호</td>
					<td>도로명 주소</td>
				</tr>	
				
	<%
	while(rs.next()){
	String zipCode=rs.getString("zipCode");
	String addr1=rs.getString("sido")+rs.getString("sigungu")+rs.getString("doro")
	+rs.getString("eupmyeon")+rs.getString("buildingNo1")+"-"+rs.getString("buildingNo2");
	%>		
				<form>
					<tr>
						<td><%=zipCode %><input type="hidden" name="zipCode" id="zipCode" value="zipCode"></td>
						<td><%=addr1 %><input type="hidden" name="addr1" id="addr1" value="addr1"></td>
						<td><input type="button" value="선택" onclick="ok(this.form)"/></td>
					</tr>
				</form>
	<%}%>
	<%
}catch(Exception e){
	e.printStackTrace();
}finally{
	if(conn!=null)
		conn.close();
}}
%>
</table>
</body>
</html>