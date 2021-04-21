<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<jsp:useBean id="req" class="scope.RequestScopeBean" scope="request"></jsp:useBean>
<jsp:getProperty property="footer" name="req"/>