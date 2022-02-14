using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_Sundar_Ganesh
{
    public static class MiniDC
    {
        public static void StartDC()
        {
            Console.WriteLine("Welcome to Moons Edge \nThe world first station on the moon that failed miserably");
            Console.WriteLine("Your goal is retrieve an important sample from the moon and return it home");
            Console.WriteLine("However, we don't know what exactly the sample is since all contact with the previous crew members was lost ");
            Console.WriteLine("All we know is that it could save humanity from extinction due to there being no trees or water at all on earth");
            Console.Write("What is your astronaut's name?: ");
            string pName = Console.ReadLine();
            Player player = new Player(0, pName, 40);

            //start the player at a location
            int pX = 5;
            int pY = 5;

            //Creates some monsters... an ARRAY
            Player[] monster = new Player[5];
            monster[0] = new Player(1, "Stinger", 40);
            monster[1] = new Player(2, "Loud Mouth", 50);
            monster[2] = new Player(3, "Not so Helpful Bot", 100);
            monster[3] = new Player(4, "Moon Slugs", 5);
            monster[4] = new Player(5, "Harry", 500);

            //Create some locations
            int maxX = 11;
            int maxY = 11;
            Location[,] location = new Location[maxX, maxY];
            location[5, 5] = new Location("Control Center", "There is a map to your left and Oxygen refill station to your right", 0);
            location[4, 4] = new Location("Hallway", "There are high raditation levels according to your detector and many scratches on the walls. Suddenly you see a shadowy figure", 1);
            location[1, 6] = new Location("A BIG Bedroom", "You see a small child nibbling his fingers. He has extreamly red eyes and sharp teeth", 5);
            location[3, 3] = new Location("Science Room", "You see many dead bodies lying on the floor wiht their ears bleeding out. Suddenly there is a load shreik from behind you", 2);
            location[8, 7] = new Location("Telescope Room", "The room is super slimy with many dead bodies. Suddenly you see multiple white colored things move towards you", 4);
            location[2, 6] = new Location("Communications Center", "The room is quiet and empty. All the electronics in the room have been destroyed. \nAll the help bots have been severely damaged. Suddenly there is loud clanking sounds from behind you", 3);
            location[8, 8] = new Location("Oxygen Refill station", "You are relieved", 0);
            location[8, 9] = new Location("Samples Room", "The room is filled with various sample of moon rocks and dust.\nThere is bright glow at the back of the room where you find the important sample you were looking for \nThe scientists found a way to turn moon dust into any object we desire including trees and water", 0);


            //Create a random number generator
            Random dice = new Random();
            while (true)
            {
                //Display info about where the character is located...
                Console.WriteLine("\n\n----------------------------------------");
                Console.WriteLine("You are at ({0}, {1})", pX, pY);
                Console.WriteLine("Oxygen Level: {0}", player.Health);
                //Console.WriteLine("*{0}* \n{1}", location[pX, pY].LocationName, location[pX, pY].Description);
                

                //Ask the player for command...
                Console.Write("\nWhat is you move?: ");
                string cmd = Console.ReadLine();
                if (cmd == "q")
                {
                    Console.WriteLine("Mission Abandoned");
                    return;
                }
                if (cmd == "n") pY--;
                if (cmd == "e") pX++;
                if (cmd == "s") pY++;
                if (cmd == "w") pX--;
                pX = Math.Clamp(pX, 0, maxX - 1);
                pY = Math.Clamp(pY, 0, maxY - 1);

            }//end of while true

        }
    }
}
