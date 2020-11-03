using System;
using MeetMacro;

namespace ConsoleMeetMacro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AccountSaver accountSaver = new AccountSaver();

            if (accountSaver.AccountExists())
            {
                Console.Write(string.Format("Use Stored Account ({0}) [Y/n]:", accountSaver.Id));
                string response = Console.ReadLine();

                if (response != "y" && response != "Y")
                {
                    Console.Write("ID : ");
                    string id = Console.ReadLine();
                    Console.Write("PW : ");
                    string pw = GetPassword();

                    accountSaver.SetAccount(id, pw);
                    accountSaver.Save();
                }
            }

            ScheduleSaver scheduleFileManager = new ScheduleSaver("isdj", "307");
            using Macro macro = new Macro(scheduleFileManager.schedule, 15);

            macro.Run(accountSaver.Id, accountSaver.Pw);

        }

        public static string GetPassword()
        {
            string pass = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);

                if (!char.IsControl(key.KeyChar))
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        pass = pass.Remove(pass.Length - 1, 1);
                        Console.Write("\b \b");
                    }
                }
            }
            while (key.Key != ConsoleKey.Enter);
            return pass;
        }
    }
}
