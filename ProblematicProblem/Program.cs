using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;

namespace ProblematicProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

            bool correctResponse = false;
            while (!correctResponse)
            {
                Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
                string response = (Console.ReadLine());
                if (response == "yes")
                {
                    correctResponse = true;
                }
                else if (response == "no")
                {
                }
                else
                {
                    Console.WriteLine("Not an option");
                }
            }
            Console.WriteLine();
            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is your age? ");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine();
            bool seeList = false;
            while (!seeList)
            {
                Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
                string response2 = Console.ReadLine();
                if (response2 == "Sure")
                {
                    seeList = true;
                }
            }
            if (seeList)
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }
                Console.WriteLine();
                bool addToList = true;
                while (addToList)
                {
                    Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                    string response = Console.ReadLine();
                    if (response == "yes")
                    {
                        Console.Write("What would you like to add? ");
                        string userAddition = Console.ReadLine();
                        activities.Add(userAddition);
                        foreach (string activity in activities)
                        {
                            Console.Write($"{activity} ");
                            Thread.Sleep(250);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Would you like to add more? yes/no: ");
                        string response3 = Console.ReadLine();
                        if (response3 == "yes")
                        {

                        }
                        else if (response3 == "no")
                        {
                            addToList = false;
                        }
                        else
                        {
                            Console.WriteLine("not an option");
                        }
                    }
                    else if (response == "no")
                    {
                        addToList = false;
                    }
                    Console.WriteLine();



                }
            }
                bool cont = true;
                while (cont)
                {
                    Console.Write("Connecting to the database");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }
                    Console.WriteLine();
                    Console.Write("Choosing your random activity");
                    for (int i = 0; i < 9; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }
                    Console.WriteLine();
                    int randomNumber = rng.Next(activities.Count);
                    string randomActivity = activities[randomNumber];
                    if (userAge < 21 && randomActivity == "Wine Tasting")
                    {
                        Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                        Console.WriteLine("Pick something else!");
                        activities.Remove(randomActivity);
                        randomNumber = rng.Next(activities.Count);
                        randomActivity = activities[randomNumber];
                    }
                    Console.Write($"Ah got it! {randomActivity}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                    Console.WriteLine();
                    string response4 = Console.ReadLine();
                    if (response4 == "Keep")
                    {
                        Console.WriteLine("Glad you are happy with your activity!");
                        cont = false;
                    }
                    else if (response4 == "Redo")
                    {
                        Console.WriteLine("Trying again");
                    }
                    else
                    {
                        Console.WriteLine("not an option");
                    }
                }
            }
        }
    }


    
