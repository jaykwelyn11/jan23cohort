package com.example.bankaccount;

public class BankAccount {
	private double checkingBalance;
	private double savingsBalance;
	private static int numberOfAccountsCreated = 0;
	private static double totalAmountOfMoney = 0;
	
	
	// === Constructor === //
	public BankAccount(double checkingBalance, double savingsBalance) {
		this.checkingBalance = checkingBalance;
		this.savingsBalance = savingsBalance;
		BankAccount.numberOfAccountsCreated++;
	}


	// === Methods === //
	
	public static int numberOfAccounts() {
		return numberOfAccountsCreated;
	}
	
	public void Deposit(String type, double amount){
        switch(type){
            case "checking":
                this.checkingBalance += amount;
                System.out.printf("$%.2f successfully added to total of $%s Checking Account.\n", amount, this.checkingBalance);
                // add value into total amount
                BankAccount.totalAmountOfMoney += amount; 
                break;
            case "savings":
                this.savingsBalance += amount;
                System.out.printf("$%.2f successfully added to total of $%s Savings Account.\n", amount, this.savingsBalance);
                // add value into total amount
                BankAccount.totalAmountOfMoney += amount;   
                break;
            default:
                System.out.printf("That type of account does not exist in account %s.%nPlease deposit in \"checking\" or \"savings\" only.%n");
        }
    }
	
	public void Withdrawal(String type, double amount){
        switch(type){
            case "checking":
                // do not allow withdrawal from larger than available
                if(this.checkingBalance >= amount){  
                    this.checkingBalance -= amount;
                    System.out.printf("$%.2f successfully withdrawn from %s Checking Account.\n", amount, this.checkingBalance);
                    // remove value from total amount
                    BankAccount.totalAmountOfMoney -= amount;
                }
                else{
                    System.out.printf("There are not enough funds in %s Checking Account to remove $%.2f.%n\t", amount, this.checkingBalance);
                }
                break;
            case "savings":
                // do not allow withdrawal from larger than available
                if(this.savingsBalance >= amount){
                    this.savingsBalance -= amount;
                    System.out.printf("$%.2f successfully withdrawn from %s Savings Account.%n\t", amount, this.savingsBalance);
                    // remove value from total amount
                    BankAccount.totalAmountOfMoney -= amount;
                }
                else{
                    System.out.printf("There are not enough funds in your Savings Account to remove $%.2f.%n\t",  this.savingsBalance, amount);
                } 
                break;
            default:
                System.out.printf("That type of account does not exist in account %s.%nPlease deposit in \"checking\" or \"savings\" only.");
        }
    }
	
	public void printTotals(){
        System.out.printf("Account %s %n\tChecking: $%.2f %n\tSavings: $%.2f\n",  this.checkingBalance, this.savingsBalance);
    }

	
	// === Getters & Setters === //

	public double getCheckingBalance() {
		return checkingBalance;
	}



	public double getSavingsBalance() {
		return savingsBalance;
	}


	
}
