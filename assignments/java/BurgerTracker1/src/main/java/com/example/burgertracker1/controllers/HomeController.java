package com.example.burgertracker1.controllers;

import java.util.List;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;

import com.example.burgertracker1.models.Burger;
import com.example.burgertracker1.services.BurgerServ;

@Controller
public class HomeController {
	
@Autowired
private BurgerServ burgerServ;
	
	@GetMapping("/")
	public String index(Model model, @ModelAttribute("burger") Burger burger) {
		List<Burger> burgers = burgerServ.allBurgers();
		
		model.addAttribute("allBurgers", burgers);
		
		return "index.jsp";
	}
	@PostMapping("/createBurger")
	public String createBurger(@Valid @ModelAttribute("burgerForm") Burger burger, BindingResult result, Model model) {
		
        if (result.hasErrors()) {
	        	List<Burger> burgers = burgerServ.allBurgers();
	    		
	    		model.addAttribute("allBurgers", burgers);
        		
            return "index.jsp";
        } else {
            burgerServ.createBurger(burger);
            return "redirect:/";
        }
	}
}
