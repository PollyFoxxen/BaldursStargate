using System.Text.Json;
using System.Xml.Serialization;


namespace BaldursStarGate2dot0
{
    internal class Io //io 
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public static void SaveGame(Player player)
        {
            string json = JsonSerializer.Serialize(player);
            //TODO Try catch
            using (StreamWriter file = new StreamWriter(Path.Combine(path, "savegame.json")))
            {
                file.WriteLine(json);
            };
        }
        public static Player? LoadGame()
        {
            //Prevention before exception
            if (!File.Exists(Path.Combine(path, "savegame.json"))) return null;
            
            //TODO Trycatch
            string json;
            using (StreamReader file = new StreamReader(Path.Combine(path, "savegame.json")))
            {
                json = file.ReadToEnd();
            };
            Player? player = JsonSerializer.Deserialize<Player>(json);
            return player;
        }

        //Just an example of doing the XML way instead of JSON
        public static void SaveGameXML(Player player)
        {
            TextWriter writer = new StreamWriter(Path.Combine(path, "savegame.json"));
            new XmlSerializer(typeof(Player)).Serialize(writer, player);
        }
        //public static Player? LoadGame()
        //{
        //    //Prevention before exception
        //    if (!File.Exists(Path.Combine(path, "savegame.json"))) return null;

        //    //TODO Trycatch
        //    string json;
        //    using (StreamReader file = new StreamReader(Path.Combine(path, "savegame.json")))
        //    {
        //        json = file.ReadToEnd();
        //    };
        //    Player? player = JsonSerializer.Deserialize<Player>(json);
        //    return player;
        //}
    }
}
