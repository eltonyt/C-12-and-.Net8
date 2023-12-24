# C-12-and-.Net8
Learning C # and .NET
## Chapter 1 - Hello, C#! Welcome, .NET!

### Terminology

- modern .NET → .NET8
- legacy .NET → .NET Framework, Mono, Xamarin, and .NET standard

### Environment Setup

- IDE - Visual Studio Code for Windows
- Extensions
    - C# Dev Kit (Official C# extension from Microsoft)
- **Issue - Cannot install .NET SDK 8 (Other Program installation in progress issue)**
    - **Fix: close *Windows Install* progress through Task Manager, then start Windows *Install service***
- **Issue 2 - .NET SDK cannot be found after .NET Installation process finished.**
    - **Fix: Remove all contents under directory C:\Program Files (x86)\dotnet**

### .NET

- Versions - LTS (≥3 years support), STS (≥ 18 months after GA), Preview
- SDK
    - Runtime
    - Compilers (Roslyn)
        - C# →  Intermediate Language (IL) as assembly .IL code
        - IL code executed by .NET’s VM (These IL codes can be run on any platforms - Windows, Mac, Linux, etc.)
    - etc.
- .NET technologies
    - **Modern .NET** - Windows, macOS, Linux, Android, IOS, tvOS, Tizen
    - .NET Framework - Windows
    - Xamarin - Android, IOS, macOS

## New Project

Steps:

