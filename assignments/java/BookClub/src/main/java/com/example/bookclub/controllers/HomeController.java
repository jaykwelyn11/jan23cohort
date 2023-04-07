package com.example.bookclub.controllers;

import javax.servlet.http.HttpSession;
import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;

import com.example.bookclub.models.Book;
import com.example.bookclub.models.LoginUser;
import com.example.bookclub.models.User;
import com.example.bookclub.services.BookServ;
import com.example.bookclub.services.UserServ;

@Controller
public class HomeController {

	@Autowired
	private UserServ userServ;
	
	@Autowired
	private BookServ bookServ;
	
	
    // ==========================
    //      MAIN FUNCTIONS
    // ==========================
	@GetMapping("/")
	public String logReg(HttpSession session, Model model) {
		if(session.getAttribute("user_id") != null) {
			return "redirect:/books";
		} else {
	        // Bind empty User and LoginUser objects to the JSP
	        // to capture the form input
	        model.addAttribute("newUser", new User());
	        model.addAttribute("newLogin", new LoginUser());
	        
		return "logReg.jsp";
		}
	}
		
	// Create User Process
	@PostMapping("/register")
	public String registerUser(@Valid @ModelAttribute("newUser") User newUser, BindingResult result, Model model, HttpSession session) {
		   	userServ.register(newUser, result);
		       if(result.hasErrors()) {
		           model.addAttribute("newLogin", new LoginUser());
		           return "logReg.jsp";
		       }
		       session.setAttribute("user_id", newUser.getId());
		       return "redirect:/books";
		   }
		   
	// Login User Process
	@PostMapping("/login")
	public String loginUser(@Valid @ModelAttribute("newLogin") LoginUser newLogin, BindingResult result, Model model, HttpSession session) {
		       User user = userServ.login(newLogin, result);
		       if(result.hasErrors()) {
		           model.addAttribute("newUser", new User());
		           return "logReg.jsp";
		       }
		       session.setAttribute("user_id", user.getId());
		       return "redirect:/books";
		   }
		   
	// Logout User
	@GetMapping("/logout")
	public String logout(HttpSession session) {
				session.invalidate();
				return "redirect:/";
			}
			
	@GetMapping("/books")
	public String books(HttpSession session, @ModelAttribute("book") Book book, Model model) {
		if(session.getAttribute("user_id") == null) {
			return "redirect:/";
		} else {
		model.addAttribute("theUser", userServ.getUser((Long)session.getAttribute("user_id")));
		model.addAttribute("allBooks", bookServ.getAll());
		return "books.jsp";
		}
	}
	
	@GetMapping("/books/new")
	public String addBook(HttpSession session, @ModelAttribute("addBookForm") Book book, Model model) {
		if(session.getAttribute("user_id") == null) {
			return "redirect:/logReg";
		} else {
		return "addBook.jsp";
		}
	}
	
	@PostMapping("/createBook")
	public String createBook(@Valid @ModelAttribute("addBookForm") Book book, BindingResult result, Model model) {
		if(result.hasErrors()) {
			return "addBook.jsp";
		} else {
			bookServ.createOne(book);
			return "redirect:/books";
		}
	}
	
	@GetMapping("books/{id}/view")
	public String viewBook(HttpSession session, @PathVariable("id") Long id, @ModelAttribute("book") Book book, Model model) {
		if(session.getAttribute("user_id") == null) {
			return "redirect:/logReg";
		} else {
		model.addAttribute("theBook", bookServ.getOne(id));
		return "viewBook.jsp";
		}
	}
	
	@GetMapping("books/{id}/edit")
	public String editBook(HttpSession session, @PathVariable("id") Long id, @ModelAttribute("theBook") Book book, Model model) {
		if(session.getAttribute("user_id") == null) {
			return "redirect:/logReg";
		} else {
		model.addAttribute("theBook", bookServ.getOne(id));
		return "editBook.jsp";
		}
	}
	@PutMapping("books/{id}/update")
	public String updateBook(@PathVariable("id") Long id, @Valid @ModelAttribute("oneBook") Book oneBook, BindingResult result, Model model) {
		if(result.hasErrors()) {
			model.addAttribute("theBook", bookServ.getOne(id));
			return "editBook.jsp";
		} else {
			bookServ.updateOne(oneBook);
			return "redirect:/books";
		}
	}
	
	@GetMapping("books/{id}/delete")
	public String viewBook(@PathVariable("id") Long id) {
		bookServ.deleteOne(id);
		return "redirect:/books";
	}
}
