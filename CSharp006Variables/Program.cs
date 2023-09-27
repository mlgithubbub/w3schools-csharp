// using System;

// namespace CSharp006Variables
// {

//     class Program
//     {

//         static void Main(string[] args)
//         {

//             // Declare and intialize variables of different data types:
//             int myInt = 20;
//             double myDouble = 20.99;
//             char myChar = 'M';
//             string myString = "Good job, Morgan!";

//             //Only declare variables of different data types, initialize late:
//             int myInt2;
//             double myDouble2;
//             char myChar2;
//             string myString2;

//             //Here I initialize the variables:
//             myInt2 = 39;
//             myDouble2 = 44.44;
//             myChar2 = '!';
//             myString2 = "Keep going!";

//             //Here I change some variable values:
//             myInt = 50;
//             myDouble2 = 15.15;
//             myChar = '*';
//             myString2 = "Almost there!";

//             //Declare a constant:
//             const string myString3 = "Unchangeable string";

//             /*  //This throws an error:
//              myString3 = "Trying to change you"; */

//             //Declare and initialized multiple variables in the same line:
//             int x = 5, y = 6, z = 7;

//             //Declare multiple variables in the same line and initialize later:
//             int a, b, c;
//             a = b = c = 10;

//             //Print the variable values to the console:

//             //Use + to combine text and a variable:
//             Console.WriteLine("myInt = " + myInt);
//             Console.WriteLine(myDouble);
//             Console.WriteLine(myChar);
//             Console.WriteLine(myString);

//             Console.WriteLine();

//             Console.WriteLine(myInt2);
//             Console.WriteLine(myDouble2);
//             Console.WriteLine(myChar2);
//             Console.WriteLine(myString2);

//             Console.WriteLine();

//             Console.WriteLine(myString3);

//             //Use + to add two variables:
//             Console.WriteLine("myString + myString2 = " + myString + " " + myString2);

//             //Use + to add two numeric variables:
//             Console.WriteLine("myDouble + myDouble2 = " + (myDouble + myDouble2)); //Weird, without parentheses, it doesn't work!

//             //Use + to add two numeric variables:
//             Console.WriteLine("myDouble + myDouble2 = " + (20.99 + 15.15));

//             Console.WriteLine(x + y + z);
//             Console.WriteLine(a + b + c);

//         }
//     }
// }