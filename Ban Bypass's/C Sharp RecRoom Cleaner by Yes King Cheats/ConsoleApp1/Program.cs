using Microsoft.Win32;
using System.IO;
using System.Threading;
using System;

namespace RecRoomCleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("================================================================================================================");
            Console.WriteLine("> Rec Room Cleaner v5.2 Made by neptune#1995 (https://github.com/neptuneq/RR-Cleaner)");
            Console.WriteLine("> This software is FREE and avialible at the link above. If you bought this from anyone, you've been scammed.");
            Console.WriteLine("================================================================================================================");
            Console.WriteLine("Starting in 5 seconds.");
            Thread.Sleep(5000);
            Console.WriteLine("================================================================================================================");
            Console.WriteLine("> Deleting Rec Room's Files");
            Console.WriteLine("================================================================================================================");

            if (Directory.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\LocalLow\\Against Gravity"))
            {
                Directory.Delete("C:\\Users\\" + Environment.UserName + "\\AppData\\LocalLow\\Against Gravity", true);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sucessfully deleted \\AppData\\LocalLow\\Against Gravity");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Directory Not Found: \\AppData\\LocalLow\\Against Gravity");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            Thread.Sleep(50);
            if (Directory.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Programs\\recroom-launcher"))
            {
                Directory.Delete("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Programs\\recroom-launcher", true);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sucessfully deleted \\AppData\\Local\\Programs\\recroom-launcher");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Directory Not Found: \\AppData\\Local\\Programs\\recroom-launcher");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            Thread.Sleep(50);
            if (Directory.Exists(Environment.GetEnvironmentVariable("LocalAppData") + "\\Temp\\RecRoom"))
            {
                Directory.Delete(Environment.GetEnvironmentVariable("LocalAppData") + "\\Temp\\RecRoom", true);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Successfully deleted \\Temp\\RecRoom");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Directory Not Found: \\Temp\\RecRoom");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            Thread.Sleep(50);
            if (Directory.Exists(Environment.GetEnvironmentVariable("LocalAppData") + "\\Temp\\Against Gravity"))
            {
                Directory.Delete(Environment.GetEnvironmentVariable("LocalAppData") + "\\Temp\\Against Gravity", true);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Successfully deleted \\Temp\\Against Gravity");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Directory Not Found: \\Temp\\Against Gravity");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            Console.WriteLine("================================================================================================================");
            Console.WriteLine("> Removing Rec Room's Registry Keys");
            Console.WriteLine("================================================================================================================");

            string filePath = @"no-rr.reg";

            try
            {
                Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce");
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce", true);
                key.SetValue("No-RR", "reg import \"" + filePath + "\"");
                key.Close();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Successfully loaded the registry file: " + filePath);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error loading the registry file: " + ex.Message);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            Thread.Sleep(500);
            Console.WriteLine("================================================================================================================");
            Console.WriteLine("Starting CCleaner Auto Clean");
            Console.WriteLine("================================================================================================================");
            try
            {
                System.Diagnostics.Process.Start(@"CCleaner\\CCleaner64.exe", "/auto /uac");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Started CCleaner");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            catch (System.Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error Launching CCleaner: " + ex);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            Thread.Sleep(1500);
            Console.WriteLine("================================================================================================================");
            Console.WriteLine("Launching Monotone HWID Spoofer (https://github.com/sr2echa/Monotone-HWID-Spoofer)");
            Console.WriteLine("================================================================================================================");
            try
            {
                System.Diagnostics.Process.Start(@"Monotone.exe");
                Console.WriteLine("Started Monotone");
            }
            catch(System.Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error Launching Monotone: " + ex);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Press Enter to Conintue");
                Console.ReadKey();
            }
        }
    }
}