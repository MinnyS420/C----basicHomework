
class Customer
{
    private string name;
    private int pin;
    private double balance;

    public Customer(string name, int pin, double balance)
    {
        this.name = name;
        this.pin = pin;
        this.balance = balance;
    }

    public string GetName()
    {
        return name;
    }

    public bool CheckPin(int pin)
    {
        return this.pin == pin;
    }

    public double GetBalance()
    {
        return balance;
    }

    public void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine("You withdrew {0:C}. You have {1:C} left on your account.", amount, balance);
        }
        else
        {
            Console.WriteLine("You do not have enough money on your account.");
        }
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("You deposited {0:C}. Your new balance is {1:C}.", amount, balance);
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Customer> customers = new List<Customer>();
        customers.Add(new Customer("Bob Bobsky", 4325, 650.0));
        customers.Add(new Customer("Jane Janesky", 1234, 1000.0));

        Console.WriteLine("Welcome to the ATM app");

        while (true)
        {
            Console.Write("Please enter your card number: ");
            string cardNumber = Console.ReadLine();

            Console.Write("Enter your PIN: ");
            int pin = int.Parse(Console.ReadLine());

            Customer customer = null;
            foreach (Customer c in customers)
            {
                if (c.GetName().Contains(cardNumber) && c.CheckPin(pin))
                {
                    customer = c;
                    break;
                }
            }

            if (customer == null)
            {
                Console.WriteLine("Invalid card number or PIN. Please try again.");
                continue;
            }

            Console.WriteLine("Welcome {0}!", customer.GetName());

            while (true)
            {
                Console.WriteLine("What would you like to do:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Cash Withdrawal");
                Console.WriteLine("3. Cash Deposit");
                Console.Write("> ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your balance is {0:C}.", customer.GetBalance());
                        break;
                    case 2:
                        Console.Write("How much money would you like to withdraw? ");
                        double amount = double.Parse(Console.ReadLine());
                        customer.Withdraw(amount);
                        break;
                    case 3:
                        Console.Write("How much money would you like to deposit? ");
                        amount = double.Parse(Console.ReadLine());
                        customer.Deposit(amount);
                        break;
                }

                Console.WriteLine("Do you want to do another transaction? (Y/N)");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "n")
                {
                    break;
                }
            }

            Console.WriteLine("Thank you for using the ATM app.");
        }
    }
}
