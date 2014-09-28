//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
/*
 N=3         
123
234
345

N=4
1234
2345
3456
4567
 * */


using System;

class PrintTable
{
    static void Main()
    {
        int n;

        Console.WriteLine("Enter integer number n (n<20);");
        while ((!int.TryParse(Console.ReadLine(),out n))||(n>20))
        {
            Console.WriteLine("Enter valid integer number n<20 !");
        }
        for (int i = 1; i <=n; i++)
        {
           
            for (int j = i; j <=i+n-1; j++)
            {
            Console.Write("{0} ",j);
            }
            Console.WriteLine();
            
        }
    }
}
