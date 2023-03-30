using System;
using System.Collections.Generic;

namespace Horse_betting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE CODE-TUCKY DERBY!!!!!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Please enter your name!");
            string Name = Console.ReadLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Welcome {Name}!");
            Console.WriteLine("How many credits would you like to start with?");
            int Credit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{Name} you have a current balance of {Credit} credits!");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("***Please keep your capslock on for proper gaming experience***");
            Console.WriteLine("---------------------------------------------");

            menuecontrol.game(Credit);


            Console.WriteLine("You're all out of credits! Game Over!");
            Console.WriteLine("Gambling Problem? Call 1-800-522-4700");
            if(menuecontrol.Playagain())
            {
                Console.WriteLine($"please enter new credits");
                Credit = Convert.ToInt32(Console.ReadLine());
                menuecontrol.game(Credit);
            }
            
        } 

        
    }   
    
    
}   




