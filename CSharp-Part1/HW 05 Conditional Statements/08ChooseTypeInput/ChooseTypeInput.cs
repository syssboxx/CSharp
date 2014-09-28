//Write a program that, depending on the user's choice inputs int, double or string variable. 
//If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
//The program must show the value of that variable as a console output. Use switch statement.


using System;

class ChooseTypeInput
{
    static void Main()
    {
        int choice;

        Console.WriteLine("Choose the type of the variable you want to enter.");
        Console.WriteLine("1 for int, 2 for double, 3 for string");
        //choice = int.Parse(Console.ReadLine());
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Enter a valid number for your choice!");
            
        }

        switch (choice)
        {
            case 1: 
                Console.WriteLine("Enter an integer variable: ");
                int inputInteger = int.Parse(Console.ReadLine());
                inputInteger++;
                Console.WriteLine("The result is {0}",inputInteger);
                break;
            case 2:
                Console.WriteLine("Enter a double variable: ");
                double inputDouble = double.Parse(Console.ReadLine());
                inputDouble++;
                Console.WriteLine("The result is {0}",inputDouble);
                break;
            case 3:
                Console.WriteLine("Enter a string variable: ");
                string inputString = Console.ReadLine();
                inputString = inputString + "*";
                Console.WriteLine("The result is {0}",inputString);
                break;
            default :
                Console.WriteLine("Error! There's no such a choice number!");
                break;
        }
    }
}

//