// See https://aka.ms/new-console-template for more information
Console.WriteLine("Data Types in C#:");

// Integral Types

Console.WriteLine("Signed Intergral Types:");

Console.WriteLine($"sbyte: {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short: {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long: {long.MinValue} to {long.MaxValue}");

Console.WriteLine(" ");
Console.WriteLine("Unsigned Integral Types:");

Console.WriteLine($"byte: {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort: {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint: {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong: {ulong.MinValue} to {ulong.MaxValue}");
Console.WriteLine(" ");

// Floating Point Types

Console.WriteLine("Floating point types:");
Console.WriteLine($"Float: {float.MinValue} to {float.MaxValue} with ~6-9 digits of precision");
Console.WriteLine($"Double: {double.MinValue} to {double.MaxValue} with ~15-17 digits of precision");
Console.WriteLine($"Decimal: {decimal.MinValue} to {decimal.MaxValue} with ~28-29 digits of precision");
Console.WriteLine(" ");

// Reference Types

int[] data; // nullable reference type or null reference
data = new int[5]; // now data is initialized/instanciated to an array of 5 integers

int[] pool = new int[3]; // both declaration and initialization

string shortenedString = "Mr Wali's PC";
Console.WriteLine($"Shortened string: {shortenedString} with length {shortenedString.Length}");
Console.WriteLine(" ");

// Difference between value and reference types
int val_A = 2;
int val_B = val_A; // value type, so val_B is a copy of val_A
val_B = 3; // changing val_B does not affect val_A

Console.WriteLine($"val_A: {val_A}, val_B: {val_B}"); // val_A remains 2, val_B is now 3
Console.WriteLine(" ");

int[] ref_A = new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A; // reference type, so ref_B points to the same
ref_B[0] = 5; // changing ref_B will affect ref_A

Console.WriteLine($"ref_A[0]: {ref_A[0]}, ref_B[0]: {ref_B[0]}"); // both will be 5