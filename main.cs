
// Created by: Zaida Hammel
// Created on: March 2022
// 
// This function states user's address input.

using System;

class Program {
  public static void Main(string[] args)
    {
        // This function states user's street name and street number.
        string streetName;
        int streetNumber;

        Console.WriteLine("This program will retell you your street name and street number.");
        Console.WriteLine("");

        Console.Write("Enter your street name: ");
        streetName = Console.ReadLine();
        Console.Write("Enter your street number: ");
        streetNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Your address is: " + streetName + " " + streetNumber + ".");

        Console.WriteLine("\nDone.");
    }
}