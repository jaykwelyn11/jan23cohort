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
<title>Edit Burger</title>
<a href="/">Go back</a>
</head>
<body>
<main>
<h1>Edit Burger</h1>
	<container class="form">
			<form:form aciton="/burger/${burger.id}/update" method="post" modelAttribute="burgerForm" class="form-control">
			<input type="hidden" name="_method" value="put">
				<div class="form=group">
					<label for="burgerName">Burger Name</label>
					<input type="text" name="burgerName" value="${burger.burgerName}" class="form-control">
					<form:errors path="burgerName" />
				</div>
				<div class="form=group">
					<label for="restaurantName">Restaurant Name</label>
					<input type="text" name="restaurantName" value="${burger.restaurantName}" class="form-control">
					<form:errors path="restaurantName" />
				</div>
				<div class="form=group">
					<label for="rating">Rating</label>
					<select name="rating" id="rating" value="${burger.rating}" class="form-control">
						<option value="1">1</option>
						<option value="2">2</option>
						<option value="3">3</option>
						<option value="4">4</option>
						<option value="5">5</option>
					</select>
					<form:errors path="rating" />
				</div>
				<div class="form=group">
					<label for="notes">Notes</label>
					<input type="text" name="notes" value="${burger.notes}"class="form-control">
					<form:errors path="notes" />
				</div>
				<button>Submit</button>
			</form:form>
</main>
</body>
</html>