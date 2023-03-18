//Create a function that takes a number as input. This method should return the sum of the digits in the number.

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

int digitSum = SumDigits(number);

Console.WriteLine("The sum of the digits in {0} is {1}", number, digitSum);


static int SumDigits(int number)
{
    int sum = 0;

    while (number != 0)
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }

    return sum;
}