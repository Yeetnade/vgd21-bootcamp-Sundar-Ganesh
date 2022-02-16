using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace vgd21_bootcamp_Sundar_Ganesh
{
    public static class SaveLoadData
    {
        public static void SavePlayerData(Player p)
        {
            string jsP = JsonSerializer.Serialize(p);
            Console.WriteLine(jsP);
            string fileName = "e:\\VGD\\AMPlayerData.txt";
            File.WriteAllText(fileName, jsP);
        }

        public static Player LoadPlayerData (Player p)
        {
            string fileName = "e:\\VGD\\AMPlayerData.txt";
            string jsP = File.ReadAllText(fileName);
            Player x = JsonSerializer.Deserialize<Player>(jsP);
            return x;
        }
    }
}
