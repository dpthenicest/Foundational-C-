// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operations on Arrays with Helper ethods!");


string[] pallets = ["B14", "A11", "B12", "A13"];
// Array.Sort() Mathod
Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
  Console.WriteLine($"pallet: {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
// Array.Reverse() Method
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
  Console.WriteLine($"pallet: {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Cleared...");
// Array.Clear() Method
Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
  Console.WriteLine($"pallet: {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Resizing...");
// Array.Resize() Method
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing to 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";
foreach (var pallet in pallets)
{
  Console.WriteLine($"pallet: {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing to 3 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
  Console.WriteLine($"pallet: {pallet}");
}

Console.WriteLine("");
// TOCharArary(), Join() and Split() Methods
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);

string result1 = string.Join(",", valueArray);
Console.WriteLine(result1);

string[] items = result1.Split(',');
foreach (string item in items)
{
  Console.WriteLine($"item: {item}");
}

Console.WriteLine("");
Console.WriteLine("Exercise - Complete a challenge to reverse words in a sentence");

string pangram = "The quick brown fox jumps over the lazy dog";
string[] words = pangram.Split(" ");
for (int i = 0; i < words.Length; i++)
{
   words[i] = new string(words[i].ToCharArray().Reverse().ToArray());
}
string reversedPangram = string.Join(" ", words);
Console.WriteLine($"Reversed pangram: {reversedPangram}");


Console.WriteLine("");
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderArray = orderStream.Split(",");
Array.Sort(orderArray);
Console.WriteLine("Validating orders...");
foreach (string order in orderArray)
{
  if (order.Length != 4)
  {
    Console.WriteLine($"Invalid order: {order}");
  } else
  {
    Console.WriteLine($"Valid order: {order}");
  }
}