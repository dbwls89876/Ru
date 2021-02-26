<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<jsp:useBean id="req" class="scope.RequestScopeBean" scope="request"></jsp:useBean>
<!--  requestscopebean 객체의 getheader 메서드를 이용하여 자바빈 객체 내부에 저장되어 있는 폼 태그에 입력한 헤더 값 전달 받기 -->
<jsp:getProperty property="header" name="req"/>