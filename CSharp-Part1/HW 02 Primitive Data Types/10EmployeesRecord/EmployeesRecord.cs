//A marketing firm wants to keep record of its employees. Each record would have the following characteristics – first name, family name, age, gender (m or f), 
//ID number, unique employee number (27560000 to 27569999). Declare the variables needed to keep the information for a single employee using appropriate data 
//types and descriptive names.

using System;

class EmployeesRecord
{
    static void Main()
    {
        // the name is not real
        string firstName="Ivan";
        string famillyName="Ivanov";
        byte age=30;
        char gender='m';
        string idNumber="8205120466"; //egn it's possible to start with 0
        uint uniqueEmployeeNumber=27560030;
        Console.WriteLine("Information of the employee - name :{0} {1}, {2} years old, {3}, ID {4}, unique emplyee number : {5}", firstName,famillyName,age,gender, idNumber,uniqueEmployeeNumber );
    }
}
