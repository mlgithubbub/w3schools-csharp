# C# Variables

## C# Variables

- containers for storing values

4 types:

1. `int`: integers (whole numbers), without decimals: 123, -123
2. `double`: floating point numbers, with decimals: 19.99, -19.99
3. `char`: single characters: 'a', 'B'
    - char values are surrounded by single quotes
4. `string`: text: "Hello, World!"
    - surrounded by double quotes
5. `bool`: true or false

## Declaring (Creating) Variables

- specify the type and assign it a value:

```c#
type variableName = value;
```

- `=` used to assign values to the variable

Create a variable called `name` of type `string` and assign it the value `John`:

```c#
string name = "John";
Console.WriteLine(name);
```

Create a variable called `myNum` of type `int` and assign it the value of `15`:

```c#
int myNum = 15;
Console.WriteLine(myNum);
```

You can also declare a variable without assign a value and assign the value late:

```c#
int myNum;
myNum = 15;
Console.WriteLine(myNum);
```

If you assign a new value to an existing variable it will overwrite the previous value:

```c#
int myNum = 15;
myNum = 20; // myNum is now 20
Console.WriteLine(myNum);
```

Declare variables of other types:

```c#
int myNum = 5;
double myDoubleNum = 5.99D;
char myLetter = 'D';
bool myBool = true;
string myText = "Hello";
```

# C# Constants

## Constants

- if you don't want existing values to be overwritten, add `const` keyword in front of the variable type
- this makes it unchangeable and read-only:

```c#
const int myNum = 15;
myNum = 20; // error
```

- good example of a constant is PI(3.14159...)
- you cannot declare a constant without assigning a value

# C# Display Variables

## Display Variables

- `WriteLine()` is often used to display variables to the console window:
- to combine both text and a variable, use `+`:

```c#
string name = "John";
Console.WriteLine("Hello " + name);
```

You can also use `+` to add two variables:

```c#
string firstName = "John ";
string lastName = "Doe";
string fullName = firstName + lastName;
Console.WriteLine(fullName);
```

Use `+` to add two numeric values:

```c#
int x = 5;
int y = 6;
Console.WriteLine(x + y); // Print the value of x + y
```

# C# Multiple Variables

## Declare Many Variables

To declare more than one variable of the same type, use a comma-seperated list:

```c#
int x = 5, y = 6, z = 50;
Console.WriteLine(x + y + z);
```

You can also assign the same values to multiple variables in one line:
```c#
int x, y, z;
x = y = z = 50;
Console.WriteLine(x + y + z);
```

# C# Identifiers

- all C# variables must be `identified` with unique names called `identifiers`
- can be short: x, y, z OR descriptive: age, sum totalVolume
- descriptive names are recommended for understandable and readable code:

```c#
// Good
int minutesPerHour = 60;

// OK, but not so easy to understand what m actually is
int m = 60;
```

General rules for naming variables:
- can contain letters, digits and underscore `_`
- must begin with letter or underscore `_`
- should start with lowercase letter
- cannot contain whitespace
- are case-sensitive: myVar =/= myvar
- reserved words (`int` or `double`) cannot be used as names



