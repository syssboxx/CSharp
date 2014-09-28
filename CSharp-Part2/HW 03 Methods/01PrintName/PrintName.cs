//Write a method that asks the user for his name and prints “Hello, <name>”
//(for example, “Hello, Peter!”). Write a program to test this method.


using System;

class PrintName
{
    static void Main()
    {
        Console.Write("Enter name : ");
        string userName = Console.ReadLine();
        PrintUserName(userName);

    }
    static void PrintUserName(string name)
    {
        Console.WriteLine("Hello, {0}!",name);
    }
}
