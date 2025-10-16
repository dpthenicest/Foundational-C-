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

Console.WriteLine("=======================================");
Console.WriteLine("Exercise - Return arrays from methods");

int oldTarget = 60;
int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[] result = TwoCoins(coins, oldTarget);

if (result.Length == 0)
{
  Console.WriteLine("No two coins make change");
}
else
{
  Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
}

int[] TwoCoins(int[] coins, int target)
{
  for (int curr = 0; curr < coins.Length; curr++)
  {
    for (int next = curr + 1; next < coins.Length; next++)
    {
      if (coins[curr] + coins[next] == target)
      {
        return new int[] { curr, next };
      }
    }
  }

  return new int[0];
}

Console.WriteLine("==============================================");
Console.WriteLine("Find multiple pairs of coins that make change");

int newTarget = 30;
int[] newCoins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[,] newResult = MultipleTwoCoins(newCoins, newTarget);

if (newResult.Length == 0)
{
  Console.WriteLine("No two coins make change");
}
else
{
  Console.WriteLine("Change found at positions:");
  for (int i = 0; i < newResult.GetLength(0); i++)
  {
    if (newResult[i, 0] == -1)
    {
      break;
    }
    Console.WriteLine($"{newResult[i, 0]} and {newResult[i, 1]}");
  }
}

int[,] MultipleTwoCoins(int[] coins, int target)
{
  int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
  int count = 0;

  for (int curr = 0; curr < coins.Length; curr++)
  {
    for (int next = curr + 1; next < coins.Length; next++)
    {
      if (coins[curr] + coins[next] == target)
      {
        result[count, 0] = curr;
        result[count, 1] = next;
        count++;
      }
      if (count == result.GetLength(0))
      {
        return result;
      }
    }
  }
  return (count == 0) ? new int[0, 0] : result;
}

Console.WriteLine("==============================================");
Console.WriteLine("Exercise - Complete the challenge to add methods to make the game playable");

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");

if (ShouldPlay())
{
  PlayGame();
}

void PlayGame()
{
  var play = true;

  while (play)
  {
    var target = random.Next(1, 6);
    var roll = random.Next(1, 6);

    Console.WriteLine($"Roll a number greater than {target} to win!");
    Console.WriteLine($"You rolled a {roll}");
    Console.WriteLine(WinOrLose(roll, target));
    Console.WriteLine("\nPlay again? (Y/N)");

    play = ShouldPlay();
  }
}

bool ShouldPlay()
{
  string? answer = null;

  answer = Console.ReadLine();
  if (answer?.ToLower() == "y")
  {
    return true;
  }

  return false;
}

string WinOrLose(int roll, int target)
{
  if (roll > target)
  {
    return "You win!";
  }
  else if (roll == target)
  {
    return "It's a tie!";
  }
  else
  {
    return "You lose!";
  }
}
