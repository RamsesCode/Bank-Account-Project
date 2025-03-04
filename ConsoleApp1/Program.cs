using System;
using System.Collections.Generic;
using System.Reflection;


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












}