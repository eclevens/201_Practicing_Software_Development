﻿using System.Numerics;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace practicingSoftwareDevelopment
//Dictionary - Phone Book

/*
 * Goals:
 * Make a phone book that can handle user input.
 * Add person with number
 * Delete person by name
 * Display entire phone book
 * Search phone book by name and return result

    The above goals represent our brainstorming (we didn't make a seperate document since the info needed to be most readily available here.
    Brainstorming was done as a team to determine these goals.
    Olivia: Build Main() code for phone book and helper functions to handle user input and call the rest of the program.
    Mariana: Build functions to add and delete contacts.
    Ella: Build function to display the entire phone book.
    Jacob: Build function to search the phone book for a specific contact.
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
                    SearchPhoneBook(PhoneBook);
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
                Console.WriteLine("");
                CommandPrompt();
                Switcher(PhoneBook);
            }
            else
            {
                Console.WriteLine(name + " is already in your phone book");
                Console.WriteLine("");
                CommandPrompt();
                Switcher(PhoneBook);
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
                Console.WriteLine("");
                CommandPrompt();
                Switcher(PhoneBook);
            }
            else
            {
                PhoneBook.Remove(name);
                Console.WriteLine(name + " removed");
                Console.WriteLine("");
                CommandPrompt();
                Switcher(PhoneBook);
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
            Console.WriteLine("");
            CommandPrompt();
            Switcher(PhoneBook);
        }

        //Function to SearchPhoneBook() --> Jacob
        //take user input for key
        //display phone number at that key
        static void SearchPhoneBook(Dictionary<string, string> PhoneBook)
        {
            Console.WriteLine("Type a name to search for that contact's phone number (case sensitive).");

            string nameSearch = Console.ReadLine();

            if (PhoneBook.ContainsKey(nameSearch))
            {
                Console.WriteLine("The phone number provided for " + nameSearch + " is: {0}", PhoneBook[nameSearch]);

                Console.WriteLine("");
                CommandPrompt();
                Switcher(PhoneBook);
            }
            else
            {
                Console.WriteLine("Unable to find phone number for '" + nameSearch + ",' please try again.");

                SearchPhoneBook(PhoneBook);
            }
        }
    }
}



