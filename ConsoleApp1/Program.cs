using System;
using System.Collections.Generic;
using System.Reflection;
using System.Transactions;


class BankAccount
{
    // Properties of the class to go right here

    public int AccountId{ get ; private set; }
    public string CustomerName{ get; private set; }
    public decimal Balance{ get; private set; }
    public List<string> Transactions { get; private set; }

    // Private 

    private string int _accountCounter = 1000;


    // initializing the constructor 

    public BankAccount (string customerName, decimal initalBalance)
    {
        if (initalBalance < 0)
    {
        throw new ArgumentException("Initial Balance is invalid or can not be negative");

    }

    AccountId = ++_accountCounter;
    CustomerName = customerName;
    Balance = initalBalance;
    Transactions = new List<string> ($ "Account created with initial balance: {Balance:C}");

    }

    // implenting a method for any cases of a deposit 

    public void Deposit (Decimal amount){
        if (amount < 0){
            throw new ArgumentException("Invalid deposit amount");
        }

        Balance += amount;
        Transactions.Add($ "Deposited: {amount:C}, New Balance: {Balance:C}");
    }


    // implementing a withdraw method for any cases that the customer wants to withdraw money from bank account

    public bool Withdraw (decimal amount){
        if (amount < 0){
            throw new ArgumentException("Invalid Withdraw amount");
        }

        if (amount > Balance){
            Transactions.Add ($ "Withdrawal of {amount:C} failed. Insufficient funds.");
            return false;
        }

        Balance -= amount;
        Transactions.Add($ "Withdrew: {amount:C}, New Balance: {Balance:C}");
        return true;
    }


    // This will be the section for Account Summary, it should print out the info for the customer

    public void PrintAccountSummary(){
        Console.WriteLine($"Account ID: {AccountId}, Customer: {CustomerName}, Balance: {Balance:C}");


        Console.WriteLine("Transaction History:");

foreach (var transaction in Transactions)

         {
               Console.WriteLine(transaction);
        }
    }
}
    














}