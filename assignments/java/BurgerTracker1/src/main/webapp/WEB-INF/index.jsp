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
<title>Burger Tracker</title>
</head>
<body>
	<header>
		<h1>Burger Tracker</h1>
	</header>
	<main>
		<table style="width:80%">
  			<thead>
  			<tr>
			    <th>Burger Name</th>
			    <th>Restaurant Name</th>
			    <th>Rating (out of 5)</th>
		  	</tr>
		  	</thead>
		  	<tbody>
        	<c:forEach items='${ allBurgers }' var='burgerObj'>
	          <tr>
	            <td>${burgerObj.burgerName}</td>
	            <td>${burgerObj.restaurantName}</td>
	            <td>${burgerObj.rating}</td>
	          </tr>
        	</c:forEach>
      </tbody>
		</table>
		
		<h1>Add a Burger:</h1>
		<container class="form">
			<form:form action="/createBurger" method="post" modelAttribute="burgerForm" class="form-control">
		<div class="form=group">
			<label for="burgerName">Burger Name</label>
			<input type="text" name="burgerName" class="form-control">
			<form:errors path="burgerName" />
		</div>
		<div class="form=group">
			<label for="restaurantName">Restaurant Name</label>
			<input type="text" name="restaurantName" class="form-control">
			<form:errors path="restaurantName" />
		</div>
		<div class="form=group">
			<label for="rating">Rating</label>
			<select name="rating" id="rating" class="form-control">
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
			<input type="text" name="notes" class="form-control">
			<form:errors path="notes" />
		</div>
		<button>Submit</button>
	</form:form>
		</container>
	</main>
</body>
</html>