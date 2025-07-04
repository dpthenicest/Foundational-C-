// See https://aka.ms/new-console-template for more information
Console.WriteLine("Switch Case Statement!");

string fruit = "banana";

switch (fruit)
{
  case "apple":
    Console.WriteLine($"App will display information for apple.");
    break;

  case "banana":
    Console.WriteLine($"App will display information for banana.");
    break;

  case "cherry":
    Console.WriteLine($"App will display information for cherry.");
    break;
}

int employeeLevel = 100;
string employeeName = "John Doe";

string title = "";

switch (employeeLevel)
{
  case 100:
    title = "Junior Associate";
    break;
  case 200:
    title = "Senior Associate";
    break;
  case 300:
    title = "Manager";
    break;
  case 400:
    title = "Senior Manager";
    break;
  default:
    title = "Associate";
    break;
}

Console.WriteLine($"Employee {employeeName} is at level {employeeLevel} and holds the title of {title}.");


string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
  case "01":
    type = "Sweat shirt";
    break;
  case "02":
    type = "T-shirt";
    break;
  case "03":
    type = "Sweat pants";
    break;
  default:
    type = "Other";
    break;
}

switch (product[1])
{
  case "MN":
    color = "Maroon";
    break;
  case "BL":
    color = "Black";
    break;
  case "WH":
    color = "White";
    break;
}

switch (product[2])
{
  case "S":
    size = "Small";
    break;
  case "M":
    size = "Medium";
    break;
  case "L":
    size = "Large";
    break;
  default:
    size = "One Size Fits ALl";
    break;
}

Console.WriteLine($"Product: {size} {color} {type}");