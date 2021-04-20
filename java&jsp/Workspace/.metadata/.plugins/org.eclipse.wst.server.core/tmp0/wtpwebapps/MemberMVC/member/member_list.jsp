<%@page import="java.sql.*" %>
<%@page import="java.util.*, vo.*" %>
<%@page import="javax.sql.*"%>
<%@page import="javax.naming.*"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<%
	ArrayList<Member>list = (ArrayList<Member>)request.getAttribute("memberList");
	PageInfo pageInfo = (PageInfo)request.getAttribute("pageInfo");
	if(pageInfo!=null){
	int listCount = pageInfo.getListCount();
	int nowPage = pageInfo.getPage();
	int maxPage = pageInfo.getMaxPage();
	int startPage = pageInfo.getStartPage();
	int endPage = pageInfo.getEndPage();
%>
<html>
<head>
<meta charset="UTF-8">
<title>회원 관리 시스템 관리자모드(회원 목록 보기)</title>
<style>
	table{
		margin : auto;
		width : 400px;
		border : 1px solid gray;
		text-align: center;
	}
	.td_title{
		font-weight: bold;
		font-size: x-large;
	}
	#pageList{
		margin:auto;
		width: 500px;
		text-align: center;
	}
</style>
</head>
<body>
<table>
	<tr><td colspan=2 class="td_title">회원 목록</td></tr>
	<%for(int i = 0; i<list.size(); i++){ %>
	<tr>
		<td>
			<a href="memberInfo.mem?id=<%=list.get(i).getId() %>"><%=list.get(i).getId() %></a>
		</td>
		<td>
			<a href="memberModForm.mem?id=<%=list.get(i).getId() %>">수정</a>
			<a href="memberDel.mem?id=<%=list.get(i).getId() %>">삭제</a>
		</td>
	</tr>
	<%} %>
</table>
<section id = "pageList">
	<%if(nowPage<=1){ %>
		[이전]&nbsp;
	<%}else{ %>
		<a href="boardList.bo?page=<%=nowPage-1 %>">[이전]</a>&nbsp;
	<%} %>
	<%for(int a = startPage; a<=endPage; a++){ 
		if(a==nowPage){%>
			[<%=a %>]
		<%}else{ %>
			<a href="boardList.bo?page=<%=a %>">[<%=a %>]</a>&nbsp;
		<%} %>
	<%} %>
	<%if(nowPage>=maxPage){ %>
		[다음]
	<%}else{ %>
		<a href="boardList.bo?page=<%=nowPage+1 %>">[다음]</a>
	<%} %>
</section>
<%}else{ %>
	<section id="emptyArea">등록된 글이 없습니다.</section>

<%} %>
<script type="text/javascript">
	if(conform('정말 삭제하시겠습니까?')){
		location.href="memberDel";
		alert(id);
	}
		
</script>
</body>
</html>