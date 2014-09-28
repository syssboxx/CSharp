//Write a program that calculates N!/K! for given N and K (1<K<N).

using System;

class Factoriel
{
    static void Main()
    {
        Console.Write("Enter k : ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter n (n>k) :");
        int n = int.Parse(Console.ReadLine());
        decimal factoriel = 1;

        if ((n > k)&&(n>1))
        {
            //calculatation of N! and K! and their division
            /*for (int i = 1; i <=n; i++)
            {
                decimal factorielN *= i;
            }
            Console.WriteLine("N!={0}", factorielN);

            for (int j = 1; j <=k; j++)
            {
                decimal factorielK *= j;
            }
            Console.WriteLine("K!={0}", factorielK);

            decimal result = factorielN / factorielK;
            Console.WriteLine(result);
             * */

            //optimisation N!/K!=(K+1)*...*N
            Console.Write("N!/K!=");
            for (int j = k+1; j <=n; j++)
            {
                factoriel *= j;
             }
            Console.WriteLine(factoriel);
        }
        else
        {
            Console.WriteLine("Incorrect input : n>k !");     
        }
    }
}
