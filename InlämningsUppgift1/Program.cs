using InlämningsUppgift1.Models;


var contacts = new List<Contact>();

do
{
    Console.Clear();
    Console.WriteLine("##### ADDRESS BOOK #####");
    Console.WriteLine("1.View Adress book");
    Console.WriteLine("2.Add new Contact");
    Console.WriteLine("Q.Exit application");
    Console.Write("Choose one option: ");
    var option = Console.ReadLine();

    if (string.IsNullOrEmpty(option))
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
                    Console.WriteLine($"{item.FullName}, {item.Address}");

                break;

            case "2":

                Console.Clear();
                Console.WriteLine("##### CONTACTS - ADRESS BOOK #####");

                var contact = new Contact();

                Console.Write("First name: ");
                contact.FirstName = Console.ReadLine();

                Console.Write("Last name: ");
                contact.LastName = Console.ReadLine();


                Console.Write("Street name: ");
                contact.StreetName = Console.ReadLine();

                Console.Write("Postal code: ");
                contact.PostalCode = Console.ReadLine();


                Console.Write("City: ");
                contact.City = Console.ReadLine();

                contacts.Add(contact);
                Console.WriteLine("Contact added to address book");
                break;

            case "Q":
                Environment.Exit(0);    
                break;
        }
        }
    Console.ReadKey();
    } while (true) ;

