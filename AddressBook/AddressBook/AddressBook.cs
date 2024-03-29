﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
public  class AddressBook
    {

        List<Contact> addContact = new List<Contact>();
        Dictionary<string, List<Contact>> myDict = new Dictionary<string, List<Contact>>();


    }
    public void AddContact()
    {

        Console.WriteLine("Enter the Address Details");
        Console.WriteLine("1-FirstName 2-LastName 3-Address 4-City 5-State 6-Zip 7-PhoneNumber 8-Email");

        Contact contact1 = new Contact()
        {

            FirstName = Console.ReadLine(),

            LastName = Console.ReadLine(),

            Address = Console.ReadLine(),

            City = Console.ReadLine(),

            State = Console.ReadLine(),

            Zip = Convert.ToInt32(Console.ReadLine()),

            PhoneNumber = Convert.ToInt64(Console.ReadLine()),

            Email = Console.ReadLine(),

        };


        Contact contact2 = new Contact()
        {
            FirstName = "Tomeshwar",

            LastName = "Sahu",

            Address = "Bhilai",

            City = "Mysuru",

            State = "Banglore",

            Zip = 490020,

            PhoneNumber = 82828883837,

            Email = "tomeshwar@com",

        };

        Contact contact3 = new Contact()
        {
            FirstName = "Govind",

            LastName = "Bhatt",

            Address = "Bhilai",

            City = "Mumbai",

            State = "Maharasta",

            Zip = 490021,

            PhoneNumber = 82828883837,

            Email = "govind@gmail.com",

        };
        addContact.Add(contact1);
        addContact.Add(contact2);
        addContact.Add(contact3);
    }

    public void Display()
    {
        foreach (var contact in addContact)
        {
            Console.WriteLine("FirstName:" + " = " + contact.FirstName + "\n" + " " + "LastName:" + " = " + contact.LastName + "\n" + "Address:" + " = " + contact.Address + "\n" + "City:" + " = " + contact.City + "\n " + "State:" + " = " + contact.State + "\n" + "Zip:" + " = " + contact.Zip + " \n" + "PhoneNumber:" + " = " + contact.PhoneNumber + "\n" + "Email:" + " = " + contact.Email + "\n");
        }
    }
    public void Update()
    {
        foreach (var contact in addContact)
        {
            Console.WriteLine("Enter The Number First Name");
            string name = Console.ReadLine();

            if (contact.FirstName.Equals(name))
            {
                Console.WriteLine("1.LastName\n2.Address\n3.City\n4.State\n5.Pin\n6.PhoneNumber\n7.Email ");
                int optionn = Convert.ToInt32(Console.ReadLine());
                switch (optionn)
                {
                    case 1:
                        Console.WriteLine("enter the last name you want to edit : ");
                        contact.LastName = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("enter the address you want to edit :");
                        contact.Address = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("enter the city: ");
                        contact.City = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("enter the state you want to edit :");
                        contact.State = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("enter the email you want to edit :");
                        contact.Email = Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("enter the zip you want to edit :");
                        contact.Zip = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("enter the phone you want to edit :");
                        contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Choose the right option : ");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Name not Exist");
            }
            Display();
        }
    }
    public void Delete()
    {
        Contact delete = new Contact();
        Console.WriteLine("Enter The Number First Name");
        string name = Console.ReadLine();
        foreach (var contact in addContact)
        {
            if (contact.FirstName.Equals(name))
            {
                delete = contact;
            }
        }
        addContact.Remove(delete);
        Display();
    }
    public void AddDetails()
    {
        Console.WriteLine("Enter Unique to name");
        string name = Console.ReadLine();
        foreach (var data in addContact)
        {
            if (data.FirstName.Equals(name))
            {
                Console.WriteLine("This contact exists please enter an unique name to store this data");
            }
            else
            {
                Contact contact4 = new Contact()
                {
                    FirstName = name,
                    LastName = Console.ReadLine(),

                    Address = Console.ReadLine(),

                    City = Console.ReadLine(),

                    State = Console.ReadLine(),

                    Zip = Convert.ToInt32(Console.ReadLine()),

                    PhoneNumber = Convert.ToInt64(Console.ReadLine()),

                    Email = Console.ReadLine(),

                };
                addContact.Add(contact4);
            }
            Display();
        }
    }

    public void AddDictionary(string name)
    {
        foreach (var data in addContact)
        {
            if (addContact.Contains(data))
            {
                if (data.FirstName == name)
                {
                    Console.WriteLine("enter unique name to store the above contact details in a dictionary");
                    string uniqueName = Console.ReadLine().ToLower();
                    myDict.Add(uniqueName, addContact);
                    return;

                }
            }
        }
    }
    public void DisplayDictionary(string name)
    {
        foreach (var data in myDict)
        {
            if (data.Key.Equals(name))
            {
                addContact = data.Value;
            }
            //Console.WriteLine(myDict);
        }
        Display();
    }
    public bool NameExists(string name)
    {
        foreach (var data in addContact)
        {
            if (data.Equals(name))
            {
                return true;
            }
        }
        return false;
    }

}
