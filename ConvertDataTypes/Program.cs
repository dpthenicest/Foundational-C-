// See https://aka.ms/new-console-template for more information
Console.WriteLine("Convert data types using casting and conversion techniques in C#!");

int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine($"Result of adding {first} and {second} is: {result}");

Console.WriteLine(" ");

decimal mydecimal = 3.14m;
Console.WriteLine($"decimal: {mydecimal}");

int myInt = (int)mydecimal;
Console.WriteLine($"int: {myInt}");

Console.WriteLine(" ");

decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;
Console.WriteLine($"decimal: {myDecimal}");
Console.WriteLine($"float: {myFloat}");

Console.WriteLine(" ");

int firstInt = 5;
int secondInt = 7;
string message = firstInt.ToString() + secondInt.ToString();
Console.WriteLine($"Converted Int to String and Concatenated them: {message}");

Console.WriteLine(" ");

string firstStr = "5";
string secondStr = "7";
int sum = int.Parse(firstStr) + int.Parse(secondStr);
Console.WriteLine($"Parsed Strings to Int and Summed them: {sum}");

Console.WriteLine(" ");

string value1 = "5";
string value2 = "7";
int resultInt = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine($"Converted Strings to Int and Summed them: {resultInt}");

Console.WriteLine(" ");

int valueInt1 = (int)1.5m;
Console.WriteLine($"Casting decimal 1.5 to int results in: {valueInt1} (Note: This truncates the decimal part)");

int valueInt2 = Convert.ToInt32(1.5m);
Console.WriteLine($"Using Convert.ToInt32 on decimal 1.5 results in: {valueInt2} (Note: This rounds the value)");

Console.WriteLine(" ");

Console.WriteLine("Exercise: Examine the TryParse() method ");

string valueString = "20";
int resultFromStr = 0;
if (int.TryParse(valueString, out resultFromStr))
{
  Console.WriteLine($"Successfully parsed '{valueString}' to int: {result}");
}
else
{
  Console.WriteLine($"Failed to parse '{valueString}' to int.");
}
Console.WriteLine($"Result from TryParse: {50 + resultFromStr}");

Console.WriteLine(" ");
Console.WriteLine("Exercise - Complete a challenge to combine string array values as strings and as integers");

string[] valuesArray = { "12.3", "45", "ABC", "11", "DEF" };
string messageSum = "";
decimal totalSum = 0.0m;
decimal resultSum = 0;

foreach (string val in valuesArray)
{
  if (decimal.TryParse(val, out resultSum))
  {
    totalSum += resultSum;
  }
  else
  {
    messageSum += val + " ";
  }
}

Console.WriteLine($"Sum of valid decimal values: {totalSum}");
Console.WriteLine($"Invalid values that could not be parsed: {messageSum}");

Console.WriteLine(" ");
Console.WriteLine("Exercise - Complete a challenge to output math operations as specific number types");

int valueNo1 = 11;
decimal valueNo2 = 6.2m;
float valueNo3 = 4.3f;

int result1 = Convert.ToInt32(valueNo1 / valueNo2);

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = valueNo2 / (decimal)valueNo3;

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");


float result3 = valueNo3 / valueNo1;

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");