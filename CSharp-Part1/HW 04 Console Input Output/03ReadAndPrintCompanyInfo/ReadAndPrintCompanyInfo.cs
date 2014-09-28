//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. 
//Write a program that reads the information about a company and its manager and prints them on the console.

using System;

class ReadAndPrintCompanyInfo
{
    static void Main()
    {
        string companyName;
        string companyAddress;
        long companyPhoneNumber;
        long companyFaxNumber;
        string companyWebSite;
        string manager;
        string managerFirstName;
        string managerLastName;
        byte managerAge;
        long managerPhoneNumber;

        //read the information from the console
        Console.Write("Enter a company name : ");
        companyName = Console.ReadLine();

        Console.Write("Enter the company's address : ");
        companyAddress = Console.ReadLine();

        // i assume the number is composed by phone code and number and follow the model (0###) ### ### ### 
        Console.Write("Enter the company's phone number :  "); 
        companyPhoneNumber = long.Parse(Console.ReadLine());

        Console.Write("Enter the company's fax number :  ");
        companyFaxNumber = long.Parse(Console.ReadLine());

        Console.Write("Enter the company's web site : ");
        companyWebSite = Console.ReadLine();

        Console.Write("Enter the manager's first name : ");
        managerFirstName = Console.ReadLine();
        Console.Write("Enter a the manager's last name : ");
        managerLastName = Console.ReadLine();
        manager = managerFirstName +" "+ managerLastName;

        Console.Write("Enter a the manager's age : ");
        managerAge=byte.Parse(Console.ReadLine());

        //i assume it's a gsm number following the model (0###) ## ## ##
        Console.Write("Enter a the manager's gsm phone number :  ");  
        managerPhoneNumber=long.Parse(Console.ReadLine());

        Console.WriteLine();

        //print the information 
        Console.WriteLine("Welcome to {0}!\nWe're glad to accept you in our office in {1}.\n"+
            "You can contact us by phone number {2:(0###) ### ### ### } or by fax number {3:(0###) ### ### ### }."+
            "If you want to find more information about our services please visit our web site : {4}",companyName,companyAddress,companyPhoneNumber,companyFaxNumber,companyWebSite);
        Console.WriteLine("You can contact our manager, {0},({1} years old) on his personal gsm number {2:(0###) ## ## ## }", manager, managerAge, managerPhoneNumber);
        Console.WriteLine("Thank you for your attention!");
    }
}