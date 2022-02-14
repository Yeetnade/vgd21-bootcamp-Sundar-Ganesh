using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_Sundar_Ganesh
{
    public static class MiniDC
    {
        public static void StartDC()
        {
            Console.WriteLine("Mini Dungeon Crawler...Welcome to the Stinky Palace");
            Console.WriteLine("What is your player's name? ");
            string pName = Console.ReadLine();
            Player player = new Player(0, pName, 40);

            //start the player at a location
            int pX = 5;
            int pY = 5;

            //Creates some monsters... an ARRAY
            Player[] monster = new Player[5];
            monster[0] = new Player(1, "Gargamle the Crusher", 40);
            monster[1] = new Player(2, "Asher the Nasher", 50); 
            monster[2] = new Player(3, "Steve Jobs", 100);
            monster[3] = new Player(4, "Willy of the Weak", 5);
            monster[4] = new Player(5, "Tayton the Terrifying", 500);

            //Create some locations
            int maxX = 11;
            int maxY = 11;
            Location[,] location = new Location[maxX, maxY];
            location[5, 5] = new Location("Home", "You are in a comfy chair near a crackling fire.", 0);
            location[4, 4] = new Location("Hallway", "You smell a fragrant scent of willows. But suddenly you see a shadowy figure", 4);
            location[1, 6] = new Location("A BIG Bedroom", "There are figurines of frogs all over the room. You hear a load rumble", 5);
            location[8, 8] = new Location("Hospital", "You start feeling better...", 0);

            //Create a random number generator
            Random dice = new Random();


        }
    }
}
