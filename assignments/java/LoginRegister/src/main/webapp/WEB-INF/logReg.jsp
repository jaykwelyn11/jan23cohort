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
<header>
	<h1>Welcome!</h1>
	<h3>Join our growing community</h3>
</header>
<body>
	<main>
	<div class="row mt-5">
		<div class="col-md">
			<h1>Register</h1>
		    	<form:form action="/register" method="POST" modelAttribute="newUser">
						<section>
							<form:label path="username">Username:</form:label>
							<form:input type="text" path="username" class= "form-control" />
							<form:errors path="username" class="text-danger" />
						</section>
						<section>
							<form:label path="email">Email:</form:label>
							<form:input type="email" class= "form-control" path="email" />
							<form:errors path="email" class="text-danger" />
						</section>
						<section>
							<form:label path="password">Password:</form:label>
							<form:input type="password" class= "form-control" path="password" />
							<form:errors path="password" class="text-danger" />
						</section>
						<section>
							<form:label path="confirmPassword">Confirm PW:</form:label>
							<form:input type="password" class= "form-control" path="confirmPassword" />
							<form:errors path="confirmPassword" class="text-danger" />
						</section>
						<button class="new">Submit</button>
					</form:form>
			</div>
			<div class="col-md">
				<h1>Log in</h1>
					<form:form action="/login" method="POST" modelAttribute="newLogin">
						<section>
							<form:label path="email">Email</form:label>
							<form:input type="email" class= "form-control" path="email" />
							<form:errors path="email" class="text-danger" />
						</section>
						<section>
							<form:label path="password">Password</form:label>
							<form:input type="password" class= "form-control" path="password" />
							<form:errors path="password" class="text-danger" />
						</section>
						<button class="new">Submit</button>
					</form:form>
			</div>
		</div>
    </main>
</body>
</html>