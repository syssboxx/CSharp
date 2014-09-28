//In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
//Cn=(2n)!/(n+1)!*n!
//Write a program to calculate the Nth Catalan number by given N.


using System;
using System.Numerics;

class CatalanNumbers
{
    //create a method for the calculation of the factoriels
    static BigInteger CalculateFactoriel(int n)
    {
        BigInteger factoriel=1;
        for (int i = n; i >= 1; i--)
			{
			 factoriel=factoriel*i;
			}
        return factoriel;
    }

    static void Main()
    {
        Console.Write("Enter number : ");
        int number = int.Parse(Console.ReadLine());
        BigInteger catalanNumber = CalculateFactoriel(2 * number) / (CalculateFactoriel(number + 1) * CalculateFactoriel(number));
        Console.WriteLine("For n={0} Catalan Number={1}/{2}*{3}={4}", number,CalculateFactoriel(2 * number),CalculateFactoriel(number + 1), CalculateFactoriel(number),catalanNumber);
         
    }

}