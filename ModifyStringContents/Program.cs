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

Console.WriteLine("");
Console.WriteLine("Work with different types of symbol sets with IndexOfAny()");

string message4 = "Hello World!";
char[] charsToFind = { 'a', 'e', 'i' };

int index = message4.IndexOfAny(charsToFind);

Console.WriteLine($"Found '{message4[index]}' in '{message4}' at index: {index}.");

Console.WriteLine("");
Console.WriteLine("Work with different types of symbol sets with IndexOfAny() - II");

string message5 = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message5}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingPosition5 = message5.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message5.Substring(openingPosition5)}");

openingPosition5 = message5.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message5.Substring(openingPosition5)}");

Console.WriteLine("");
Console.WriteLine("Work with different types of symbol sets with IndexOfAny() - III");

string message6 = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols1 = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition6 = 0;

while (true)
{
    int openingPosition6 = message6.IndexOfAny(openSymbols1, closingPosition6);

    if (openingPosition6 == -1) break;

    string currentSymbol = message6.Substring(openingPosition6, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition6 += 1;
    closingPosition6 = message6.IndexOf(matchingSymbol, openingPosition6);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length6 = closingPosition6 - openingPosition6;
    Console.WriteLine(message6.Substring(openingPosition6, length6));
}

Console.WriteLine("");
Console.WriteLine("Exercise - Use the Remove() and Replace() methods");

string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

string message7 = "This--is--ex-amp-le--da-ta";
message7 = message7.Replace("--", " ");
message7 = message7.Replace("-", "");;
Console.WriteLine(message7);

Console.WriteLine("");
Console.WriteLine("Exercise - Complete a challenge to extract, replace, and remove data from an input string");

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your code here

// const string openSpan = "<span>"; Alreaduy defined above
// const string closeSpan = "</span>"; Alreaduy defined above

int openSpanPosition = input.IndexOf(openSpan);
int closeSpanPosition = input.IndexOf(closeSpan);
int spanlength = openSpanPosition + 6;

quantity = input.Substring(spanlength, closeSpanPosition - spanlength);

const string openDiv = "<div>";
const string closeDiv = "</div>";

int openDivPosition = input.IndexOf(openDiv);

output = input.Remove(openDivPosition, openDiv.Length);

int closeDivPosition = output.IndexOf(closeDiv);
output = output.Remove(closeDivPosition, closeDiv.Length);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");