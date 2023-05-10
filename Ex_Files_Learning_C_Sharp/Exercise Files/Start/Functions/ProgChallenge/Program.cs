using System.Text;

class Program{
    static (bool, int) IsPalindrome(string inputStr){
        // Create location for stripping out punctuation
        var sb = new StringBuilder();
        // Get input length
        int strLength = inputStr.Length;

        // Strip punctuation from input:
        foreach (char c in inputStr){
            if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c)){
                sb.Append(c);
            }
        }
        
        // Convert StringBuilder to string, change all to lowercase.
        string cleanedStr = sb.ToString().ToLower();

        // Make a reverse copy of the string.
        string reverseStr = new string(cleanedStr.Reverse().ToArray());

        // Check if the two are equal.
        bool palindromeCheck = false;
        if (cleanedStr == reverseStr){
            palindromeCheck = true;
        }

        // Finally return the truth and string length.
        return (palindromeCheck, strLength);
    }
    static void Main(string[] args){
        string? input = "";

        do {
        Console.WriteLine("Let's begin:");

        // Take input from user
        input = Console.ReadLine();
        // Check it's non-null to keep computer happy.
        if (input == null){
            Console.WriteLine("I didn't quite understand that...");
            input = "";
        } else if (input.ToLower() == "exit"){continue;}

        (bool res1, int res2) = IsPalindrome(input);
        Console.WriteLine($"Palindrome: {res1}, Length: {res2}");

        } while (input != "exit");
        Console.WriteLine("Exiting...");
    }
}