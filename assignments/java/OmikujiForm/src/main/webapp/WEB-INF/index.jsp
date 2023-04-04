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
		<h1>Send an Omikuji!</h1>
	</header>
	<main>
		<form action="/send" method="post">
				<section>
					<h2>Pick any number from 5 to 25</h2>
					<label for="number"></label>
					<input type="number" name="number">
					<form:errors path="name" />
				</section>
				<section>
					<h2>Enter the name of any city.</h2>
					<label for="city"></label>
					<input type="text" name="city">
					<form:errors path="city" />
				</section>
				<section>
					<h2>Enter the name of a any real person</h2>
					<label for="person"></label>
					<input type="text" name="person">
					<form:errors path="person" />
				</section>
				<section>
					<h2>Enter professional endeavor or hobby:</h2>
					<label for="hobby"></label>
					<input type="text" name="hobby">
					<form:errors path="hobby" />
				</section>
				<section>
					<h2>Enter any type of living thing.</h2>
					<label for="living"></label>
					<input type="text" name="living">
					<form:errors path="living" />
				</section>
				<section>
					<h2>Say something nice to someone:</h2>
					<label for="nice"></label>
					<textarea id="nice" name="nice" rows="4" cols="50"></textarea>
					<form:errors path="nice" />
				</section>
				<h3>Send and show a friend</h3>
				<button>Send</button>
			</form>
	</main>
</body>
</html>