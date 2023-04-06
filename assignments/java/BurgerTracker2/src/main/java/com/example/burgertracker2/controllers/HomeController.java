package com.example.burgertracker2.controllers;

import java.util.List;

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

import com.example.burgertracker2.models.Burger;
import com.example.burgertracker2.services.BurgerServ;

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
	
	@GetMapping("/burger/{id}/edit")
	public String editBurger(@PathVariable("id") Long id, @ModelAttribute("burgerForm") Burger burger, Model model) {
		
		model.addAttribute("burger", burgerServ.getOne(id));
		model.addAttribute("allBurgers", burgerServ.getAll());
		return "editBurger.jsp";
	}
	
	@PutMapping("/burger/{id}/update")
	public String updateBurger(@PathVariable("id") Long id, @Valid @ModelAttribute("burgerForm") Burger burger, BindingResult result, Model model) {
		
		if(result.hasErrors()) {
			model.addAttribute("burger", burgerServ.getOne(id));
//			model.addAttribute("allBurger", burgerServ.getAll());
			return "editBurger.jsp";
		} else {
			burgerServ.updateOne(burger);
			return "redirect:/";
		}
	}
}
