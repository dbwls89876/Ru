<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Request Test</title>
<style>
	h1, #commandCell{
	text-align: center;
	}
	table{
		margin: auto;
		width: 400px;
		border: 1px solid red;
	}
</style>
<script>
	function checkName(){
		if(document.f.name.value.trim()==''){
			alert('이름을 입력하세요');
			document.f.name.focus();
			return false;
		}
	}
	function checkName1(f1){
		if(f1.name.value == ''){
			alert('이름을 입력하세요');
			f1.name.focus();
			return false;
		}
	}
</script>
</head>
<body>
	<h1>Request 예제입니다.</h1>
	<form action="requestTest1.jsp" method="post" name="f" onsubmit="return checkName();">
		<table>
			<tr>
			<td><label for = "name">이름</label></td>
			<td><input type = "text" name="name" id="name"></td>
			</tr>
			<tr>
				<td><label for="gender" >성별</label></td>
				<td>남<input type="radio" name="gender" value="male" id="gender">여<input type="radio" name="gender" value="female"></td>
			</tr>
			<tr>
				<td><label for = "hobby">취미</label></td>
				<td>독서<input type="checkbox" name="hobby" value="독서" id="hobby">
				게임<input type="checkbox" name="hobby" value="게임">
				TV시청<input type="checkbox" name="hobby" value="TV시청">
				축구<input type="checkbox" name="hobby" value="축구">
				기타<input type="checkbox" name="hobby" value="기타">
				</td>
			</tr>
			<tr>
				<td colspan="2" id="commandCell"><input type="submit" value="전송">
				<input type="button" value="버튼타입 전송" onclick="checkName1(this.form);this.form.submit();"/>
				<button>버튼태그 전송</button>
				<a href="javascript:checkName();document.f.submit();">전송</a>
				</td>
			</tr>
		</table>
	</form>
</body>
</html>