// See https://aka.ms/new-console-template for more information
Console.WriteLine("Format alphanumeric data for presentation in C#!");

// Composite Formatting

string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

// String Interpolation

string first1 = "Hello";
string second2 = "World";
Console.WriteLine($"{first1} {second2}!");

// Formatting Currency

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C}, Discount: {discount:C}");

// Formatting Numbers

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N}");
Console.WriteLine($"Measurement: {measurement:N2}"); // Same as N
Console.WriteLine($"Measurement: {measurement:N4}");

// Formatting Percentages

decimal tax = .36785m;
Console.WriteLine($"Tax: {tax:P}");

// Combining Formatting approaches

decimal price1 = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = string.Format("Your discount is {0:C} off the regular {1:C2} price. ", price1 - salePrice, price1);
Console.WriteLine(yourDiscount);
yourDiscount += $"A discount of {((price1 - salePrice) / price1):P}";
Console.WriteLine(yourDiscount);

Console.WriteLine("");
Console.WriteLine("Exercise - Explore string interpolation");

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"    Shares: {productShares:N3} Product");
Console.WriteLine($"        Subtotal: {subtotal:C}");
Console.WriteLine($"            Tax: {taxPercentage:P}");
Console.WriteLine($"        Total Billed: {total:C}");

Console.WriteLine("");
Console.WriteLine("Exercise - Discover padding and alignment");

string input = "Pad this";
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

Console.WriteLine("");
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadRight(10);
Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);

Console.WriteLine("");
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},\n");
Console.WriteLine("As a customer of our {0} we a re exited to tell you about a new financial product that would dramatically increase your return.\n\nCurrently, you own {1:N2} shares at a return of {2:P2}\n\nOur new product, {3} offers a return of {4:P2}. Given your current volume, your potential profit would be {5:C2}.", currentProduct, currentShares, currentReturn, newProduct, newReturn, newProfit);

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = currentProduct.PadRight(20) + string.Format("{0:N2}", currentShares).PadLeft(10) + string.Format("{0:P2}", currentReturn).PadLeft(10) + string.Format("{0:C2}", currentProfit).PadLeft(15) + "\n" + newProduct.PadRight(20) + string.Format("{0:N2}", currentShares).PadLeft(10) + string.Format("{0:P2}", newReturn).PadLeft(10) + string.Format("{0:C2}", newProfit).PadLeft(15); 

// Your logic here

Console.WriteLine(comparisonMessage);
