using System.Reflection;
using System.Runtime.CompilerServices;

namespace Dictionaries
{
    internal class Program
    {
        Dictionary<string, Room> Rooms = new Dictionary<string, Room>();
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        internal void Run()         
        { 
            Dictionary<int, string> personeel = new Dictionary<int, string>();
            personeel.Add(382942, "Jermaine");
            personeel.Add(789432, "Timothy");

        

            foreach (KeyValuePair<int, string> item in personeel)
            {
                Console.WriteLine(item.Value + ": "+ item.Key);
            }
            foreach (int key in personeel.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (string value in personeel.Values) 
            {
                Console.WriteLine(value);
            }
            Room start = new Room(0, 0, [
            "xxxxx",
            "x...x",
            "x...x",
            "x...x",
            "xxxxx"
            ]);
            Room room0 = new Room(0, 1, [
            "xxxxx",
            "x...x",
            "xxxxx",
            "x...x",
            "xxxxx", ]);
            Room room1 = new Room(1, 1, [
            "xxxxx",
            "x...x",
            "x.X.x",
            "x...x",
            "xxxxx",
            ]);
            Room room2 = new Room(1, 0, [
            "xxxxx",
            "xx..x",
            "x...x",
            "x..xx",
            "xxxxx",
            ]);
            Rooms.Add(start.GetRoomLocationKey(), start);
            Rooms.Add(room0.GetRoomLocationKey(), room0);
            Rooms.Add(room1.GetRoomLocationKey(), room1);
            Rooms.Add(room2.GetRoomLocationKey(), room2);
            ShowRoom(0, 0);
            ShowRoom(0, 1);
            ShowRoom(1, 0);
            ShowRoom(1, 1);
             
        }
        private void ShowRoom(int x, int y) 
        {
            Room room = Rooms[$"{x},{y}"];

            Console.WriteLine($"You are in room {x},{y}");
            foreach (string r in room.level)
            {
                Console.WriteLine(r);
            }
        }

    }
}
