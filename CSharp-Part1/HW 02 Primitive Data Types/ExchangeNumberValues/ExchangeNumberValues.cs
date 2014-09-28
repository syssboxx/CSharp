//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.


using System;
class ExchangeNumberValues
{
    static void Main()
    {
        int firstNumber = 5;
        int secondNumber = 10;
        int temp = firstNumber;
        Console.WriteLine("The initial numbers are : {0} {1}", firstNumber, secondNumber);
        firstNumber = secondNumber;
        secondNumber = temp;
        Console.WriteLine("The exchanged numbers are : {0} {1}", firstNumber, secondNumber);
    }
}

