//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console. 
//Find in MSDN how to use System.IO.File.ReadAllText(…). 
//Be sure to catch all possible exceptions and print user-friendly error messages.


using System;
using System.IO;
using System.Security;

class ReadAndPrintFromFile
{
    static void Main()
    {
        string path = @"C:\WINDOWS\win.ini";
        
        try
        {
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("You hadn't specify a path.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path is too long.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found.");
        }
        catch (IOException)
        {
            Console.WriteLine("I/O error during file opening");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You don't have required permission to open this file");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The entered path is in invalid format");
        }
        catch (SecurityException)
        {
            Console.WriteLine("You don't have required permission to open this file");
        }
        

    }
}