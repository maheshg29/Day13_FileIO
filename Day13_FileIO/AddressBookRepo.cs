using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_FileIO
{
    public class AddressBookRepo
    {
        public static AddressBook AddContact()
        {
            AddressBook contact = new AddressBook();
            Console.WriteLine("Enter First name");
            contact.FirstName=Console.ReadLine();
            Console.WriteLine("Enter Last name");
            contact.LastName=Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address=Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City=Console.ReadLine();
            Console.WriteLine("Enter Zip Code");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email Address");
            contact.Email = Console.ReadLine();
            return contact;

        }

        public static void Display(AddressBook addressBook)
        {
            Console.WriteLine(addressBook.FirstName+" "+addressBook.LastName +"\n"+ addressBook.Address + " " + addressBook.City + " " + addressBook.Zip + "\n" + addressBook.PhoneNumber + " " + addressBook.Email);
        }

        public static AddressBook EditContact(AddressBook addressBook)
        {
            Console.WriteLine("Which parameter u want to Edit\n" +
                "1 first name\n2 Last Name\n3 Address\n4 City\n5 Zip Code\n 6 Phone Number\n 7 Email");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter New First name");
                    addressBook.FirstName = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter New Last name");
                    addressBook.LastName = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Enter New Address");
                    addressBook.Address = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Enter New City");
                    addressBook.City = Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Enter New Zip Code");
                    addressBook.Zip = Convert.ToInt32(Console.ReadLine());
                    break;
                case 6:
                    Console.WriteLine("Enter New Phone Number");
                    addressBook.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                    break;
                case 7:
                    Console.WriteLine("Enter New Email");
                    addressBook.Email = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please Select Correcct option");
                    break;
            }
            return addressBook;

        }
    }
}
