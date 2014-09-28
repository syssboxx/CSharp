//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers 
//associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;
class BankAccountInformation
{
    static void Main()
    {
        string holderFirstName="";
        string holderMiddleName="";
        string holderLastName="";
        string holderName = holderFirstName +" "+ holderMiddleName +" "+holderLastName;
        decimal balance;
        string bankName;
        string iban;
        string bicCode;
        ulong creditCardNumber1;
        ulong creditCardNumber2;
        ulong creditCardNumber3;
    }
}