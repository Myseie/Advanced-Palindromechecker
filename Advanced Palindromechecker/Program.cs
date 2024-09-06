Console.Write("Skriv en mening : ");

string input = Console.ReadLine();

string cleanedInput = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();

char[] normalString = cleanedInput.ToCharArray();


Array.Reverse(normalString);



string reversed = new string(normalString);

if(cleanedInput == reversed)
{
    Console.WriteLine("Palindrom");
}
else
{
    Console.WriteLine("Inte en palindrom");
}
