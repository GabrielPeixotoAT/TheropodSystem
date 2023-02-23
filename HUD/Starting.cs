using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheropodSystem;
using TheropodSystem.Models.Auth;
using TheropodSystem.Services;

namespace TheropodSystem.HUD
{
    public class Starting
    {
        string[] loadingLine = new string[10];
        UserService userService;

        public Starting(UserService userService)
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

            this.userService = userService;
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
        
        public void StartSystem()
        {
            List<string> sb = new List<string>();

            Header();

            sb.Add(" COPYRIGHT " + SystemInfo.COPYRIGHTYEAR + " THEROPODA(R)");
            sb.Add(" LOADER " + SystemInfo.SystemVersion);
            sb.Add(" EXEC VERSION 2.14");
            sb.Add(" " + SystemInfo.MEMORY + " KILOBYTES RAM SYSTEM");
            sb.Add(" 121446.4 MEGABYTES FREE");
            sb.Add(" NO HOLOTAPE FOUND");
            sb.Add(" LOAD ROM...");

            foreach (string str in sb)
            {
                Thread.Sleep(150);
                Console.WriteLine(str);
            }

            Thread.Sleep(3000);
        }

        public User? UserLogin()
        {
            Header();

            Console.Write("LOGIN: ");
            string login = Console.ReadLine();
            Console.Write("PASSWORD: ");
            string password = Console.ReadLine();
            
            AuthResult result = userService.Login(login, password);

            Thread.Sleep(300);

            if(result.HasError)
                Console.WriteLine("ACCESS DAINED: " + result.Message);
                
            Thread.Sleep(1500);
            
            return result.User;
        }

        public void LoginSuccess()
        {

        }

        public async void LockScreen()
        {
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(WaitTimeGenerate());

                for(int j = 0; j < 4; j++)
                {
                    Console.Write(GenerateLines() + " ");
                }

                Console.WriteLine();
            }
        }

        void Header()
        {
            Console.Clear();
            
            string stringHeader = "********** THEROPOD SYSTEM " + SystemInfo.SystemVersion + " **********";
            char[] headerCharArray = stringHeader.ToCharArray();

            for (int i = 0; i < headerCharArray.Length; i++)
            {
                Console.Write(headerCharArray[i]);
                Thread.Sleep(15);
            }

            Console.WriteLine("\n");
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