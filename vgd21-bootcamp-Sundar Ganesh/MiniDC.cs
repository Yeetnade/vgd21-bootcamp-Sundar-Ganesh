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
            Player[] monster = new Player[6];
            monster[0] = new Player(0, "", 0);
            monster[1] = new Player(1, "Stinger", 40);
            monster[2] = new Player(2, "Loud Mouth", 50);
            monster[3] = new Player(3, "Not so Helpful Bot", 100);
            monster[4] = new Player(4, "Moon Slugs", 5);
            monster[5] = new Player(5, "Harry", 150);

            //Create some locations
            int maxX = 11;
            int maxY = 11;
            Location[,] location = new Location[maxX, maxY];
            location[5, 5] = new Location("Control Center", "There is a map to your left and Oxygen refill station to your right", 0);
            location[4, 4] = new Location("Hallway", "There are high raditation levels according to your detector and many scratches on the walls. \nSuddenly you see a shadowy figure", 1);
            location[8, 8] = new Location("A BIG Bedroom", "You see a small child nibbling his fingers. He has extreamly red eyes and sharp teeth", 5);
            location[3, 3] = new Location("Science Room", "You see many dead bodies lying on the floor wiht their ears bleeding out. Suddenly there is a load shreik from behind you", 2);
            location[8, 3] = new Location("Telescope Room", "The room is super slimy with many dead bodies. Suddenly you see multiple white colored things move towards you", 4);
            location[2, 6] = new Location("Communications Center", "The room is quiet and empty. All the electronics in the room have been destroyed. \nAll the help bots have been severely damaged. Suddenly there is loud clanking sounds from behind you", 3);
            location[5, 3] = new Location("Oxygen Refill station", "You are relieved", 0);
            location[8, 9] = new Location("Samples Room", "The room is filled with various samples of moon rocks and dust.\nThere is bright glow at the back of the room where you find the important sample you were looking for \nThe scientists found a way to turn moon dust into any object we desire including trees and water", 0);


            //Create a random number generator
            Random dice = new Random();

            //Game begins...
            while (true)
            {
                //Display info about where the character is located and player health
                Console.WriteLine("\n----------------------------------------");
                Console.WriteLine("You are at ({0}, {1})", pX, pY);
                Console.WriteLine("Oxygen Level: {0}", player.Health);
                
                //Details about location and monsters
                if(location[pX, pY] != null)
                {
                    Console.WriteLine("*** {0} ***", location[pX, pY].LocationName);
                    Console.WriteLine("*** {0} ***", location[pX, pY].Description);
                    
                    //Monster Detection & Battle
                    if(location[pX, pY].MonsterID != 0)
                    {
                        int mID = location[pX, pY].MonsterID;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("!!!! You encounter {0} with health {1} !!!!", monster[mID].Name, monster[mID].Health);
                        

                        //Battle!!!!
                        int damageToMonster = dice.Next(10, 40);
                        int damageToPlayer = dice.Next(1, 12);

                        player.Health -= damageToPlayer;
                        monster[mID].Health -= damageToMonster;

                        //Speak results...
                        Console.WriteLine("!!! You take {0} damage !!!", damageToPlayer);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("!!! {0} takes {1} damage !!!", monster[mID].Name, damageToMonster);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("!!! Your Health: {0} \nMonster's Health: {1}", player.Health, monster[mID].Health);
                        Console.ForegroundColor = ConsoleColor.White;

                        //Deal with death...
                        if (monster[mID].Health <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("!!! YOU KILLED {0} !!!", monster[mID].Name);
                            location[pX, pY].MonsterID = 0; //Removes only monster from room.
                            //location[pX, pY] = null; //This removes the location altogether!
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if(player.Health <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Mission Failed, bring in the next clone");
                            return;
                        }
                    }   //Monster ID is not 0  
                }//Location is not null

                if(pX == 5 && pY == 3 || pX == 5 && pY == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Oxygen Filled");
                    Console.ForegroundColor = ConsoleColor.White;
                    player.Health = 40; //Set to full health
                    //player.Health += 3; //Give them +3 health
                    //player.Health += dice.Next(1, 6); //Roll a d6 to determine
                }

                //Ask the player for command...
                Console.Write("\nWhat is your move?: ");
                string cmd = Console.ReadLine().ToLower().Trim();
                if (cmd == "q")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Mission Abandoned");
                    return;
                }
                if (cmd == "n") pY--;
                if (cmd == "e") pX++;
                if (cmd == "s") pY++;
                if (cmd == "w") pX--;
                pX = Math.Clamp(pX, 0, maxX - 1);
                pY = Math.Clamp(pY, 0, maxY - 1);

                //Draw Map
                if (cmd == "m") Location.DrawMap(location, pX, pY);

            }//end of while true

        }
    }
}
