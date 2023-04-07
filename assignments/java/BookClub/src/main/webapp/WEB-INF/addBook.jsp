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
<title>Book Share</title>
</head>
<body>
	<header>
		<h1>Add a Book to Your Shelf!</h1>
	<nav>
			<c:if test="${ user_id != null }">
				<a href="/books">Back to the shelves</a>
			</c:if>
	</nav>
	</header>
    <main>
    	<form:form action="/createBook" method="post" modelAttribute="addBookForm">
    		<section>
    			<label for="title">Title</label>
    			<input type="text" name="title" id="" />
    			<form:errors path="title" class="text-danger" />
    		</section>
    		<section>
    			<label for="authorName">Author</label>
    			<input type="text" name="authorName" id="" />
    			<form:errors path="authorName" class="text-danger" />
    		</section>
    		<section>
    			<label for="thoughts">My thoughts</label>
    			<input type="text" name="thoughts" id="" />
    			<form:errors path="thoughts" class="text-danger" />
    		</section>
    		<section>
    			<input type="hidden" name="owner" value="${ user_id }" />
    		</section>
    		<button>Submit</button>
    	</form:form>
    </main>
    <footer>
    
    </footer>
</body>
</html>