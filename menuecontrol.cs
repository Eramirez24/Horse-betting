using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horse_betting
{
    public class menuecontrol
    {
        public static int Bet()
        {
            Console.WriteLine($"How much would you like to bet?");
            int Bet_amount = Convert.ToInt32(Console.ReadLine());
            var message = $"You bet {Bet_amount}. Is this correct? (Y/N)";
            if (!Confirm(message))
            {
                Bet_amount = Bet();
            }
            return Bet_amount;

        }





        public static int Picknum()
        {
            Console.WriteLine("Select your horse!");
            int Horse_num = Convert.ToInt32(Console.ReadLine());
            var message = $"You selected Horse {Horse_num}. Is this correct? (Y/N)";
            
            if (!Confirm(message))
            {
                Horse_num = Picknum();
            }
            return Horse_num;
            
        }





        public static bool Confirm(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            switch (input)
            {
                case "Y":
                    Console.WriteLine("You have Confirmed your decision!");
                    return true;

                default:
                    return false;


            }
        }



        

        public static bool Playagain()
        {
            Console.WriteLine("Would you like to play again? (Y/N)");
            string Player_input = Console.ReadLine();

            if (Player_input == "Y")
            {
                return true;
            }
            else 
            {
                return false;
            }
            
        }






        public static void game(int Credit)
        {
            bool start = true;
            while (start)
            {
                // presenting the race horses
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Here are the Horses for todays race!");
                Horses horse_1 = new Horses(1, "Secretariat");
                Horses horse_2 = new Horses(2, "Barbaro");
                Horses horse_3 = new Horses(3, "American Pharoah");
                Horses horse_4 = new Horses(4, "Seabiscuit");
                Horses horse_5 = new Horses(5, "Man O' War");
                Console.WriteLine(horse_1);
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine(horse_2);
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine(horse_3);
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine(horse_4);
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine(horse_5);
                Console.WriteLine("---------------------------------------------");
                var horselist = new List<Horses>();
                horselist.Add(horse_1);
                horselist.Add(horse_2);
                horselist.Add(horse_3);
                horselist.Add(horse_4);
                horselist.Add(horse_5);



                //Selecting the horse

                var Horse_num = menuecontrol.Picknum();
                // varifying that number 1-5 was selected
                if (1 <= Horse_num && Horse_num <= 5)
                {

                }
                else
                {
                    Console.WriteLine("please select a horse number 1-5");
                    menuecontrol.Picknum();
                }



                //placing bet on horse and confirming bet 
                var Bet_amount = menuecontrol.Bet();

                //checking to make sure the players has enough credits
                if (Bet_amount <= Credit)
                {

                }
                else
                {
                    Console.WriteLine("Sorry, You have insufficient funds. Please bet an amount with in your funds");
                    menuecontrol.Bet();
                }


                //continuing the race                
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("RACERS ARE AT THE GATE AND THEY'RE OFF!!!!!");
                Console.WriteLine("---------------------------------------------");



                //Code that selects the winner of the race
                Random Gate_num = new Random();
                int Winner = Gate_num.Next(1, 6);
                Console.WriteLine("\\\\\\\\\\\\RESULTS//////////");
                Console.WriteLine($"The Winner is {horselist[Winner - 1]}");



                // code that shows if you won or lost
                // code that adds or subracts the credits from your account
                if (Horse_num == Winner)
                {
                    Console.WriteLine($"Congradulations!!! You just won {Bet_amount + Bet_amount} credits!");
                    int NewCredit = Credit + Bet_amount + Bet_amount;
                    Console.WriteLine($"Your new balance is {NewCredit} credits!");
                    Credit = NewCredit;
                }
                else
                {
                    Console.WriteLine($"Bad luck!!! You just lost {Bet_amount} credits");
                    int NewCredit = Credit - Bet_amount;
                    Console.WriteLine($"Your new balacne is {NewCredit} credits");

                    Credit = NewCredit;
                }

                if (Credit <= 0)
                {
                    start = false;
                }
            }

        }
    }
}
