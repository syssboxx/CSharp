//Write a program that downloads a file from Internet 
//(e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory.
//Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class DownloadFileFromInternet
{
    static void Main()
    {
        string address = "http://www.devbg.org/img/Logo-BASD.jpg"; 
        string filename = @"..\..\download\Logo-BASD.jpg";

        //Download File Synchronously
        using (WebClient Client = new WebClient())
        {
            try
            {
                Client.DownloadFile(address, filename);
                Console.WriteLine("File download completed\n\nFile downloaded in DOWLOAD directory of the current project");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The address parameter is null.");
            }
            catch (WebException)
            {
                Console.WriteLine("An error occurred while downloading data or empty filename or the file does not exist.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }
        }

    }
}
