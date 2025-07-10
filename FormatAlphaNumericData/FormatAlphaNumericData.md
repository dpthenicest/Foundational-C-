# What is Composite Formatting?
Composite formatting uses numbered placeholders within a string. At run time, everything inside the braces is resolved to a value that is also passed in based on their position.

This example of composite formatting uses a built-in method Format() on the string data type keyword. Update your code in the Visual Studio Code Editor as follows:

# What is string interpolation?
String interpolation is a technique that simplifies composite formatting.

Instead of using a numbered token and including the literal value or variable name in a list of arguments to String.Format() or Console.WriteLine(), you can just use the variable name inside of the curly braces.

# Formatting currency
Composite formatting and string interpolation can be used to format values for display given a specific language and culture. In the following example, the :C currency format specifier is used to present the price and discount variables as currency.

# How the user's country/region and language affect string formatting
What if you execute the previous code on a computer in France that has its Windows Display Language set to French? In that case you would see the following output.

Price: 123,45 € (Save 50,00 €)
The reason for the previous "€" output is that the string currency formatting feature is dependent on the local computer setting for culture. In this context, the term "culture" refers to the country/region and language of the end user. The culture code is a five character string that computers use to identify the location and language of the end user. The culture code ensures certain information like dates and currency can be presented properly.

For example:

the culture code of an English speaker in the USA is en-US.
the culture code of a French speaker in France is fr-FR.
the culture code of a French speaker in Canada is fr-CA.
The culture affects the writing system, the calendar that's used, the sort order of strings, and formatting for dates and numbers (like formatting currency).

Unfortunately, making sure your code works correctly on all computers regardless of the country/region or the end user's language is challenging. This process is known as localization (or globalization). Localization depends on many factors not discussed in this module, but simply, the string formatting syntax might use a different format depending on the user's culture.

# Formatting numbers
When working with numeric data, you might want to format the number for readability by including commas to delineate thousands, millions, billions, and so on.

The N numeric format specifier makes numbers more readable. Update your code as follows:

By default, the N numeric format specifier displays only two digits after the decimal point.

If you want to display more precision, you can do that by adding a number after the specifier. The following code will display four digits after the decimal point using the N4 specifier.

# Formatting percentages
Use the P format specifier to format percentages and rounds to 2 decimal places. Add a number afterwards to control the number of values displayed after the decimal point.

# Formatting strings by adding whitespace before or after
The PadLeft() method adds blank spaces to the left-hand side of the string so that the total number of characters equals the argument you send it. In this case, you want the total length of the string to be 12 characters.

# What is an overloaded method?
In C#, an overloaded method is another version of a method with different or extra arguments that modify the functionality of the method slightly, as is the case with the overloaded version of the PadLeft() method.

You can also call a second overloaded version of the method and pass in whatever character you want to use instead of a space

# Working with padded strings
Suppose you work for a payment processing company that still supports legacy mainframe systems. Often, those systems require data to be input in specific columns. For example, store the Payment ID in columns 1 through 6, the payee's name in columns 7 through 30, and the Payment Amount in columns 31 through 40. Also, importantly, the Payment Amount is right-aligned.

You're asked to build an application that will convert data in the relational database management system to the legacy file format. To ensure that the integration works correctly, the first step is to confirm the file format by giving the legacy system maintainers a sample of the output. Later, you build on this work to send hundreds or thousands of payments to be processed via an ASCII text file.