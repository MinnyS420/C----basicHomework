int Sum(int num1, int num2)
{
    return num1 + num2;
}
int Subtract(int num1, int num2)
{
    return num1 - num2;
}
int Multiply(int num1, int num2)
{
    return num1 * num2;
}
int Divide(int num1, int num2)
{
    return num1 / num2;
}

int Calculator(char operations, int num1, int num2)
{
    int result = 0;
    if (operations == '+')
    {
        result = Sum(num1, num2);
    }
    else if (operations == '-')
    {
        result = Subtract(num1, num2);
    }
    else if (operations == '*')
    {
        result = Multiply(num1, num2);
    }
    else if (operations == '/'){
        result = Divide(num1, num2);
    }
    return result;
}
Console.WriteLine("Enter operations");
char op = char.Parse(Console.ReadLine());
Console.WriteLine("Enter num 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter num 2");
int number2 = Convert.ToInt32(Console.ReadLine());


int Res = Calculator(op, number1, number2);
Console.WriteLine(Res);

