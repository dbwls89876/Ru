<%@page import="java.sql.*" %>
<%@page import="javax.sql.*"%>
<%@page import="javax.naming.*"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
<%@ taglib prefix="sql" uri="http://java.sun.com/jsp/jstl/sql" %>
<%@ taglib prefix="fn" uri="http://java.sun.com/jsp/jstl/functions" %>
<!DOCTYPE html>
<c:if test="${id == null or id ne 'admin'}">
		<script>
		alert('관리자로 로그인하세요');
		location.href='loginForm.jsp';
	</script>
</c:if>
<sql:setDataSource var="con" dataSource="jdbc/OracleDB"/>
<sql:query var="rs" dataSource="${con }">
	select * from member where id=?
	<sql:param>${param.id }</sql:param>
</sql:query>

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
<form name="modform" action="modifyProcess1.jsp" method="post">
	<table border=1>
		<tr><td colspan="2" class="td_title">회원 수정 페이지</td></tr>
		<c:choose>
			<c:when test="${!empty rs.rows[0] }">
			<c:set var="row" value="${rs.rows[0] }"/>
		<tr>
			<td><label for="id">아이디 : </label></td>
			<td align = left>${row.id }
			<input type="hidden" name="id" id="id" value=${row.id }>
			</td>
			
		</tr>
		<tr>
			<td><label for="pass">비밀번호 : </label></td>
			<td><input type="password" name="pass" id="pass" value='${row.pasword }'></td>
		</tr>
		<tr>
			<td><label for="passcheck">비밀번호 확인 : </label></td>
			<td><input type="password" name="passcheck" id="passcheck"/></td>
		</tr>
		<tr>
			<td><label for="name">이름 : </label></td>
			<td><input type="text" name="name" id="name" value='${row.name }'></td>
		</tr>
		<tr>
			<td><label for="age">나이 : </label></td>
			<td><input type="text" name="age" id="age" value='${row.age }'></td>
		</tr>
		<tr>
			<td><label for="gender1"></label>성별 : </td>
			<td>
				<input type="radio" name="gender" value="남" ${row.gender eq '남' ? 'checked' : ''} >남자
				<input type="radio" name="gender" value="여" ${row.gender eq '여' ? 'checked' : ''}/>여자
			</td>
		</tr>
		<tr>
			<td><label for="email">이메일 주소 : </label></td>
			<td><input type="text" name="email" id="email" value='${row.email }'></td>
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
		</c:when>
		</c:choose>
	</table>
</form>
</body>
</html>
