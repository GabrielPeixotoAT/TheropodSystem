using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheropodSystem.HUD
{
    public class Menu
    {
        const string HEADERSTING = "********** THEROPOD SYSTEM V1.0.2 **********";

        public static int Show(List<string> options)
        {
            List<string> sb = new List<string>();

            ConsoleKeyInfo aws;

            int index = 0;
            int optionLength = 15;

            Console.WriteLine("OPTIONS: \n");

            foreach(string option in options)
            {
                string optionUpper = option.ToUpper();
                char[] charArray = optionUpper.ToCharArray();
                string optionString = $"{optionUpper}";

                for (int i = charArray.Length; i < optionLength; i++)
                {
                    optionString += " ";
                }

                sb.Add($" {optionString}");
            }
            
            sb.Add(" EXIT           ");

            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;

                InstantHeader();

                Console.WriteLine("OPTIONS: \n");

                for (int i = 0; i < sb.Count; i++)
                {
                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    Console.WriteLine(sb[i]);
                }

                aws = Console.ReadKey();

                switch (aws.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (index < sb.Count - 1)
                            index++;
                        break;
                }
            } while (aws.Key != ConsoleKey.Enter);
            return index;
        }

        public static void InstantHeader()
        {
            Console.Clear();
            Console.WriteLine(HEADERSTING + "\n");
        }

        public static void Header()
        {
            Console.Clear();
            
            char[] headerCharArray = HEADERSTING.ToCharArray();

            for (int i = 0; i < headerCharArray.Length; i++)
            {
                Console.Write(headerCharArray[i]);
                Thread.Sleep(15);
            }

            Console.WriteLine("\n");
        }
    }
}