1. New Fold for the solution (PS: .NET has a solution that’s above projects)
2. Create a solution file in the folder: **dotnet new sln**
3. Create a folder and project using a template: **dotnet new console -o HelloCS (*console* is a template in C#)**
4. Add the folder and its project to the solution: **dotnet sln add HelloCS**
5. Repeat steps 3 & 4 to create and add any other projects
6. Open the folder containing the solution using Visual Studio Code: **.code**

## Chapter 2 - Speaking C#

### C# grammar and vocabulary

- Statements
- Comments
    
    ```csharp
    // or /* */
    ```
    
- Blocks {}
    - **!! - Each brace is on its own line**
    - **namespace** - contains types like classes to group them together (Similar to the *module* in Java)
    - class - contains the members of an object, including methods
    - method - contains statements that implement an action that an object can make
- Regions - Collapsible code block
    
    ```csharp
    #region 
    ...
    #endregion
    ```
    
- Importing Namespace - all available types in that namespace will be available to your program without needing to enter the namespace prefix
    
    ```csharp
    using [namespace]
    ```
    
    - **Global Import - So this whole project has common used libraries imported automatically - ./{projectname}/obj/Debug/net8.0/{Projectname}.GlobalUsings.g.cs**

### Types

- char
- string
    - tab - /t
    - default value - “”
    - If /t needs is not representing as a tab, such as a specific path, then need to add “@” at front.
        
        ```csharp
        string filePath = @"C:\ttttt\ttest"
        ```
        
    - Raw string - ≥ C# 11 (with ≥ 3 double quotes)
        
        ```csharp
        string xml = """ <person age="50">
        										<first_name> Mark </firstname>
        								</person>
        							"""
        ```
        
    - Raw Interpolated string literals - number of dollar signs at front tells the compiler that curly braces with this number will be replaced by an expression value
        
        ```csharp
        string json = $$"""
        							{
        								"first_name": "{{person.FirstName}}",
        								"age": "{{person.Age}}",
        								"calculation": "{{{1 + 1}}}"
        							}
        							"""
        {
        	"first_name": "Alice",
        	"age": "56",
        	"calculation": "2"
        }
        ```
        
- numbers
    - unsigned integer - uint
    - integer - int - 4 bytes
        - -2^32 ~ 2^32 - 1
        - Binary - start with 0b
        - Hexadecimal - start with 0x
        - Default value: 0
    - real number - float
        - double are not as accurate as real numbers
        
        ```csharp
        double a = 0.1;
        double b = 0.2;
        bool eq = a + b == 0.3;
        // eq = False
        
        float a = 0.1F;
        float b = 0.2F;
        bool eq2 = a + b == 0.3F
        // eq2 = True
        ```
        
    - Double numbers - double - 8 bytes
        - **double are not as accurate as real numbers, so that never use doubles to compare the equality of two double numbers**
    - Decimal numbers - decimal - 16 bytes
        - **decimal numbers are accurate since it stores the number as a large integer and shifts the decimal point.**
    - Half - ≥ .NET 5 - for real numbers - Only 2 bytes of memory
        - - 65,504 ~ 65,604
    - Int128 - ≥ .NET 7 - 16 bytes of memory
    - PS: _ can be added at any digit so that we users can read it easily.
        
        ```csharp
        int oneMillion = 1_000_000;
        ```
        
- Booleans - bool
    - Default Value - False
- Dynamic Types - dynamic - ≥ C#4
    - Good at performance
    - No need to specify the type of the object at the beginning
    
    ```csharp
    dynamic something;
    something = new[] {1, 2, 3};
    something = 12;
    something = "Test";
    ```
    
- Variable - var (Try not to use it cuz it would cause other developers problems reading your code : ()
    - Compiler read the value after “=” and define the type for you
- Target-typed new - ≥ C# 9
    - Constructure without variables first, then assign values needed by the class
    
    ```csharp
    Person kim = new();
    kim.BirthDate = new(1967, 12, 26); 
    ```
    
- DateTime
    - default value - 01/01/0001 00:00:00

### Formatting

- using numbered positional arguments
    
    ```csharp
    Console.WriteLine("Hello, World!");
    int numberOfApples = 12;
    decimal pricePerApple = 0.35M;
    
    Console.WriteLine(
        format: "{0} apples cost {1:C}",
        arg0: numberOfApples,
        arg1: pricePerApple * numberOfApples
    );
    
    string formatted = string.Format(
        format: "{0} apples cost {1:C}",
        arg0: numberOfApples,
        arg1: pricePerApple * numberOfApples
    );
    ```
    
- using interpolated strings - ≥ C# 6
    - Number of dollar sign matches number of curly braces
    
    ```csharp
    Console.WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");
    ```
    
- Format strings - keyword
    
    ```csharp
    **{ index [, alignment ] [ : formatString] }**
    ```
    
    - N0 - a number with thousand separators and no decimal places
    - C - Currency
    - 0 - Zero placeholder
    - # - Digit placeholder
    - . - decimal point
    - , - Group Seperator
    - % - Percentage placeholder
    - \ - Escape Character
    - ; - Section separator
        
        ```csharp
        // 123.4 -> 01234.40
        float a = 123.4F;
        Console.WriteLine($"{a:0000.00}");
        
        // 123.4 -> 1234.4
        Console.WriteLine($"{a:####.##}");
        
        // 1234567 -> 1234567.000
        int longNumber = 1234567;
        Console.WriteLine($"{longNumber:0.000}");
        
        // 1234567 -> 1,234,567
        Console.WriteLine($"{longNumber:0,000}");
        
        // 123.4 -> 12340%
        Console.WriteLine($"{a:0%}");
        ```
        
    - C or c - Currency
    - N or n - Number
    - D or d - Decimal
    - B or b - Binary
    - X or x - Hexadecimal
    - E or e - Exponential

### Getting text input from the user - Similar to input(”xxxx”) in Python

```csharp
Console.Write("Enter your name");
**// string? means this value can be null.**
string? name = Console.Readline();

**// ReadLine()! means this is a null-forgiving operator, telling the compiler ReadLine will not return null.**
string age = Console.ReadLine()!;

```

### Global Project - Dependencies Import

```csharp
// xxx.xsproj file - i.e. import System.Console library
	<ItemGroup>
    <Using Include="System.Console" Static="True" />
  </ItemGroup>
```

### Arguments - args

```csharp
Console.WriteLine($"There are {args.Length} arguments.");

foreach (string arg in args)
{
    WriteLine(arg);
}
```

### Async & Wait - ≥ C# 5

- For multithreading

```csharp
HttpClient client = new();
HttpResponseMessage response = await client.GetAsync("http://www.apple.com/");
// WAIT FOR RESPONSE FINISHED BEFORE WRITING THE LINE
WriteLine("Apple's home page has {0:N0} bytes.", response.Content.Headers.ContentLength);
```




### Operating on variables

- Binary operators
    
    ```csharp
    var result = firstOperand operator secondOperand
    ```
    
- Unary operators
    
    ```csharp
    // x++;	
    var result = OnlyOperand operator;
    // ++x;
    var result = operator OnlyOperand;
    ```
    
- Ternary operators
    
    ```csharp
    // var result = boolean_expression ? value_if_true : value_if_false;
    var result = firstOperand operator secondOperand operator thirdOperand;
    ```
    
- Binary arithmetic operators
    - +, -, *, /, %
- Assignment operators
    - =, +=, -=, *=, /=
- **Null-coalescing operators**
    - either assign a variable to a result or if the variable is null, then assign an alternative value
    - ?? or ??=
    
    ```csharp
    string? authorName = ReadLine();
    int maxLength = authorName?.Length ?? 30;
    authorName ??= "unknown";
    ```
    
- Logic operators
    - &, |, ^
    - **XOR - if 2 variables are the same, return 0, if 2 variables are not the same, return 1**
- Conditional logical operators
    - &&, ||
- Bitwise and binary shift operators
    - <<, >>
- Miscellaneous operators
    - nameof()
    - sizeof()

### Understanding selection statements

- If statement - same as if statement in Java
    - Pattern matching with the if statement - **is** keyword
- switch - same as switch statement in Java
    - Option1
        
        ```csharp
        switch (variable)
        {
        	case a:
        		xxx;
        		break;
        	case b:
        		xxx;
        		break;
        	default:
        		xxx;
        		break;
        }
        ```
        
    - Option 2 - only used for assignment, call, increment, decrement, await, and new object expressions
        
        ```csharp
        string result = variable switch
        {
        	a => xxx,
        	b => xxx,
        	_ => xxx,
        };
        WriteLine(result);
        ```
        
    

### Understanding iteration statements

- while - same as while statement in Java
- for - same as for statement in Java but only for counter incremental
- foreach - loop through a collection

### Storing multiple values in an array

- 1-dimention
    - Option 1
        
        ```csharp
        // Same as Java Array
        string[] test = new string[x];
        test[0] = "aaa";
        test[1] = "bbb";
        test[2] = "ccc";
        ```
        
    - Option 2
        
        ```csharp
        // Little bit different comparing to Java Array - no need to mention the keyword when initializing
        string[] test = {"aaa", "bbb", "cccc"};
        ```
        
- Multi-dimensions
    - Option 1
        
        ```csharp
        string[,] test = new string[3, 4];
        test[0][0] = "aaa";
        test[0][1] = "bbb";
        test[0][2] = "ccc";
        ```
        
    - Option 2
        
        ```csharp
        string[,] test = 
        {
        	{"aaa", "bbb", "ccc"}
        }
        ```
        
- List pattern matching with arrays
    
    ```csharp
    [] -> Empty Array or Collection
    [..] -> an array or collection with any number of items
    [_] -> a list with any single item
    [int item1] or [var item1] -> a list with any single item and can refer this item
    [7, 2] -> a list of two items with those values in that order
    [_, _] -> matches a list with two items
    [var item1, var item2] -> matches a list with any two items and can refer these two items
    [_, _, _] -> a list with any three items
    [var item1, ..] -> a list with one or more items, can refer item1
    [var firstItem, .., var lastItem] -> matches a list with two or more items, can refer firstItem and lastItem
    [.., var lastItem] -> matches a list with one or more items, can refer lastItem
    ```
    

### Casting and converting between types

- Types
    - Implicit(隐式) - Automatically, always safe (i.e. int to double)
    - Explicit(显式) - **Manually(need to case)**, may lose information (i.e. double to int - lose information after decimal point)
- Converting with System.Convert type - used for converting from and to all the C# number types
    
    ```csharp
    using static System.Convert
    // Example
    double g = 9.8;
    int h = ToInt32(g);
    // h = 10
    ```
    
- Rounding Numbers Rule
    - ≤ 0.5 → 0
    - ≥ 0.5 → 1
    - == 0.5
        - If integer part is odd, then 1 (9.5 → 10)
        - if integer part is even, then 0 (10.5 → 10, -12.5 → -12)
- to String
    - ToString()
- Binary to String
    - ToBase64String()
- Strings to Numbers, Dates, or Date Times
    
    ```csharp
    using System.Globalization
    int.Parse(xx);
    DateTime.Parse(xxxx);
    ```
    

### Handling exceptions - Same as try & catch in Java

try & catch

```csharp
try {
	xxxx
}
catch (Exception ex) {
	xxxx
}
```

**Catching with filters - use when**

```csharp
try 
{
}
catch (FormatException) when (amount.Contains("$"))
{
}
catch (FormatException)
{
}
```

### Checking for overflow

OverflowException