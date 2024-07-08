using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp;
internal class Operators
{
    public Operators()
    {
        // Operators
        // Operators are used to perform operations on variables and values.

        /*
         Arithmetic Operators
            Arithmetic operators are used to perform common mathematical operations:

            Operator	Name	Description	Example	Try it
            +	Addition	Adds together two values	x + y	
            -	Subtraction	Subtracts one value from another	x - y	
            *	Multiplication	Multiplies two values	x * y	
            /	Division	Divides one value by another	x / y	
            %	Modulus	Returns the division remainder	x % y	
            ++	Increment	Increases the value of a variable by 1	x++	
            --	Decrement	Decreases the value of a variable by 1	x--
         
         */

        //Assignment Operators
        //Assignment operators are used to assign values to variables.
        //The addition assignment operator (+=) adds a value to a variable:
        int x = 10;
        x += 5;

        /*
        
        A list of all assignment operators:

            Operator	Example	Same As	Try it
            =	x = 5	x = 5	
            +=	x += 3	x = x + 3	
            -=	x -= 3	x = x - 3	
            *=	x *= 3	x = x * 3	
            /=	x /= 3	x = x / 3	
            %=	x %= 3	x = x % 3	
            &=	x &= 3	x = x & 3	
            |=	x |= 3	x = x | 3	
            ^=	x ^= 3	x = x ^ 3	
            >>=	x >>= 3	x = x >> 3	
            <<=	x <<= 3	x = x << 3

         */
    }
}
