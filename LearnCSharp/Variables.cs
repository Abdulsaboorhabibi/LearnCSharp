using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LearnCSharp;
public class Variables
{
    public Variables()
    {
        //Variables are containers for storing data values.

        // type variableName = value;

        string name = "Habibi";



        Console.WriteLine("\n\n\n++++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine("Variable Class Start");
        Console.WriteLine($"Name variale has value: {name}");
        // or
        Console.WriteLine(name);


        int MyNumber = 99; // integer type

        int MyNubmer1; // declartion of the variable that type is int
        MyNubmer1 = MyNumber; // initialization of the variable 
        MyNubmer1 = 1;

        Console.WriteLine("MyNumber1 value is: " + MyNubmer1);

        // Constant variable 
        //If you don't want others (or yourself) to overwrite existing values, you can add the const keyword in front of the variable type.

        //This will declare the variable as "constant", which means unchangeable and read - only:

        const int mynum = 1;
        //mynum = 2; // commented for execution

        /* The const keyword is useful when you want a variable to always store the same value, so that others (or yourself) won't mess up your code. An example that is often referred to as a constant, is PI (3.14159...).

        Note: You cannot declare a constant variable without assigning the value. If you do, an error will occur: A const field requires a value to be provided.
        */

        // print of the varialbes are easy 
        Console.WriteLine(mynum); // it will print the variable

        //also 
        Console.WriteLine("my num is: " + mynum);
        // but if you concatenated the same integer type or others then it will calculated!.
        Console.WriteLine(mynum + mynum);

        // declaring many variables 
        int many1 = 2, many2 = 3, many3 = 4;
        // asigne same value to many variables 
        int same1, same2, same3;
        same1 = same2 = same3 = 10;

        Console.WriteLine($"Many Variables: many1: {many1}, many2={many2}, many3{many3}.");
        Console.WriteLine($"same variables: same1: {same1}, same2: {same2}, same3: {same3}.");

        //variables Identifiers 
        // All C# variables must be identified with unique names. These unique names are called identifiers.

        /*
         * The general rules for naming variables are:

            Names can contain letters, digits and the underscore character (_)
            Names must begin with a letter or underscore
            Names should start with a lowercase letter, and cannot contain whitespace
            Names are case-sensitive ("myVar" and "myvar" are different variables)
            Reserved words (like C# keywords, such as int or double) cannot be used as names
         */

        // Good
        int minutesPerHour = 60;

        // OK, but not so easy to understand what m actually is
        int m = 60;


        /*
         A data type specifies the size and type of variable values.

            It is important to use the correct data type for the corresponding variable; to avoid errors, to save time and memory, but it will also make your code more maintainable and readable. The most common data types are:

            Data Type	Size	Description
            int	4 bytes	Stores whole numbers from -2,147,483,648 to 2,147,483,647
            long	8 bytes	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            float	4 bytes	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
            double	8 bytes	Stores fractional numbers. Sufficient for storing 15 decimal digits
            bool	1 bit	Stores true or false values
            char	2 bytes	Stores a single character/letter, surrounded by single quotes
            string	2 bytes per character	Stores a sequence of characters, surrounded by double quotes 
         */

    }
}
