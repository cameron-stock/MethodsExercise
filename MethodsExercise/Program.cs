﻿using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1

            Console.WriteLine("Hello, what is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hello, {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{userName}, what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Here is your profile!");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Band: {band}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
        }
    }
}
