// See https://aka.ms/new-console-template for more information
Console.WriteLine("For Loop Statement!");

for (int i = 0; i < 10; i++)
{
  Console.WriteLine($"Current value of i is {i}.");
}

Console.WriteLine("Loop completed!");
Console.WriteLine("");

for (int i = 10; i >= 0; i--)
{
  Console.WriteLine($"Current value of i is {i}.");
}

Console.WriteLine("Loop completed!");
Console.WriteLine("");

for (int i = 0; i < 10; i += 3)
{
  Console.WriteLine($"Current value of i is {i}.");
}

Console.WriteLine("Loop completed!");
Console.WriteLine("");

for (int i = 0; i < 10; i++)
{
  Console.WriteLine($"Current value of i is {i}.");
  if (i == 7) break;
}

Console.WriteLine("Loop completed!");
Console.WriteLine("");

string[] names = { "Alex", "John", "Mary", "Jane", "Tom" };
for (int i = 0; i < names.Length; i++)
{
  Console.WriteLine($"Current name is {names[i]}.");
}

Console.WriteLine("Loop completed!");
Console.WriteLine("");

for (int i = 0; i < names.Length; i++)
{
  if (names[i] == "Mary") names[i] = "Maria";
}

foreach (var name in names) Console.WriteLine($"Updated name is {name}.");


// EXERCISE

Console.WriteLine("");
Console.WriteLine("Exercise: FizzBuzz challenge!");
Console.WriteLine("");

for (int i = 1; i <= 100; i++)
{
  if (i % 3 == 0 && i % 5 == 0) Console.WriteLine($"{i} - FizzBuzz");
  else if (i % 3 == 0) Console.WriteLine($"{i} - Fizz");
  else if (i % 5 == 0) Console.WriteLine($"{i} - Buzz");
  else Console.WriteLine(i);
}
Console.WriteLine("FizzBuzz challenge completed!");