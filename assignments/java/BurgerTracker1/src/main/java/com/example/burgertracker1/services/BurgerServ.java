package com.example.burgertracker1.services;

import java.util.List;

import org.springframework.stereotype.Service;

import com.example.burgertracker1.models.Burger;
import com.example.burgertracker1.repositories.BurgerRepo;

@Service
public class BurgerServ {
	private final BurgerRepo burgerRepo;
	
	public BurgerServ(BurgerRepo burgerRepo) {
		this.burgerRepo = burgerRepo;
	}
	
    // ==========================
    //         METHODS
    // ==========================
	
	// lists all burgers
	public List<Burger> allBurgers() {
		return burgerRepo.findAll();
	}
	
    // creates a Friend
    public Burger createBurger(Burger b) {
        return burgerRepo.save(b);
    }
}
