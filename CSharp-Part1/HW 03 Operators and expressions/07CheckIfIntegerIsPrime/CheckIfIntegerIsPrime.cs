//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class CheckIfIntegerIsPrime
    {
        static void Main()
        {
            byte number;
            byte maxNumber = 100;
            bool result;
            double maxDivider;
            bool isPrime;

            Console.WriteLine("Enter a number to check if prime : (n<=100) ");
            result = byte.TryParse(Console.ReadLine(), out number);
            if (number > maxNumber) 
            {
                Console.WriteLine("enter a valid number!");
            }

            //to be a prime number must be >1 and can be divided by all the prime numbers < sqrt(maxNumber)
            maxDivider = Math.Sqrt(maxNumber);
            Console.WriteLine("To be prime your number must can be divided by all the prime numbers < {0}",maxDivider);
            if ((((number % 2 !=0) && (number % 3 != 0) && (number % 5  !=0) && (number % 7!= 0))&&(number>1))||((number==2)||(number==3)||(number==5)||(number==7)))
            {
                isPrime = true;
             }
            else 
            { 
                isPrime = false;
            }
           Console.WriteLine("The number {0} {1}",number,isPrime?"is prime":"is not prime" );
        }
    }