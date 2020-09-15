using System;

namespace Week3LogicalOperatorOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what month were you born in?");
            string month = Console.ReadLine().ToLower();
            if (month == "december" || month == "january" || month == "febuary")

            {
                Console.WriteLine("You were born in winter");
            } 
            else if (month == "march" || month == "april" || month == "may")
            {
                Console.WriteLine("You were born in spring");

            }
            else if (month == "june" || month == "july" || month == "august")
            {
                Console.WriteLine("You were born in summer");
            } 
            else if (month == "september" || month == "october" || month == "november")
            {
                Console.WriteLine("You were  born in autumn");
            } else
            {
                Console.WriteLine("THIS NOT A MONTH A FUCKING MOTNH YOU DONKEY!");
            }



        }  
        
         


        
    }
}
