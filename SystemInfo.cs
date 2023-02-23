using System.Diagnostics;

namespace TheropodSystem
{
    public class SystemInfo
    {
        public static readonly string SystemVersion = "V1.0.3";
        public static readonly string COPYRIGHTYEAR = "2023";
        public static string MEMORY = "";
        public static readonly string DATA_PATH = Environment.CurrentDirectory + "/Data";

        public SystemInfo()
        {
            MEMORY = GetMemory();
        }

        public static string GetMemory()
        {
            string? memory = "";

            Process proc = new System.Diagnostics.Process ();
            proc.StartInfo.FileName = "/bin/bash";
            proc.StartInfo.Arguments = "-c free -k";
            proc.StartInfo.UseShellExecute = false; 
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start ();

            for (int i = 0; i < 3; i++) {
                //sb.AppendLine(proc.StandardOutput.ReadLine());
                
                if (i == 1)
                    memory = proc.StandardOutput.ReadLine();
                else
                    proc.StandardOutput.ReadLine();
            }

            if (memory != null)
            {
                memory = memory.Substring(4, 20);
                memory = memory.Trim();
                return memory;
            }

            return "NOT FOUND";
        }
    }
}