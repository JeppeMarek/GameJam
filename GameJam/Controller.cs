using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GameJam
{
    public class Controller
    {
        private bool isAlive = Player.Lives > 0;
        private string choice;
        private int breakfastChoice;



        public void FirstStage()
        {

            while (isAlive == true)
            {
                //Console.Clear();
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
                    Breakfast();
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
            Console.WriteLine("1. Drik en monner \n2. Drik en flase vand \n3. Spis en skål müsli");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("du drikker en lækker monner");
                    breakfastChoice = 1;
                    Transport();
                    break;
                case "2":
                    Console.WriteLine("Du drikker noget kedeligt vand");
                    breakfastChoice = 2;
                    Transport();
                    break;
                case "3":
                    Console.WriteLine("Du spiser en skål müsli");
                    breakfastChoice = 3;
                    Transport();
                    break;
                default:
                    Console.WriteLine("Du skal vælge en mulighed for listen");
                    break;

            }
        }
        public void Transport()
        {
            Console.WriteLine("Du har fået noget at spise eller drikke. Du skal nu afsted til skole");
            Console.WriteLine("1. Gå i skole\n2. Cykel i skole\n3. Kør i bil til skole\n4. Tag offentlig transport");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Du går i skole, men bliver pludselig ramt af en lastbil. Du er død");
                    break;
                case "2":
                    Console.WriteLine("Du hopper på cyklen og 1.. 2.. 3..");
                    School();
                    break;
                    case "3":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du hopper i bilen og fræser derud af, du kører over et vejbump og flyver ind i en børnehave alle dør.");
                    break;
                    case "4":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du bliver blændet af solskinnet og taber din kaffe ud over buschaufføren. Han mister kontrollen og kører ned i en å. Alle dør");
                    break;
                    default:
                    Console.WriteLine("Du skal vælge en mulighed for listen");
                    break;
            }
        }
        public void School()
        {
            Console.WriteLine("Du er på UCL");
            Console.WriteLine("1. Tag til systemudvikling\n2. Tag til programmering\n3. Spil Slope på Y8");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Jan Brown myrder dig for at lave verdens grimmeste Objektmodel FYYY!!!");
                    break;
                    case "2":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du programmerer en AI der dræber hele verden.");
                    break;
                    case "3":
                    Console.WriteLine("Slope er for sindsygt!");
                    WalkToBouldering();
                    break;
                    default:
                    Console.WriteLine("Du skal vælge en mulighed for listen");
                    break;
            }
        }
        public void WalkToBouldering()
        {
            Console.WriteLine("Vælg en rute:");
            Console.WriteLine("1. Gå under broen\n2. Gå igennem gyden");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Det er skræmmende under broen men et par hjemløse mænd stopper ikke dig du skal jo ud og klatre");
                    Bouldering();
                    break;
                    case "2":
                    Console.WriteLine("Leif er sur, hvorfor fanden er du i Leifs gyde?! Han kaster en pokeball aka en håndgranat og du eksploderer");
                    break;
                    default:
                    Console.WriteLine("Du skal vælge en mulighed for listen");
                    break;
            }
        }
        public void Bouldering()
        {
            Console.WriteLine("Du ankommer til bouldering hallen, Orhan venter på dig");
            switch (breakfastChoice)
            {
                case 1:
                    Console.WriteLine("Du har energi fra monneren du drak til morgenmad. Du flyver op af ruter i alle sværhedsgrader, Orhan indser at han aldrig bliver lige så god til bouldering som dig.");
                    Party();
                    break;
                case 2:
                    Console.WriteLine("Du prøver at klatre op af den nemmeste rute, men vand er for svage mennesker og giver ingen energi. Du falder ned fra væggen og lander lige akkurat udenfor madrassen under dig og du dør.");
                    break;
                case 3:
                    Console.WriteLine("Dagen går relativt okay og du klatre som du normalt ville.\r\nSiden du spiste müsli til morgenmad føler du dig fyldt af energi, du går efter en sværere rute end normalt. Halvvejs oppe løber müsliens energi tør. Du falder og forstrækker en muskel, dette er lig med død for en svag IT studerende.");
                    break;
                default:
                    Console.WriteLine("Du skal vælge en mulighed for listen");
                    break;
            }

        }
        public void Party()
        {

        }
    }
}
