using System;


public class CardHolder
{
    //declaring variables
    string cardNum;
    int pin;
    string firstName;
    string lastName;
    double balance;
    

    //constructor - is called when an instance of a class is created (used to set initial values)
    public CardHolder(string cardnum, int pin, string firstName, string lastName)
    {
        this.cardNum = cardnum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    //getters
    public string getCardNum()
    {
        return cardNum;
    }

    public int getPin()
    {
        return pin;
    }
    public string getFirstName()
    {
        return firstName;
    }
    public string getLastName()
    {
        return lastName;
    }
    public double getBalance()
    {
        return balance;
    }


    //setters
    public void setNum(string newCardNum)
    {
        cardNum = newCardNum;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }
    public void setFirstName(string newFirstNAme)
    {
        firstName = newFirstNAme;
    }
    public void setLastName(string newLastName)
    {
        lastName = newLastName;
    }
    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(string[] args)
    {

    }

}