package com.example.burgertracker2.services;

import java.util.List;

import org.springframework.stereotype.Service;

import com.example.burgertracker2.models.Burger;
import com.example.burgertracker2.repositories.BurgerRepo;

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
    
    public List<Burger> getAll() {
    	return burgerRepo.findAll();
    }
    
    public Burger getOne(Long id) {
    	return burgerRepo.findById(id).orElse(null);
    }
    
    public Burger updateOne(Burger editBurger) {
    	return burgerRepo.save(editBurger);
    }
}
