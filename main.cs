
// Created by: Zaida Hammel
// Created on: March 2022
//
// This program accepts user input
using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int streetNumber;
        string streetName;

        Console.WriteLine("This program puts together a user's address.");
        Console.WriteLine("");
        Console.Write("Enter your street number: ");
        streetNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your street name: ");
        streetName = Console.ReadLine();


        Console.WriteLine("");
        Console.WriteLine("Your address is: " + streetNumber + " " + streetName + ".");

        Console.WriteLine("\nDone.");
    }
}