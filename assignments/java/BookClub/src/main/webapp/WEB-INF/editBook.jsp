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
		<h1>Change your Entry</h1>
	<nav>
			<c:if test="${ user_id != null }">
				<a href="/books">Back to the shelves</a>
			</c:if>
	</nav>
	</header>
    <main>
    	<form:form action="/books/${theBook.id}/update" method="post" modelAttribute="theBook">
    		<input type="hidden" name="_method" value="put"/>
    		
    		<section>
    			<form:label path="title">Title</form:label>
    			<input path="title" type="text" name="title" value="${theBook.title}" />
    			<form:errors path="title" class="text-danger" />
    		</section>
    		<section>
    			<form:label path="authorName">Author</form:label>
    			<input type="text" path="authorName" value="${theBook.authorName}" />
    			<form:errors path="authorName" class="text-danger" />
    		</section>
    		<section>
    			<form:label path="thoughts">My thoughts</form:label>
    			<input type="text" path="thoughts" value="${theBook.thoughts}"/> 
    			<form:errors path="thoughts" class="text-danger" />
    		</section>
    		<form:input type="hidden" path="owner" value="${user_id }"/>
    		<button>Submit</button>
    	</form:form>
    </main>
    <footer>
    
    </footer>
</body>
</html>