package com.codingdojo.zookeper;

public class Gorilla extends Mammal{
	
	public Gorilla() {

	}
	
	public void throwSomething() {
		this.energyLevel -= 5;
		System.out.println("The Gorilla just threw a banana! Decreased energy by 5.\n New energy level:" + this.energyLevel);
	}
	
	public void eatBananas() {
		this.energyLevel += 10;
		System.out.println("The Gorilla just ate a banana! Increased energy by 10.\n New energy level:" + this.energyLevel);
	}
	
	public void climb() {
		this.energyLevel -= 10;
		System.out.println("The Gorilla just climbed a tree. \n New energy level:" + this.energyLevel);
	}
}
