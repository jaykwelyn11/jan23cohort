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
<title></title>
</head>
<body>
	<header>
		
	</header>
	<nav>
	<h1>Welcome, ${theUser.username}!</h1>
	<h2>This is your dashboard. Nothing to see here yet.</h2>
			<c:if test="${ user_id != null }">
				<a href="/logout"><button class="navbutton">Logout</button></a>
			</c:if>
	</nav>
	<main>
	</main>
</body>
<footer>

</footer>				
</html>