using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp;
public class UserInput
{
    public UserInput()
    {
        // Type your username and press enter
        Console.WriteLine("Enter username:");

        // Create a string variable and get user input from the keyboard and store it in the variable
        string userName = Console.ReadLine();

        // Print the value of the variable (userName), which will display the input value
        Console.WriteLine("welecome, Dear: "+userName);

        // by default the Readline Function is stting in the int that will generate error so do this:

        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age is: " + age);


        /*
         
         Note: If you enter wrong input (e.g. text in a numerical input),you will get an exception/error message 
        (like System.FormatException: 'Input string was not in a correct format.').
         */
    }
}
