using System;


public class cardHolder
{
    //declaring variables
    string cardNum;
    int pin;
    string firstName;
    string lastName;
    double balance;
    

    //constructor - is called when an instance of a class is created (used to set initial values)
    public cardHolder(string cardnum, int pin, string firstName, string lastName, double balance)
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
        void printOptions()
        {
            Console.WriteLine("Please choose from the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");

        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much would you like to deposit: ");
            double deposit = double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit);
            Console.WriteLine("Thank you for depositing, Your new balance is: " + currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("WITHDRAWAL");
            Console.WriteLine("Amount: ");
            double withdrawal = double.Parse(Console.ReadLine());
            if(currentUser.getBalance() > withdrawal)
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("Funds successfully withdrawn.");
            }
            else
            {
                Console.WriteLine("Insufficient funds");

            }
            
        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Account Balance: " + currentUser.getBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("123123123123",1234,"Alvin","Grey",123.33));
        cardHolders.Add(new cardHolder("417722191199",9930,"Richard","Ambrose",332.21));
        cardHolders.Add(new cardHolder("882991777231",0091,"Galvin","Scott",393.98));
        cardHolders.Add(new cardHolder("990192777172",0019,"Dawn","Rivero",13.33));
        cardHolders.Add(new cardHolder("883928776182",3132,"Goldwin","Meyer",120.23));
        cardHolders.Add(new cardHolder("918287273782",0992,"Rajitha","Malik",1230.33));



    }

}