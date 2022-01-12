using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PhoneBookConsole
{
    class PhoneBook
    {
        private List<Contact> contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contact) 
        {
            contacts.Add(contact);
        }

        public void RemoveContact(Contact contact)
        {

        }

        private void DisplayContactDetails(Contact contact) 
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }

        }

        public void DisplayContact(string number) 
        {
            var contact = contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null) 
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }

        public void DisplayAllContacts()
        {
            DisplayContactsDetails(contacts);

        }

        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContact = contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContact);
        }
    }
}
