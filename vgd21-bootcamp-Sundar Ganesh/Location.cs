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
    }
}
