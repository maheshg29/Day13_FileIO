using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to day 13 File IO system");
            Console.WriteLine("Select any one opotion for \n" +
                "1. Add Contact\n" +
                "2. Edit Contact");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            { 
                case 1:
                    AddressBook addressBook = new AddressBook();
                    addressBook = AddressBookRepo.AddContact();
                  break;

                case 2:
                    AddressBook addressBook1 = new AddressBook();
                    addressBook1 = AddressBookRepo.AddContact();
                    AddressBookRepo.Display(addressBook1);
                    addressBook1=AddressBookRepo.EditContact(addressBook1);
                    AddressBookRepo.Display(addressBook1);
                    break;

                default:
                    Console.WriteLine("Select correct option");
                    break;
            }
        }
    }
}
