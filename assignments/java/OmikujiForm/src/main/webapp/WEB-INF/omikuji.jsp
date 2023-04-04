<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<!-- for forms -->
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form" %>
<%@ taglib prefix = "fmt" uri = "http://java.sun.com/jsp/jstl/fmt" %>
<!-- for validation -->
<%@ page isErrorPage="true" %>
<!DOCTYPE html>
<html>
<head>
<!-- for Bootstrap CSS -->
<link rel="stylesheet" href="/webjars/bootstrap/css/bootstrap.min.css" />
<!-- YOUR own local CSS -->
<link rel="stylesheet" type="text/css" href="/css/style.css">
<!-- For any Bootstrap that uses JS -->
<script src="/webjars/bootstrap/js/bootstrap.min.js"></script>
<meta charset="UTF-8">
<title>Omikuji</title>
</head>
<body>
	<header>
		<h1>Here's your Omikuji!</h1>
	</header>
	<main class="omikuji">
		<p>In <c:out value="${number}"></c:out> years, you will live in <c:out value="${city}"></c:out> with <c:out value="${person}"></c:out> as your roommate, <c:out value="${hobby}"></c:out> as a living. The next time you see a <c:out value="${living}"></c:out>, you will have good luck. Also, <c:out value="${nice}"></c:out>.</p>
	</main>
	<a href="/omikuji" class="btn btn-primary mt-2 float-end">Go Back</a>
</body>
</html>