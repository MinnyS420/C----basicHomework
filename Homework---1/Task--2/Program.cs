Console.WriteLine("Enter the First number:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the Second number:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the Third number:");
int num3 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the Fourth number:");
int num4 = int.Parse(Console.ReadLine());

int average = (num1 + num2 + num3 + num4) / 4;
Console.WriteLine("The average of " + num1 + ", " + num2 + ", " + num3 + " and " + num4 + " is: " + average);