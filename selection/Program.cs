using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection
{
    class Program
    {
        /// <summary>
        /// ask a question
        /// </summary>
        /// <param name="question"><the question to ask/param>
        /// <returns>the asnwer to the question</returns>
        private static string input(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }

       


        static void Main(string[] args)
        {

            string pizza = input ("what pizza would u like");

            switch (pizza)
            {
                case "cheese and tomato":
                    Console.WriteLine("vegetarian");
                    break;
            }

            string music = input("what type of music do you like");
            switch(music)
            {
                case ("rock"):
                    print("response", ConsoleColor.Green);
                    break;
            }


            Console.ReadLine();
            


        }
        /// <summary>
        /// output message in colour of choice
        /// </summary>
        /// <param name="message">message of what to print</param>
        /// <param name="colour">the colour</param>
        /// <param name="newLine">(optional) put no for no new line</param>
        private static void print(string message, ConsoleColor colour, bool newLine = true)
        {
            Console.ForegroundColor = colour;
            if (newLine == true)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.Write(message);
            }
            Console.ResetColor();
        }
    }
}
