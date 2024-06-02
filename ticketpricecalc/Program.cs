﻿using System;

namespace MovieTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            double ticketPrice;
            if (age >= 65 || age <= 12)
            {
                ticketPrice = 7.0;
            }
            else
            {
                ticketPrice = 10.0;
            }

            Console.WriteLine($"You are a ticket price of GHC{ticketPrice}");
        }
    }
}
