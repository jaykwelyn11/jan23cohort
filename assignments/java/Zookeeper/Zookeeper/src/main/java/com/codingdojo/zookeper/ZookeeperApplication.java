package com.codingdojo.zookeper;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class ZookeeperApplication {

	public static void main(String[] args) {
		
		Gorilla g = new Gorilla();
		Bat b = new Bat();
		
		System.out.println("==== Track Gorilla Energy Below ====");
		g.displayEnergy();
		g.throwSomething();
		g.throwSomething();
		g.throwSomething();
		g.eatBananas();
		g.eatBananas();
		g.climb();
		g.displayEnergy();
		
		System.out.println("==== Track Bat Energy Below ====");
		b.displayEnergy();
		b.attackTown();
		b.attackTown();
		b.attackTown();
		b.fly();
		b.fly();
		b.eatHuman();
		b.eatHuman();
		b.displayEnergy();
		
		
		SpringApplication.run(ZookeeperApplication.class, args);
	}

}
