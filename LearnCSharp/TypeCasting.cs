using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LearnCSharp;
public class TypeCasting
{
    public TypeCasting()
    {
        // Type casting is coverting one datatype to other
        /*
            there are two type of casting:
            Implicit Casting (automatically) - 
                    converting a smaller type to a larger type size char -> int -> long -> float -> double

            Explicit Casting (manually) - converting a larger type to a smaller size type
                    double -> float -> long -> int -> char
         */

        int myInt = 9;
        double myDouble = myInt;       // Automatic casting: int to double

        Console.WriteLine(myInt);      // Outputs 9
        Console.WriteLine(myDouble);   // Outputs 9




        double myDoubleExplicit = 9.78;
        int myIntExplicit = (int)myDoubleExplicit;    // Manual casting: double to int

        Console.WriteLine(myDouble);   // Outputs 9.78
        Console.WriteLine(myIntExplicit);      // Outputs 9


        // Type Conversion Methods
        //It is also possible to convert data types explicitly by using built-in methods,
        //such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long):


        int myIntCM = 10;
        double myDoubleCM = 5.25;
        bool myBoolCM = true;

        Console.WriteLine(Convert.ToString(myIntCM));    // convert int to string
        Console.WriteLine(Convert.ToDouble(myIntCM));    // convert int to double
        Console.WriteLine(Convert.ToInt32(myDoubleCM));  // convert double to int
        Console.WriteLine(Convert.ToString(myBoolCM));   // convert bool to string



        //Why Conversion?
        //Many times, there's no need for type conversion. But sometimes you have to.
        //Take a look at the next chapter, when working with user input, to see an example of this.



    }
}
