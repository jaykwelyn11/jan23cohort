package com.example.omikujiform.controllers;

import javax.servlet.http.HttpSession;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class HomeController {

	@GetMapping("/omikuji")
	public String Index() {
		return "index.jsp";
	}
	
	@PostMapping("/send")
	public String send(HttpSession session, @RequestParam(value = "number") int number, @RequestParam(value = "city") String city, @RequestParam(value = "person") String person, @RequestParam(value = "hobby") String hobby, @RequestParam(value = "living") String living, @RequestParam(value = "nice") String nice) {
		session.setAttribute("number", number);
		session.setAttribute("city", city);
		session.setAttribute("person", person);
		session.setAttribute("hobby", hobby);
		session.setAttribute("living", living);
		session.setAttribute("nice", nice);
		
		return "redirect:omikuji/show";
	}
	
	@GetMapping("/omikuji/show") 
	public String omikuji() {
		return "omikuji.jsp";
	}
}
