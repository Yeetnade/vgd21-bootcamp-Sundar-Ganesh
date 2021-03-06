using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_Sundar_Ganesh
{
    public class Location
    {
        //properties
        public string LocationName;
        public string Description;
        public int MonsterID;


        public Location(string locationName, string description, int monsterID)
        {
            LocationName = locationName;
            Description = description;
            MonsterID = monsterID;

        }

        public static void DrawMap(Location[,] loc, int playerX, int playerY)
        {
            //https://docs.microsoft.com/en-us/dotnet/api/system.array.length?view=net-5.0
            //Console.WriteLine(loc.Rank);
            int xDim = loc.GetUpperBound(0);
            int yDim = loc.GetUpperBound(1);
            //Console.WriteLine("{0}, {1}", xDim, yDim);
            for (int y = 0; y <= yDim; y++)
            {
                for (int x = 0; x <= xDim; x++)
                {
                    string locName = "*";

                    //if (loc[x, y].LocationName != null || loc[x, y].MonsterID != 0)
                    if (loc[x, y] != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        locName = loc[x, y].LocationName.Substring(0, 1);

                        //locName = "+";
                    }
                    if (x == playerX && y == playerY)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        locName = "X";
                    }

                    Console.Write(locName);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}

