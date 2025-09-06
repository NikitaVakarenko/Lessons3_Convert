# Lessons3_Convert


This repository contains a simple C# console application that demonstrates basic type conversion. The program takes string inputs from the user, converts them to numerical types (`int` and `double`), performs a calculation, and displays the results. A key feature is its handling of culture-specific number formatting by explicitly defining the decimal separator for parsing `double` values.

## Features

*   Reads two integers from user input via the console.
*   Calculates and displays the sum of the two integers.
*   Reads a floating-point number (a `double`) from user input.
*   Uses `NumberFormatInfo` to correctly parse the `double` value with a period (`.`) as the decimal separator, making the input format consistent across different system locales.
*   Displays the parsed `double` value.

## Prerequisites

*   .NET Framework 4.7.2 or a later version.
*   Visual Studio or any compatible C# compiler/IDE.

## Getting Started

### 1. Clone the repository

```sh
git clone https://github.com/NikitaVakarenko/Lessons3_Convert.git
cd Lessons3_Convert
```

### 2. Build and Run

You can build and run this project using Visual Studio or from the command line.

#### Using Visual Studio

1.  Open the `Lessons3_Convert.sln` solution file in Visual Studio.
2.  Press `F5` or select `Debug > Start Debugging` to build and run the application.

#### Using the Command Line

1.  Navigate to the project's root directory.
2.  Use MSBuild to compile the solution.
3.  Execute the compiled program from the output directory.

```sh
# After building, navigate to the output directory (e.g., Debug)
cd Lessons3_Convert/bin/Debug

# Run the executable
./Lessons3_Convert.exe
```

### Example Interaction

Here is an example of what the console interaction will look like when you run the program:

```
Enter the number1:42
Enter the number2:58
The sum is:100
Enter the double:3.14159
3.14159
```

## Code Highlights

The application primarily uses the `System.Convert` class to perform type conversions from `string` to numeric types.

### String to Integer Conversion

Input from `Console.ReadLine()` is converted directly to an `int`.

```csharp
Console.Write("Enter the number1:");
str = Console.ReadLine();
a = Convert.ToInt32(str);
```

### String to Double Conversion with Formatting

To handle potential differences in regional settings (e.g., using a comma vs. a period for the decimal separator), `NumberFormatInfo` is configured and passed to the `Convert.ToDouble` method.

```csharp
Console.Write("Enter the double:");
str = Console.ReadLine();
NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
{
    NumberDecimalSeparator = ".",
};
double d = Convert.ToDouble(str, numberFormatInfo);
Console.WriteLine(d);
