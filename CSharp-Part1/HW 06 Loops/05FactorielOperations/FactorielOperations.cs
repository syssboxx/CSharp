//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;

class FactorielOperations
{
    static void Main()
    {
        Console.Write("Enter k : ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter n (n<k) :");
        int n = int.Parse(Console.ReadLine());
        decimal factorielN = 1;
        decimal result;
        decimal factorielSub = 1;

        if ((n<k)&&(n>1))
        {
            //after subraction calculate  n!*k(k-1)*(k-2)....*(k-n+1)
            for (int i = n; i >= 1; i--)
            {
                factorielN *= i;
            }
            for (int j = k; j >= k-n+1; j--)
            {
                factorielSub *= j;
            }
            result = factorielN * factorielSub ;
            Console.WriteLine("N!*K! / (K-N)! ={0}", result);
        }
        else
        {
            Console.WriteLine("Incorrect input : n<k !");  
        }
    }
}


/* optimisation - calculation with one loop only
for (int l = k; l >= 1; l--)
            {
                if (l <= n)
                { factorielSubstract *= l; }
                if(l>=(k-n+1))
                    factorielSubstract *= l;
            }
            Console.WriteLine(factorielSubstract);
*/