<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>회원 관리 시스템 회원 가입 페이지</title>
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
<script>
var chkId = false;
var idcheck;
	function formCheck(f){
		if(f.id.value.trim()==""){
			alert("아이디를 입력하세요");
			f.id.value="";
			f.id.focus();
			return false;
		}
		if(f.pass.value.trim()==""){
			alert("비밀번호를 입력하세요");
			f.pass.value="";
			f.pass.focus();
			return false;
		}
		if(f.pass.value.length<5 || f.pass.value.length>10){
			alert("비밀번호는 5~10자로 설정하세요.")
			f.pass.value="";
			f.pass.check="";
			f.pass.focus();
		}
		if(f.pass.value.trim()!=f.passcheck.value.trim()){
			alert("비밀번호가 동일하지 않습니다.");
			f.passcheck.value="";
			f.passcheck.focus();
			return false;
		}
		if(isNaN)
		if(f.name.value.trim()==""){
			alert("이름을 입력하세요");
			f.name.value="";
			f.name.focus();
			return false;
		}
		if(f.age.value.trim()==""){
			alert("나이를 입력하세요");
			f.age.value="";
			f.age.focus();
			return false;
		}
		if(f.email.value.trim()==""){
			alert("이메일 주소를 입력하세요");
			f.email.value="";
			f.email.focus();
			return false;
		}
		f.submit();
	}
</script>
</head>
<body>
<form name="joinform" action="joinProcess.jsp" method="post">
	<table border=1>
		<tr><td colspan="2" class="td_title">회원 가입 페이지</td></tr>
		<tr>
			<td><label for="id">아이디 : </label></td>
			<td><input type="text" name="id" id="id" required/> <input type="button" 
			value="아이디 중복확인" id="idCheck" onclick="window.open('idCheck1.jsp?openInit=true', '', 'width=300, height=200')"></td>
		</tr>
		<tr>
			<td><label for="pass">비밀번호 : </label></td>
			<td><input type="password" name="pass" id="pass"/></td>
		</tr>
		<tr>
			<td><label for="passcheck">비밀번호 확인 : </label></td>
			<td><input type="password" name="passcheck" id="passcheck"/></td>
		</tr>
		<tr>
			<td><label for="name">이름 : </label></td>
			<td><input type="text" name="name" id="name"/></td>
		</tr>
		<tr>
			<td><label for="age">나이 : </label></td>
			<td><input type="text" name="age" id="age"/></td>
		</tr>
		<tr>
			<td><label for="gender1"></label>성별 : </td>
			<td>
				<input type="radio" name="gender" value="남" checked id="gender1"/>남자
				<input type="radio" name="gender" value="여" id="gender2"/>여자
			</td>
		</tr>
		<tr>
			<td><label for="email">이메일 주소 : </label></td>
			<td><input type="text" name="email" id="email"/></td>
		</tr>
		<tr>
			<td><label for="zip">우편번호 : </label></td>
			<td align=left><input type="text" name="zip" id="zip" size="6" readonly/> <input type="button" name="zipSearch" id="zipSearch" 
			value="검색" onclick="window.open('zip.jsp', '', 'width=500, height=500')"></td>
		</tr>
		<tr>
			<td><label for="addr1" >주소 : </label></td>
			<td align=left><input type="text" name="addr1" id="addr1" size=50 readonly/></td>
		</tr>
		<tr>
			<td><label for="addr2" >주소 상세 : </label></td>
			<td align=left><input type="text" name="addr2" id="addr2" size=50 readonly/></td>
		</tr>
		<tr>
			<td colspan="2">
				<!-- <form onsubmit = "return 함수()" -->
				<a href="javascript:formCheck(document.joinform)">회원 가입</a>&nbsp;&nbsp;
				<a href="javascript:joinform.reset()">다시작성</a>
			</td>
		</tr>
	</table>
</form>
</body>
</html>