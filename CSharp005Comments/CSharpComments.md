# C# Comments

## C# Comments

- comments can be used to:
    - explain C# code
    - make it more readable
    - prevent execution when testing alternative code

## Single-line Comments

- Single-line comments: any text between `//` and the end of the line is ignored by C# (not executed)

```c#
// This is a comment
Console.WriteLine("Hello World!");
```
Single-line comment at the end of a line of code:

```c#
Console.WriteLine("Hello World!");  // This is a comment
```

## C# Multi-line Comments

- start with `/*` and end with `*/`
- any text in between will be ignored by C#
- `multi-line comment` = `comment block`

```c#
/* The code below will print the words Hello World
to the screen, and it is amazing */
Console.WriteLine("Hello World!"); 
```