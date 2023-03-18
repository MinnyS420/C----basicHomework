//Take one string from the input and print its last 5 characters.

Console.Write("Enter a string: ");
string input = Console.ReadLine();

if (input.Length >= 5)
{
    string lastFiveChars = input.Substring(input.Length - 5);
    Console.WriteLine("The last 5 characters of the input string are: " + lastFiveChars);
}
else
{
    Console.WriteLine("The input string is too short to have 5 characters!");
}
