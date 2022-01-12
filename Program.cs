using System;

namespace PhoneBookConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new PhoneBook();

            
                Console.WriteLine("Hello for the console phonebook app");
                Console.WriteLine("Select operation");
                Console.WriteLine("1 Add contact");
                Console.WriteLine("2 Display contact by number");
                Console.WriteLine("3 View all contacts");
                Console.WriteLine("4 Search for contacts for a given name");
                Console.WriteLine("x to terminate the application");
       
                var userInput = Console.ReadLine();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.Write("Input contact name: ");
                        var the_name = Console.ReadLine();
                        Console.Write("Input contact number: ");
                        var the_number = Console.ReadLine();
                        Contact contact = new Contact(the_name, the_number);
                        phoneBook.AddContact(contact);
                        Console.WriteLine("Contact successfully added.");
                        
                        break;
                    case "2":
                        Console.Write("Input contact number: ");
                        var number = Console.ReadLine();
                        phoneBook.DisplayContact(number);
                        break;
                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;
                    case "4":
                        Console.Write("Input contact name: ");
                        var name = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(name);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Select valid operation");
                        break;

                }
                Console.Write("Select new operation: ");
                userInput = Console.ReadLine();
            }
           


            
        }
    }
}
