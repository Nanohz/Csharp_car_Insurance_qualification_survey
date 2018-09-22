using System;

namespace C_sharp_Car_insurance_survey
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Approval Qoute For Care Insurance:");
            Console.ReadLine();
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int age_ = Convert.ToInt16(age);
            Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI? True or False?");
            string yesOrno = Console.ReadLine();
            bool trueOrfalse = Convert.ToBoolean(yesOrno);
            Console.ReadLine();
            Console.WriteLine("Your answer is :" + trueOrfalse);
            Console.ReadLine();
            Console.WriteLine("If any, How many speeding tickets do you have?");
            Console.ReadLine();
            string ticketNumb = Console.ReadLine();
            int ticketNumbConv = Convert.ToInt16(ticketNumb);
            Console.ReadLine();
            Console.WriteLine("Qualified? :");
            Console.ReadLine();


            if (age_ >= 15  && ticketNumbConv <= 3 && trueOrfalse == false)
            
            {

                Console.WriteLine("Your qualification equals : TRUE!");

            }
            else {

                Console.WriteLine("Sorry, But you do not qualify.");
            }


















        }
    }
}
