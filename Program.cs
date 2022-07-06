using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Program {
    class Program {
        public static void Main(string[] args) {
            List<Wall> walls = new List<Wall>();

            // Read the json string from the file
            string jsonString = File.ReadAllText("level1.json");
            Console.WriteLine(jsonString);

            // Read the json into the walls list:
            walls = JsonSerializer.Deserialize<List<Wall>>(jsonString);

            // Once everything is put in the list, you can traverse it
            foreach (Wall wall in walls) {
                Console.WriteLine($"{wall.x}, {wall.y}, {wall.width}, {wall.height}");
                Actor newWall = new Actor(wall.x, wall.y, wall.width, wall.height);
                cast.AddActor("walls", newWall);
            }

            // The action removes itself from the script
            script.RemoveAction("input", this);
            
        }
    }
}