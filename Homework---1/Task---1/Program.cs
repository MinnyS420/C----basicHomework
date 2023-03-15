Console.WriteLine("Enter the First number:");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the Second number:");
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the Operation (+, -, *, /):");
string operation = Console.ReadLine();

double result = 0;

if (operation == "+")
{
    result = num1 + num2;
}
else if (operation == "-")
{
    result = num1 - num2;
}
else if (operation == "*")
{
    result = num1 * num2;
}
else if (operation == "/")
{
    result = num1 / num2;
}
else
{
    Console.WriteLine("Invalid operation");
}

Console.WriteLine("The result is: " + result);