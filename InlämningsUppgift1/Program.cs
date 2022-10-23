using InlämningsUppgift1.Models;
using System.Collections.Generic;
using System.IO;

var contacts = new List<Contact>();

do
{
    Console.Clear();
    Console.WriteLine("##### ADDRESS BOOK #####");
    Console.WriteLine("1.View Adress book");
    Console.WriteLine("Q.Exit application");
    var option = Console.ReadLine();

    if (String.IsNullOrEmpty(option))
    {
        Console.WriteLine("You must enter an option");
        Console.ReadKey();
    }
    else
    {
        switch (option)

        {
            case "1":

                Console.Clear();
                Console.WriteLine("##### CONTACTS - ADRESS BOOK #####");
                foreach (var item in contacts)
                    Console.WriteLine($" {item.FullName}, {item.Address}");

                break;

            case "2":

                Console.Clear();
                Console.WriteLine("##### CONTACTS - ADRESS BOOK #####");

                var contact = new Contact();
                 
                Console.Write("First name: ");
                contact.FirstName = Console.ReadLine();

                Console.Write("Last Name: ");
                contact.LastName = Console.ReadLine();


                Console.Write("Street name: ");
                contact.Street = Console.ReadLine();


                Console.Write("City: ");
                contact.City = Console.ReadLine();

                contacts.Add(contact);
                Console.WriteLine("Contact added to adress book");
                break;

            case "Q":
                break;

        }
    } while (true);