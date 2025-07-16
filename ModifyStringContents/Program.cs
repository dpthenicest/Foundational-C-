// See https://aka.ms/new-console-template for more information
Console.WriteLine("Modify the content of strings using built-in string data type methods in C#");
Console.WriteLine("");

string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += 6;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

Console.WriteLine("");
Console.WriteLine("Exercise - Use the string's IndexOf() and LastIndexOf() helper methods");


string message1 = "hello there!";

int first_h = message1.IndexOf('h');
int last_h = message1.LastIndexOf('h');

Console.WriteLine($"For the message: '{message1}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

Console.WriteLine("");
Console.WriteLine("Retrieve the last occurence of a sub string");
string message2 = "(What if) I am (only interested) in the last (set of parantheses)?";
int openingPosition2 = message2.LastIndexOf('(');

openingPosition2 += 1; // Move past the '(' character
int closingPosition2 = message2.LastIndexOf(')');
int length1 = closingPosition2 - openingPosition2;
Console.WriteLine(message2.Substring(openingPosition2, length1));

Console.WriteLine("");
Console.WriteLine("Retrieve the last occurence of a sub string");

string message3 = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
  int openingPosition3 = message3.IndexOf('(');
  if (openingPosition3 == -1) break;

  openingPosition3 += 1; // Move past the '(' character
  int closingPosition3 = message3.IndexOf(')');
  int length2 = closingPosition3 - openingPosition3;
  Console.WriteLine(message3.Substring(openingPosition3, length2));

  message3 = message3.Substring(closingPosition3 + 1); // Move past the closing parenthesis
}