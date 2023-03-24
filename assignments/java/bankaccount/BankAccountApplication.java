package com.example.bankaccount;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class BankAccountApplication {

	public static void main(String[] args) {
		
		BankAccount account1 = new BankAccount(200,100);
		BankAccount account2 = new BankAccount(100,400);
		BankAccount account3 = new BankAccount(50,500);

		System.out.printf("Number of bank accounts: %d\n", BankAccount.numberOfAccounts());
		
		account1.Deposit("checking", 200);
		account2.Deposit("savings", 200);
		account3.Deposit("checking", 200);

		account1.Withdrawal("savings", 20);
		account1.Withdrawal("checking", 30);
		account1.Withdrawal("savings", 100);
	
		
		
		SpringApplication.run(BankAccountApplication.class, args);
	}

}
