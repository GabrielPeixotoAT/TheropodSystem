using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheropodSystem.HUD
{
    public class Starting
    {
        string[] loadingLine = new string[5];

        public Starting()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            
            loadingLine[0] = "0X000000000034783F";
            loadingLine[1] = "ALOCANTIING MEMORY";
            loadingLine[2] = "MEMORY STARTING DISCOVERY";
            loadingLine[3] = "0X005150343047A";
            loadingLine[4] = "0X0024785";
        }

        public void StartUp()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(WaitTimeGenerate());

                for(int j = 0; j < 3; j++)
                {
                    Console.Write(GenerateLines() + " ");
                }

                Console.WriteLine();
            }
        }

        string GenerateLines()
        {
            return loadingLine[new Random().Next(0, 5)];
        }

        int WaitTimeGenerate()
        {
            return new Random().Next(0, 10) * 12;
        }
    }
}