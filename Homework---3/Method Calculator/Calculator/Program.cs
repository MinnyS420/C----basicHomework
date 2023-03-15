Console.WriteLine("Welcome to the calculator!");

while (true)
{
    Console.Write("Enter the first number: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Enter the second number: ");
    double num2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Please choose an operation:");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine($"The result is: {Add(num1, num2)}");
            break;
        case 2:
            Console.WriteLine($"The result is: {Subtract(num1, num2)}");
            break;
        case 3:
            Console.WriteLine($"The result is: {Multiply(num1, num2)}");
            break;
        case 4:
            Console.WriteLine($"The result is: {Divide(num1, num2)}");
            break;
        default:
            Console.WriteLine("Invalid choice, please try again.");
            break;
    }

    Console.WriteLine("Press any key to continue, or Q to quit.");
    if (Console.ReadLine().ToUpper() == "Q")
    {
        break;
    }
}

Console.WriteLine("Thank you for using the calculator!");


static double Add(double a, double b)
{
    return a + b;
}

static double Subtract(double a, double b)
{
    return a - b;
}

static double Multiply(double a, double b)
{
    return a * b;
}

static double Divide(double a, double b)
{
    if (b == 0)
    {
        Console.WriteLine("Error: Cannot divide by zero.");
        return 0;
    }
    else
    {
        return a / b;
    }
}

