<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>로그인 페이지</title>
<style>
	#loginFormArea{
		margin:auto;
		width : 400px;
		height : 200px;
		border : 2px double purple;
		border-radius : 10px;
		text-align: center;
	}
	fieldset{
		text-align: center;
		border: none;
	}
	#selectButton{
		margin-top: 10px;
	}
	table{
		margin : auto;
		width : 380px;
	}
	.td_title{
		font-weight: bold;
		font-size: x-large;
	}
	.td_left{
		width:180px;
	}
	.td_right{
		width: 200px;
		background: skyblue;
	}
</style>
</head>
<body>
<section id = "loginFormArea">
	<h1>로그인</h1>
	<form action="login" method = "post">
	<fieldset>
		<table>
			<tr>
				<td class="td_left">
					<label for = "id">아이디 : </label>
				</td>
				<td class="td_right">
					<input type="text" name="id" id="id"/>
				</td>
			</tr>
			<tr>
				<td class="td_left">
					<label for = "password">비밀번호 : </label>
				</td>
				<td class="td_right">
					<input type="password" name="password" id="password"/>
				</td>
			</tr>
		</table>
		<input type="submit" value="로그인" id="selectButton"/>
	</fieldset>
	</form>
</section>
</body>
</html>