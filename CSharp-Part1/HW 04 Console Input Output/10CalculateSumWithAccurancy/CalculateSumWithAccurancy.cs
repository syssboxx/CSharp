//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class CalculateSumWithAccurancy
{
    static void Main()
    {
        //float firstMember = 1;
        float nextMember;
        
        //int members = 5;
        //float sum;
        float memberSum = 0;
        float lastMemberSum = memberSum;
        float i = 1;
        //float accuracy = 0.001f;

        /*
        Console.Write("\nThe sum of {0}",firstMember);
        for (float i = 2; i <= members; i++)
        {
            nextMember = 1 / i;
            
            if (i % 2 == 0)
            {
                Console.Write("+{0}", nextMember);
            }
            else 
            {
                nextMember=nextMember*(-1);
                Console.Write("{0}", nextMember);
            }
            memberSum += nextMember;
            
        }
        sum = firstMember + memberSum;
        Console.WriteLine("={0}",sum);
        **/

        /*
        //Console.Write("\nThe sum of " );
        for (float i = 1; i <= members; i++)
        {
            nextMember = 1 / i;

            if ((i % 2 != 0)&&(i!=1))
            {
                nextMember = nextMember * (-1);
                //Console.Write("{0}", nextMember);
            }
            else
            {
                
                //Console.Write("+{0}", nextMember);
            }
            Console.WriteLine();
            Console.WriteLine(nextMember);
            Console.WriteLine(memberSum);
            lastMemberSum = memberSum;
            memberSum += nextMember;
            //Console.WriteLine(memberSum);
        }
        //Console.WriteLine("={0}",memberSum);
        */

        //Console.Write("\nThe sum of ");
        do
        {
            nextMember = (1 / i);

            if ((i%2 != 0)&&(i!=1))
            {
                nextMember = nextMember * (-1);
            }
            
            
            lastMemberSum = memberSum;
            memberSum += nextMember;
            i++;

            Console.WriteLine("member {0} : {1}", i,nextMember);
          }
        while ((Math.Abs(memberSum - lastMemberSum)) >= 0.001) ;
        Console.WriteLine();
        Console.WriteLine("The sum is {0}",memberSum);
    }
}
