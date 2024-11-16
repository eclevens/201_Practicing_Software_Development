using System.Numerics;
using System.Xml.Linq;
using System;

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
            var phoneBook = new Dictionary<string, string>
        {
            { "Olivia Croteau", "(518) 925-9554" },
            { "key2", "value2" }

            //code block to determine which function to call --> Olivia
            //take user input to determine which function to take
            //use switch case. options:
            //Add person with number
            //Delete person by name
            //Display entire phone book
            //Search phone book by name and return result
        };
        }

        //Function to addPerson() --> Mariana
        //taking user input for each field and assign to key value pairs
        //dictionary.Add() check if person already exists in dictionary. display confirmation message
        //if person does not exist, display message

        //Function  to deletePerson() --> Mariana
        //take user input for person to be removed
        //dictionary.Remove() using name as key value. display confirmation message
        //if person does not exist, display message

        //Function to displayPhoneBook() --> Ella
        //display a title
        //for loop to iterate through phoneBook
        //log the name (key)
        //log phone number at that name (value)

        //Function to searchPhoneBook() --> Jacob
        //take user input for key
        //display phone number at that key
    }
}
