/*
Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the 
values of the variables so that the first variable has the second value and the second variable the 
first value. Please find example below:

Test Data:
Input the First Number: 5
Input the Second Number: 8
Expected Output:
After Swapping:
First Number: 8
Second Number: 5
 */



Console.Write("Input the First Number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Input the Second Number: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Before Swapping:");
Console.WriteLine("First Number: " + firstNumber);
Console.WriteLine("Second Number: " + secondNumber);

// Swapping the values of the variables using a temporary variable
int temp = firstNumber;
firstNumber = secondNumber;
secondNumber = temp;

Console.WriteLine("After Swapping:");
Console.WriteLine("First Number: " + firstNumber);
Console.WriteLine("Second Number: " + secondNumber);

Console.ReadLine(); // To prevent the console window from closing immediately