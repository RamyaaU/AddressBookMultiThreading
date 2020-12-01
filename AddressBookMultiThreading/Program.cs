using System;

namespace AddressBookMultiThreading
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Address Book Multi Threading!");
            ///Creating instance class of AddressBookRepository class.
            AddressBookRepository repository = new AddressBookRepository();
            ///Retrieve all the contact details from the DB
            repository.RetrieveAllContactDetails();
        }
    }
}
