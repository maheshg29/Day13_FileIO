using System;
using System.Collections.Generic;
using System.IO;
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
                "2. Edit Contact\n" +
                "3. Write Contact to Text file (for UC-13)\n" +
                "4. Read Data From Text file(for UC-13)");
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
                case 3:
                    AddressBookRepo.WriteDataToTextFile();
                    break;
                case 4:
                    AddressBookRepo.ReadDataToTextFile();
                    break;

                default:
                    Console.WriteLine("Select correct option");
                    break;
            }
        }
    }
}
