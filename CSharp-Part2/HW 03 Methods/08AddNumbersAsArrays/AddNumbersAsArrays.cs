//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
//Each of the numbers that will be added could have up to 10 000 digits.

//TO TEST
//

using System;

class AddNumbersAsArrays
{
    static void Main()
    {
        //byte [] firstArray={1,2,3,4,5,6};
        //byte[] secondArray = { 2, 4, 6, 7 };

        //to test : addition =1
        byte[] firstArray = {9,9,9};
        byte[] secondArray = {1};

        byte [] sumOfArrays;

        //reverse elements in the array
        firstArray=ReverseArray(firstArray);
        secondArray=ReverseArray(secondArray);

        PrintArray(firstArray);
        PrintArray(secondArray);

        Console.WriteLine("Sum :");
        
        //addition and reverse the result
        sumOfArrays = AddNumbersOfArray(firstArray, secondArray);

        PrintArray(sumOfArrays);

        Console.WriteLine();
        Console.WriteLine("Reversed sum of numbers : ");
        PrintArray(ReverseArray(sumOfArrays));
    }

    static void PrintArray (byte[] array)
    {
        for (int i = 0; i<array.Length; i++)
        {
            Console.Write(array[i]+ " ");
        }
        Console.WriteLine();
    }

    static byte[] ReverseArray(byte [] array)
    {
        byte[] reversedArray=new byte [array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            reversedArray[i] = array[array.Length - i - 1];
            //Console.Write(reversedArray[i]);
        }
        //Console.WriteLine();
        return reversedArray;
       
    }


    static byte[] AddNumbersOfArray(byte[] array1, byte[] array2)
    {
        int lengthMin = Math.Min(array1.Length, array2.Length);
        int lengthMax = Math.Max(array1.Length, array2.Length);
        int addition=0;

        
        byte[] resultArray = new byte[lengthMax];

        for (int i = 0; i < lengthMax; i++)
        {
            if (i<lengthMin)
            {
                int temp = System.Convert.ToInt32(array1[i]) + System.Convert.ToInt32(array2[i])+addition;
                if (temp>=10)
                {
                    addition = 1;
                    temp = temp % 10;
                }
                else
                {
                    addition = 0;
                }
                resultArray[i] = System.Convert.ToByte(temp);
            }
            else
            {
                if (array1.Length>array2.Length)
                {
                    int temp = System.Convert.ToInt32(array1[i]) + addition;
                    if (temp >= 10)
                    {
                        addition = 1;
                        temp = temp % 10;
                    }
                    else
                    {
                        addition = 0;
                    }
                    resultArray[i] = System.Convert.ToByte(temp);
                }
                else
                {
                    int temp = System.Convert.ToInt32(array2[i]) + addition;
                    if (temp >= 10)
                    {
                        addition = 1;
                        temp = temp % 10;
                    }
                    else
                    {
                        addition = 0;
                    }
                    resultArray[i] = System.Convert.ToByte(temp);
                }
            }
        }
        // if sum of next last element is >10 we have to add a new cell in the array
        if (addition==1) 
        {
            //resultArray[lengthMax] = 1;
            byte[] resizedArray = new byte[lengthMax + 1];
            for (int i = 0; i < resultArray.Length; i++)
            {
                resizedArray[i] = resultArray[i];
            }
            resizedArray[lengthMax] = 1;
            return resizedArray;
        }

        return resultArray;
    }

}
