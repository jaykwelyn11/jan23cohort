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
		<h1>Welcome, ${theUser.name}</h1>
	</header>
	<nav>
			<c:if test="${ user_id != null }">
				<a href="/books">Home</a>
				<a href="/books/new">+ Add a book to my shelf!</a>
				<a href="/logout">Logout</a>
			</c:if>
	</nav>
	<main>
	<h3>Books from everyone's shelves:</h3>
		<table style="width:80%">
  			<thead>
  			<tr>
			    <th>ID</th>
			    <th>Title</th>
			    <th>Author Name</th>
			    <th>Posted By</th>
		  	</tr>
		  	</thead>
		  	<tbody>
        	<c:forEach items='${ allBooks }' var='bookObj'>
	          <tr>
	            <td>${bookObj.id}</td>
	            <td><a href="books/${bookObj.id}/view">${bookObj.title}</a></td>
	            <td>${bookObj.authorName}</td>
	            <td>${bookObj.owner.name}</td>
	          </tr>
        	</c:forEach>
      </tbody>
		</table>
	</main>
</body>
</html>