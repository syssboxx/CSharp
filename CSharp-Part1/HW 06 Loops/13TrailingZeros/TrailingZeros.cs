/* Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
	N = 10  N! = 3628800  2
	N = 20  N! = 2432902008176640000  4
	Does your program work for N = 50 000?
	Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!**/

using System;
using System.Numerics;


class TrailingZeros
{

    static void Main()
    {
        Console.Write("Enter an integer number to calculate how many trailing zeros there are in its factoriel.\nn= ");
        int n = int.Parse(Console.ReadLine());
        BigInteger factoriel = 1;
        int trailingZeros = 0;

        //check if each element of the factoriel is divisable by 5 without remainder  and if the division result also is divisable by 5 - if yes we have 1 Trailing zero.

        for (int i = 1; i <= n; i++)
        {
            int divider = i;
            while (divider % 5 == 0)
            {
                trailingZeros++; ;
                divider = divider / 5;

            }
        }

        Console.WriteLine("There are {0} zeros in N!", trailingZeros);

       
        
    }
}