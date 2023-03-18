//Take a sentence as input and print its words.

Console.Write("Enter a sentence: ");
string input = Console.ReadLine();

string[] words = input.Split(' ');

Console.WriteLine("The words in the input sentence are:");

foreach (string word in words)
{
    Console.WriteLine(word);
}

