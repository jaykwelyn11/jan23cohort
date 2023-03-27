package com.codingdojo.zookeper;

public class Bat extends Mammal {

	public Bat() {
		this.energyLevel = 300;
	}
	
	public void fly() {
		this.energyLevel -= 50;
		System.out.printf("Sound of bat taking off. Bat is flying around town and his energy has decreased by 50. New energy level is: \n", + this.energyLevel);  
	}
	
	public void eatHuman() {
		this.energyLevel += 25;
		System.out.printf("so- well, never mind, just increase its energy by 25.\n New energy level is:", + this.energyLevel);
	}
	
	public void attackTown() {
		this.energyLevel -= 100;
		System.out.printf("Sound of a town on fire! The bat is attacking! It's energy has decreased by 100. \n New energy level is:" + this.energyLevel); 
	}
}
