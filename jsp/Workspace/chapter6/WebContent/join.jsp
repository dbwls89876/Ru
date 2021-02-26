<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<!-- <script type="text/javascript">
	if(f.pass.value.trim()==""||f.pass.value==null){
		alert("비밀번호를 입력하세요!");
		f.pass.focus();
		return false;
	}
	if(f.name.value.trim()==""||f.name.value==null){
		alert("이름을 입력하세요!");
		f.name.focus();
		return false;
	}
	if(f.tel.value.trim()==""||f.tel.value==null){
		alert("전화번호를 입력하세요!");
		f.tel.focus();
		return false;
	}
</script>
 -->
<body>
<h1>회원 가입</h1>
	<form action="joinReg.jsp" method="post" onsubmit="return checkFrom(this)">
		아이디 :<input type = "text" name = "id"><br>
		비밀번호 :<input type = "text" name = "password"><br>
		회원명 :<input type = "text" name = "name"><br>
		전화번호 :<input type = "text" name = "tel"><br>
		<input type="submit" value="회원 가입"/>
	</form>
</body>
</html>