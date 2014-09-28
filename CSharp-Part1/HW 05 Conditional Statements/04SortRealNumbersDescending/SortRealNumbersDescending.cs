//Sort 3 real values in descending order using nested if statements.


using System;

class SortRealNumbersDescending
{
    static void Main()
    {

        double a, b, c;
        double biggest=0;
        double smallest=0;
        double middle=0;

        Console.WriteLine("Enter 3 real numbers (on separate lines) :");
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());


        //biggest = a;
        if ((a == b) && (a == c) && (b == c))
        {
            Console.WriteLine("The numbers are equal");
        }
        else
        {
            if (a > b)
            {
                if (a > c)
                {
                    if (b > c) //a<b<c 312
                    {
                        biggest = a;
                        smallest = c;
                        middle = b;
                    }
                    else if (b<c) //321
                    {
                        biggest = a;
                        smallest = c;
                        middle = b;
                    }
                }
                else if (a < c) 
                {
                    if (b > c) //321
                    {
                        biggest = c;
                        smallest = b;
                        middle = a;
                    }
                    else if (b<c) //312
                    {
                        biggest = a;
                        smallest = b;
                        middle = c;
                    }
                }

            }
            else // (a<b) 
            {
                if (c > b) //123
                {
                    biggest = c;
                    smallest = a;
                    middle = b;
                 }
                else if (c<b)
                {
                    biggest = b; 
                    if (c > a)  //132
                    {
                        smallest = a;
                        middle = c;
                    }
                    else if (c<a)//c<a 231
                    {
                        smallest = c;
                        middle = a;
                    }
                    
                }

            }
        }
        Console.WriteLine("Numbers in Descending order : {0} {1} {2}", biggest, middle, smallest);
    }
}
