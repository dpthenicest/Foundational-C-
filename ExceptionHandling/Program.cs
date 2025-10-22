// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Implement Exception Handling In C# Console Applications");

Console.WriteLine("\nCODE 1: Implementing Try-Catch Blocks");

double float1 = 3000.0;
double float2 = 0.0;
int number1 = 3000;
int number2 = 0;

try
{
  Console.WriteLine(float1 / float2);
  Console.WriteLine(number1 / number2);
}
catch
{
  Console.WriteLine("An exception has been caught");
}
Console.WriteLine("Exit program");


Console.WriteLine("\nCODE 2: Catch exceptions thrown in called methods");

try
{
  Process1();
}
catch
{
  Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
  try
  {
    WriteMessage();
  }
  catch

  {
    Console.WriteLine("Exception caught in Process1");
  }
}

static void WriteMessage()
{
  double float1 = 3000.0;
  double float2 = 0;
  int number1 = 3000;
  int number2 = 0;

  Console.WriteLine(float1 / float2);
  Console.WriteLine(number1 / number2);
}

Console.WriteLine("\nCODE 3: Exercise - Catch specific exception types");

try
{
    Process2();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process2()
{
    try
    {
        WriteMessage1();
    }
    catch
    {
        Console.WriteLine("Exception caught in Process1");
    }
}

static void WriteMessage1()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}

