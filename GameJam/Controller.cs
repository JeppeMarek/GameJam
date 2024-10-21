using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam
{
    public class Controller
    {
        private bool isAlive = Player.Lives > 0;
        private string choice;



        public void FirstStage()
        {
            Console.WriteLine("Du står op det er fredag"); // Indsæt ritig tekst senere
            while (isAlive)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Alarmen ringer! Du vågner i din egen seng klokken er 06.45.");
                Console.WriteLine("1. Snooze alarmen i 5 min\n2. Sov igennem alarmen\n3. Stå op");
                Console.ResetColor();
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Snooze();
                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Du sover igennem alarmen og vågner aldrig igen..");
                        Player.Lives = 0;
                        break;
                    case "3":
                        Console.WriteLine("Du står op med det samme og dagen begynder");
                        // WakeUp();
                        break;
                    default:
                        Console.WriteLine("Du skal vælge en mulighed for listen");
                        break;
                }
                
            }
        }
        public void Snooze()
        {
            Console.Clear();
            Console.WriteLine("Du har valgt at snooze");
            Console.WriteLine("Hvad vil du nu gøre?");
        }
    }
}
