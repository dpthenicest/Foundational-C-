// See https://aka.ms/new-console-template for more information
Console.WriteLine("Methods that return values!");

// void PrintMessage(string message)
// { }

double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.09, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 }; // fractional discounts

Console.WriteLine($"Total: ${total}");

for (int i = 0; i < items.Length; i++)
{
  total += GetDiscountPrice(i);
}
Console.WriteLine($"Total: ${total}");

if (TotalMeetsMinimum())
{
  total -= 5.00;
}

/* // OR you can use tenary expression
total -= TotalMeetsMinimum() ? 5.00 : 0.00;
*/

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountPrice(int itemIndex)
{
  // Calculate the discounted price of the item
  return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
  // Check if the total meets the minimum
  return total >= minimumSpend;
}

string FormatDecimal(double input)
{
  // Format the double so only 2 decimal places are displayed
  return input.ToString().Substring(0, 5);
}

Console.WriteLine("=======================================");
Console.WriteLine("Exercise - Return numbers from methods");

double usd = 23.75;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = {vnd} VND");

int UsdToVnd(double usd)
{
  int rate = 23500;
  return (int)(rate * usd);
}

double VndToUsd(int vnd)
{
  double rate = 23500;
  return vnd / rate;
}

Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

Console.WriteLine("=======================================");
Console.WriteLine("Exercise - Return strings from methods");

string input = "snake";
Console.WriteLine($"The reverse of {input} is {ReverseWord(input)}");

string ReverseWord(string word)
{
  string result = "";
  for (int i = word.Length - 1; i >= 0; i--)
  {
    result += word[i];
  }
  return result;
}

string inputSentence = "The quick brown fox";
Console.WriteLine($"The reverse of '{inputSentence}' is '{ReverseSentence(inputSentence)}'");

string ReverseSentence(string sentence)
{
  string result = "";
  string[] words = sentence.Split(" ");

  foreach (string word in words)
  {
    result = ReverseWord(word) + " " + result;
  }

  return result.Trim();
}

Console.WriteLine("=======================================");
Console.WriteLine("Exercise - Return Booleans from methods");

string[] palindromeWords = { "racecar", "talented", "civic", "deified", "tent", "tenet", "rotor" };

Console.WriteLine("Is it a palindrome?");
foreach (string word in palindromeWords)
{
  Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
  int start = 0;
  int end = word.Length - 1;

  while (start < end)
  {
    if (word[start] != word[end])
    {
      return false;
    }
    start++;
    end--;
  }
  return true;
}
