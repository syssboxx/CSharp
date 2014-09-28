//* Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
//	0  "Zero"
//	273  "Two hundred seventy-three"
//  400  "Four hundred"
//  501  "Five hundred and one"
//  711  "Seven hundred and eleven"


using System;

class ConvertNumberToText
{
    static void Main()
    {
        Console.WriteLine("Enter a number in the range [0...999] :");
        ushort number;
        
        while (!ushort.TryParse(Console.ReadLine(),out number)||(number>999))
        {
            Console.WriteLine("Enter a valid number in the range [0...999]");
        }

        int digit1 = number % 10;
        int digit2 = (number / 10)%10;
        int digit3 = number / 100;
        
        Console.Write("The number is ");

        //numbers : 0-20
        if (number<20 )
        {
            switch (number)
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                case 10: Console.WriteLine("ten"); break;
                case 11: Console.WriteLine("eleven"); break;
                case 12: Console.WriteLine("twelve"); break;
                case 13: Console.WriteLine("thirteen"); break;
                case 14: Console.WriteLine("fourteen"); break;
                case 15: Console.WriteLine("fifteen"); break;
                case 16: Console.WriteLine("sixteen"); break;
                case 17: Console.WriteLine("seventeen"); break;
                case 18: Console.WriteLine("eighteen"); break;
                case 19: Console.WriteLine("ninetten"); break;
                default: Console.WriteLine("no such number"); break;

            }
        }
        //numbers : 21-999
        else if ((number>=20)&&(number<=999)) 
        {
            if (digit3 != 0)
            {

                switch (digit3)
                {
                    case 1: Console.Write("one hundred "); break;
                    case 2: Console.Write("two hundred "); break;
                    case 3: Console.Write("three hundred "); break;
                    case 4: Console.Write("four hundred "); break;
                    case 5: Console.Write("five hundred "); break;
                    case 6: Console.Write("six hundred "); break;
                    case 7: Console.Write("seven hundred "); break;
                    case 8: Console.Write("eight hundred "); break;
                    case 9: Console.Write("nine hundred "); break;
                    default: Console.WriteLine("no such number"); break;
                }
             
            }

            if ((digit2 != 1) && (digit2 != 0)) 
            {
                Console.Write("and ");
                switch (digit2)
                    {
                        //case 1: break;
                        case 2: Console.Write("twenty"); break;
                        case 3: Console.Write("thirty"); break;
                        case 4: Console.Write("forty"); break;
                        case 5: Console.Write("fifty"); break;
                        case 6: Console.Write("sixty"); break;
                        case 7: Console.Write("seventy"); break;
                        case 8: Console.Write("eighty"); break;
                        case 9: Console.Write("ninety"); break;
                        default: Console.Write("no such number"); break;
                    }
                if (digit1 != 0)
                {
                    switch (digit1)
                    {
                        case 1: Console.Write(" and one"); break;
                        case 2: Console.Write("-two"); break;
                        case 3: Console.Write("-three"); break;
                        case 4: Console.Write("-four"); break;
                        case 5: Console.Write("-five"); break;
                        case 6: Console.Write("-six"); break;
                        case 7: Console.Write("-seven"); break;
                        case 8: Console.Write("-eight"); break;
                        case 9: Console.Write("-nine"); break;
                        default: Console.WriteLine("no such number"); break;
                    }
                }
            }
            
            else if (digit2==1)
            {
                Console.Write(" and ");
                switch (digit1)
                {
                    case 0: Console.Write("ten"); break;
                    case 1: Console.Write("eleven"); break;
                    case 2: Console.Write("twelve"); break;
                    case 3: Console.Write("thirteen"); break;
                    case 4: Console.Write("forteen"); break;
                    case 5: Console.Write("fifteen"); break;
                    case 6: Console.Write("sixteen"); break;
                    case 7: Console.Write("seventeen"); break;
                    case 8: Console.Write("eighteen"); break;
                    case 9: Console.Write("nineteen"); break;
                    default: Console.WriteLine("no such number"); break;
                }
            }
            else if (digit2 == 0)
            {
                //Console.Write(" and ");
                switch (digit1)
                {
                    case 1: Console.Write(" and one"); break;
                    case 2: Console.Write(" and two"); break;
                    case 3: Console.Write(" and three"); break;
                    case 4: Console.Write(" and four"); break;
                    case 5: Console.Write(" and five"); break;
                    case 6: Console.Write(" and six"); break;
                    case 7: Console.Write(" and seven"); break;
                    case 8: Console.Write(" and eight"); break;
                    case 9: Console.Write(" and nine"); break;
                    default: Console.WriteLine("no such number"); break;
                }
            }
            
            Console.WriteLine();      
        }
    }
}

