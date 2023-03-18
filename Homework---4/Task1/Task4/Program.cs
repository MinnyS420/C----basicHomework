/*
 Make a method called AgeCalculator
The method will have one input parameter, your birthday date
The method should return your age
Show the age of a user after he inputs a date
Note: take into consideration if the birthday is today, after or before today
 */

Console.Write("Enter your birthday (in yyyy/mm/dd format): ");
DateTime birthday = DateTime.Parse(Console.ReadLine());

int age = AgeCalculator(birthday);

Console.WriteLine("Your age is {0}", age);


static int AgeCalculator(DateTime birthday)
{
    DateTime today = DateTime.Today;

    int age = today.Year - birthday.Year;

    if (birthday > today.AddYears(-age))
    {
        age--;
    }

    return age;
}