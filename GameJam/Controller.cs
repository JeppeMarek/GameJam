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
            
            while (isAlive == true)
            {
                Console.Clear();
                Console.WriteLine("Du står op det er fredag"); // Indsæt ritig tekst senere
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
                        break;
                    case "3":
                        WakeUp();
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
            Console.WriteLine("1. Snooze alarmen i 5 min igen\n2. Sov igennem alarmen\n3. Stå op");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Du prøver at snooze, men inden du kan trykke får du en blodprop og dør");
                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du sover igennem alarmen og vågner aldrig igen..");
                    Player.Lives = 0;
                    break;
                case "3":
                    Console.WriteLine("Du står op med det samme og dagen begynder");
                    WakeUp();
                    break;
                default:
                    Console.WriteLine("Du skal vælge en mulighed for listen");
                    break;
            }

        }
        public void WakeUp()
        {
            Console.WriteLine("Du står op med det samme og dagen begynder. Du vil nu i bad");
            Console.WriteLine("1. Gå i bad og brug shampoo og showergel\n2.Gå i bad og brug håndsæbe\n3. Spring badet over");


            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du glider i shampooen og slår hovedet. Alt bliver sort. DU DØD");
                    break;
                case "2":
                    //Breakfast();
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du springer badet over. Naboen råber ind i din lejlighed at du lugter som et lig. Du dør af skam");
                    break;
                default:
                    Console.WriteLine("Du skal vælge en mulighed for listen");
                    break;

            }
        }
        public void Breakfast()
        {
            Console.WriteLine("Du overlevede badet. Du vil nu have noget morgenmad");
            Console.WriteLine("");
        }
    }
}
