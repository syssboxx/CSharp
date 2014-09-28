//Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.

using System;

class DeclareBoolVariable
{
    static void Main()
    {
        bool isFemale=false; 
        Console.WriteLine("Enter your gender : f or h ");
        char gender = char.Parse(Console.ReadLine());
        if ((gender == 'f')||(gender == 'F'))
        {
            isFemale = true;
            Console.WriteLine("{0} - you're female", isFemale);
        }
        else if ((gender == 'm') || (gender == 'M'))
        {
            Console.WriteLine("{0}  -you're a man ", isFemale);
        }
        else
        {
            Console.WriteLine("Invalid character or unknown gender!");
        }


    }
}