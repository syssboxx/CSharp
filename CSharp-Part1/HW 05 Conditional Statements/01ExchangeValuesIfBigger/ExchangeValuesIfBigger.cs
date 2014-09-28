//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

using System;

class ExchangeValuesIfBigger
{
    static void Main()
    {
        Console.WriteLine("Enter two integer numbers (on separete lines) : ");

        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            //exchange their values
            firstNumber = firstNumber ^ secondNumber;
            secondNumber = secondNumber ^ firstNumber;
            firstNumber = firstNumber ^ secondNumber;
            Console.Write("Numbers exchanged! ");
        }
        else 
        {
            Console.Write("Nothing exchanged! ");  
        }
        Console.WriteLine("The two numbers are {0},{1}",firstNumber,secondNumber);
    }
}
