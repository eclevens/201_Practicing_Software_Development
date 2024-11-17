using System.Numerics;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace practicingSoftwareDevelopment
//Dictionary - Phone Book

/*
 * Goals:
 * Make a phone book
 * Add person with number
 * Delete person by name
 * Display entire phone book
 * Search phone book by name and return result
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare dictionary for phoneBook
            var PhoneBook = new Dictionary<string, string>
            {
                { "Olivia", "(518) 925-9554" },
                { "Ella", "(302) 723-4323" }
            };


            Console.WriteLine("Welcome to your Phone Book!");
            CommandPrompt();
            Switcher(PhoneBook);
            
        }

        //Function for command prompts
        static void CommandPrompt()
        {
            Console.WriteLine("To add a new contact, type 'add'");
            Console.WriteLine("To remove a contact, type 'remove'");
            Console.WriteLine("To view the entire phone book, type 'view'");
            Console.WriteLine("To search for a contact by name, type 'search'");
        }

        //Switch function to determine which function to call --> Olivia
        //take user input
        //use switch case. options:
            //Add person with number
            //Delete person by name
            //Display entire phone book
            //Search phone book by name and return result
        static void Switcher(Dictionary<string, string> PhoneBook)
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "add":
                    AddPerson(PhoneBook);
                    break;

                case "remove":
                    DeletePerson(PhoneBook);
                    break;

                case "view":
                    DisplayPhoneBook(PhoneBook);
                    break;

                case "search":
                    //SearchPhoneBook();
                    break;

                default:
                    Console.WriteLine("Command not found");
                    CommandPrompt();
                    Switcher(PhoneBook);
                    break;
            }
        }

        //Function to AddPerson() --> Mariana
        //taking user input for each field and assign to key value pairs
        //dictionary.Add() check if person already exists in dictionary. display confirmation message
        //if person does not exist, display message
        static void AddPerson(Dictionary<string, string> PhoneBook)
        {
            Console.WriteLine("Insert their name here");
            string name = Console.ReadLine();

            if (!PhoneBook.ContainsKey(name))
            {
                Console.WriteLine("Insert their number here");
                string number = Console.ReadLine();
                PhoneBook.Add(name, number);
                Console.WriteLine(name + " is added");
            }
            else
            {
                
                Console.WriteLine(name + " is already in your phone book");
            }

        }

        //Function  to DeletePerson() --> Mariana
        //take user input for person to be removed
        //dictionary.Remove() using name as key value. display confirmation message
        //if person does not exist, display message

        static void DeletePerson(Dictionary<string, string> PhoneBook)
        {
            Console.WriteLine("Type a name to delete their contact.");
            string name = Console.ReadLine();

            if (!PhoneBook.ContainsKey(name))
            {
                Console.WriteLine(name + " is not found.");
            }
            else
            {
                PhoneBook.Remove(name);
                Console.WriteLine(name + " removed");
            }
        }

        //Function to DisplayPhoneBook() --> Ella
        //display a title
        //for loop to iterate through phoneBook
        //log the name (key)
        //log phone number at that name (value)
        static void DisplayPhoneBook(Dictionary<string, string> PhoneBook)
        {
            Console.WriteLine("Viewing complete phonebook.");
            foreach (var entry in PhoneBook)
            {
                string name = entry.Key; //get name
                string number = entry.Value; //get number
                //now display it
                Console.WriteLine("Name: " + name + " Number: " + number);
            }
        }

        //Function to SearchPhoneBook() --> Jacob
        //take user input for key
        //display phone number at that key
    }
}



