using System;

//A company has name, address, phone number, fax number, web site and manager.The manager has first name, last name, age and a phone number.
//• Write a program that reads the information about a company and its manager and prints it back on the console.



//info

//input



//Company name: Telerik Academy
//Company address: 31 Al.Malinov, Sofia
//Phone number: +359 888 55 55 555 
//Fax number:  
//Web site: http://telerikacademy.com/ 
//Manager first name: Nikolay
//Manager last name: Kostov
//Manager age: 25 
//Manager phone: +359 2 981 981 


//Input
//•You will each piece of information about the company on a separate line, in the same order as in the example i.Company name
//ii.Company address
//iii.Phone number
//iv.Fax number
//v.Web site
//vi.Manager first name
//vii.Manager last name
//viii.Manager age
//ix.Manager phone



//Output
//•Print the information the same way as shown in the sample test.Make sure that you print "(no fax)" if an empty line is passed as fax number.


namespace _02CompanyInfo
{
    class CompanyInfo
    {
        static void Main()
        {
            Console.Write("Company Name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company Address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Fax number: ");
            string faxNumber = Console.ReadLine();
            if (faxNumber == "")
            {
                faxNumber = "No Fax";
            }
            Console.Write("Web Site: ");
            string webSite = Console.ReadLine();
            Console.Write("Manager First Name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Manager Last Name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Manager Age: ");
            int managerAge = int.Parse(Console.ReadLine());
            Console.Write("Manager Phone: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine("{0}\nAddress: {1}\nTel.: {2}\nFax Number: {3}\nWebSite: {4}\nManager FirstName: {5}\nManager Last Name: {6}\nManager Age: {7}\n Manager Phone: {8}\n", companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerAge, managerPhone);
          
        }
               
    }
}
