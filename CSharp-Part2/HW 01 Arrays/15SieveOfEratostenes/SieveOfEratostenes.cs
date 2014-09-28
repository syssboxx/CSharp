using System;

class SieveOfEratostenes
{
    static void Main()
    {
        int maxNumber = 10000000;

        bool [] numbers = new bool [maxNumber];

        int counter = 0;

        for (int i = 2; i <= Math.Sqrt(maxNumber); i++)
        {
            if (!numbers[i])
            {
                for (int j = i * i; j < numbers.Length; j = j + i)
                {
                    numbers[j] = true;
                }

            }
            
        }
       
        //print all the primes
        for (int i = 2; i < numbers.Length; i++)
        {
            if (numbers[i]==false)
            {
                Console.WriteLine(i);
            }
        }
        //Console.WriteLine("There are {0} primes in (0,{1})",counter,maxNumber);

    }
}
