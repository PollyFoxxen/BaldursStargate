using System.Text.Json;

namespace BaldursStarGate2dot0
{
    internal class Io
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public static void SaveGame(Player player)
        {
            string json = JsonSerializer.Serialize(player);

            using (StreamWriter file = new StreamWriter(Path.Combine(path, "savegame.json")))
            {
                file.WriteLine(json);
            };
        }

        public static Player? LoadFromFile()
        {
            //Prevention before exception
            if (!File.Exists(Path.Combine(path, "savegame.json"))) return null;
            
            string json;
            using (StreamReader file = new StreamReader(Path.Combine(path, "savegame.json")))
            {
                json = file.ReadToEnd();
            };
            Player? player = JsonSerializer.Deserialize<Player>(json);
            return player;
        }
    }
}
