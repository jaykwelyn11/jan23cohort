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
<title>Read Share</title>
</head>
<body>
	<header>
		<h1>${theBook.title}</h1>
	<nav>
			<c:if test="${ user_id != null }">
				<a href="/books">Back to the shelves</a>
			</c:if>
	</nav>
	</header>
    <main>
    	<h1>${theBook.owner.name} read ${ theBook.title} by ${theBook.authorName}.</h1>
    	<h3>Here are ${theBook.owner.name}'s thoughts:</h3>
    	<p>${theBook.thoughts}</p>
    	<c:if test="${ user_id == theBook.owner.id }">

    		<a href="/books/${theBook.id}/edit">Edit</a>
    		<a href="/books/${theBook.id}/delete">Delete</a>
    	</c:if>
    </main>
    <footer>
    
    </footer>
</body>
</html>