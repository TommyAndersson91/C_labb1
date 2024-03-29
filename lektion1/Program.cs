﻿using System;

namespace lektion1
{
        class MainClass
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            bool on = true;
                
                while (on)
                {

                    Console.WriteLine
                    (
                    "[1]. Add two numbers"+
                    "\n[2]. Multiply two numbers"+
                    "\n[3]. Sum the numbers between two numbers" +
                    "\n[4]. Add number to memory" +
                    "\n[5]. Clear memory" +
                    "\n[6]. Print calculator contents" +
                    "\n[7]. Quit" +
                    "\nEnter a number 1-7"
                    );

                    var choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            EnterNumbers(calculator);
                            Console.WriteLine("Summan av talen är: " + calculator.SumNumbers());
                            break;
                        case "2":
                            EnterNumbers(calculator);
                            Console.WriteLine("Multiplikationen av talen summeras till: " + calculator.MultiplyNumbers());
                            break;
                        case "3":
                            EnterNumbers(calculator);
                            if (calculator.FirstNumber < calculator.SecondNumber)
                            {
                                Console.WriteLine("Summan av talen mellan tal ett & två är " + calculator.SumInBetween());
                            } else
                            {
                                Console.WriteLine("Första talet behöver vara mindre än det andra");
                                EnterNumbers(calculator); 
                            }
                            break;
                        case "4":
                            Console.WriteLine("Skriv in ett tal som du vill spara i minnet");
                            calculator.NumberInMemory = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Number successfully added to memory");
                            break;
                        case "5":
                            calculator = new Calculator();
                            Console.WriteLine("Number in memory cleared");
                            break;
                        case "6":
                            Console.WriteLine(calculator);
                            break;
                        case "7":
                            Console.WriteLine("Goodbye!");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Skriv in en siffra 1-7");
                            break;
                    }
                }
            
        }

        static void EnterNumbers(Calculator calculator)
        {
            Console.WriteLine("Skriv in tal ett");
            calculator.FirstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in det andra talet");
            calculator.SecondNumber = Int32.Parse(Console.ReadLine());
        }
    }
}


