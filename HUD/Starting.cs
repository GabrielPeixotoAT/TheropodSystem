using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheropodSystem.HUD
{
    public class Starting
    {
        string[] loadingLine = new string[10];

        public Starting()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            loadingLine[0] = "0X000000000034783F";
            loadingLine[1] = "REALOCANTING MEMORY";
            loadingLine[2] = "MEMORY STARTING DISCOVERY";
            loadingLine[3] = "0X005150343047A 1 1A35F";
            loadingLine[4] = "0X002478556";
            loadingLine[5] = "0X000002345602023 0 1";
            loadingLine[6] = "CPU0 LAUNCHING CELL";
            loadingLine[7] = "STATUS CODE 204";
            loadingLine[8] = "FILE SYSTEM EXT4";
            loadingLine[9] = "DOTNET SERVICE RUNNING";

        }

        public void StartUp()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(WaitTimeGenerate());

                for(int j = 0; j < 4; j++)
                {
                    Console.Write(GenerateLines() + " ");
                }

                Console.WriteLine();
            }
        }

        string GenerateLines()
        {
            return loadingLine[new Random().Next(0, 10)];
        }

        int WaitTimeGenerate()
        {
            return new Random().Next(0, 10) * 12;
        }
    }
}