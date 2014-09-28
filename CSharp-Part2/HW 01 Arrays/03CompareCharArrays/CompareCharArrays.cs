using System;


namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            Console.WriteLine("How many elements will have the arrays (n1,n2) :");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            char[] charArray1 = new char[n1];
            char[] charArray2 = new char[n2];

            bool isEqual = false;
            bool isFirst = false;
            bool isSecond= false;

            int minLength = 0;

            //initalize second char array
            Console.WriteLine("Fill first array :");
            for (int i = 0; i < charArray1.Length; i++)
            {
                charArray1[i] = Convert.ToChar(Console.ReadLine());
            }

            //initalize second char array
            Console.WriteLine("Fill second array :");
            for (int i = 0; i < charArray2.Length; i++)
            {
                charArray2[i] = Convert.ToChar(Console.ReadLine());
            }

            //compare the arrays
            if (charArray1.Length==charArray2.Length)
            {
                minLength = charArray1.Length;
                isEqual = true;
            }
            else if (charArray1.Length<charArray2.Length)
            {
                minLength = charArray1.Length;
                isFirst = true;
            }
            else
            {
                minLength = charArray2.Length;
                isSecond = true;
            }
            for (int i = 0; i < minLength; i++)
            {
                if ((int)charArray1[i] != (int)charArray2[i])
                {
                    isEqual = false;
                    isFirst = false;
                    isSecond = false;

                    if ((int)charArray1[i] < (int)charArray2[i])
                    {
                        isFirst = true;
                    }
                    else
                    {
                        isSecond = true;
                    }
                    break;
                }
                
            }
            
            
            if (isEqual)
            {
                Console.WriteLine("The two arrays are lexicographically equals");
            }
            else if (isFirst)
            {
                Console.WriteLine("The first array is lexicographically first");
            }
            else if (isSecond)
            {
                Console.WriteLine("The first array is lexicographically second");
            }

            
        }
    }
}
