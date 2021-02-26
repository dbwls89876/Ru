<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>파일 업로드 폼</title>
<style>
	#uploadFormArea{
	margin : auto;
	width : 350px;
	border : 1px solid black;
	}
	.td_title{
		font-size: xx-large;
		text-align: center;
	}
</style>
<script>
	var cnt = 1;
	var oTb1;
	
	function insRow(){
		cnt++;
		oTb1 = document.getElementById("addTable");
		var oRow = oTb1.insertRow();
		oRow.onmouseover = function(){
			oTb1.clickedRowIndex = this.rowIndex
		};
		var oCell1 = oRow.insertCell();
		var oCell2 = oRow.insertCell();
		
		var frmTag1 = "<label for='fileName"+cnt+"'>파일명 : </label>";
		var frmTag2 = "<input type='file' name='fileName"+cnt+"' id='fileName"+cnt+"'>";
		frmTag2 += "<input type=button value='삭제' onClick='removeRow()' stype='cursor:hand'>";
		oCell1.innerHTML = frmTag1;
		oCell2.innerHTML = frmTag2;
	}
	
	function removeRow(){
		oTb1.deleteRow(oTb1.clickedRowIndex);
	}
	
	function frmCheck(){
		var frm = document.f;
		for(var i = 0; i<=frm.elements.length - 1; i++){
			if(frm.elements[i].name.indexOf("fileName")>-1){
				if(!frm.elements[i].value){
				alert("업로드 할 파일을 선택하세요");
				frm.elements[i].focus();
				return false;
				}
			}
		} 
	}
</script>
</head>
<body>
<section id = "uploadFormArea">
	<form name="f" action="fileUpload" method="post" enctype="multipart/form-data" onsubmit="return frmCheck()">
		<table width="100%">
			<tr><td colspan="2" class="td_title">파일 업로드 폼</td></tr>
			<tr>
				<td><label for = "name">올린 사람 : </label></td>
				<td><input type="text" name="name" id="name"></td>
			</tr>
			<tr>
				<td><label for="subject">제목 : </label></td>
				<td><input type="text" name="subject" id="subject"></td>
			</tr>
			<tr>
				<td colspan="2">
					<table id = "addTable" border="1">
						<tr>
							<td><label for = "filename1">파일명1 : </label></td>
							<td><input type="file" name="filename1" id="filename1"></td>
						</tr>
						<tr>
							<td><label for = "filename2">파일명2 : </label></td>
							<td><input type="file" name="filename2" id="filename2"></td>
						</tr>
					</table>
				</td>
			</tr>
			<tr><td colspan="2" align="center"><input type="submit" value="업로드"></td></tr>
 		</table>
	</form>
	<input name="addButton" type="button" style="curosr:pointer" onclick="insRow()" value="입력창 추가">
</section>
</body>
</html>