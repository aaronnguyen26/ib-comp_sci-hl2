using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPReportCard.Models;

namespace OOPReportCard.Data
{
    public class RoomData
    {
        private const char D = '|';
        public List<RoomModel> rooms = new List<RoomModel>();

        public RoomModel GetRoom()
        {
            RoomModel room = new RoomModel()
            {
                ID = DataHelper.GetInt("Enter Room ID:"),
                RoomNum = DataHelper.GetString("Enter Room Number:"),
                Category = DataHelper.GetInt("Enter Room Category (e.g., Lab, Classroom, Gym):")
            };

            rooms.Add(room);
            return room;
        }

        public void SaveRooms()
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(docPath, "RoomFile.txt");

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("ID|RoomNum|Category");
                foreach (RoomModel r in rooms)
                {
                    sw.WriteLine($"{r.ID}{D}{r.RoomNum}{D}{r.Category}");
                }
            }

            Console.WriteLine($"Rooms saved to: {filePath}");
        }

        public void LoadRooms()
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(docPath, "RoomFile.txt");

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Room file not found. No rooms loaded.");
                return;
            }

            using (StreamReader sr = new StreamReader(filePath))
            {
                string header = sr.ReadLine();
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(D);
                    if (parts.Length == 3)
                    {
                        rooms.Add(new RoomModel
                        {
                            ID = int.Parse(parts[0]),
                            RoomNum = parts[1],
                            Category = int.Parse(parts[2])
                        });
                    }
                }
            }

            Console.WriteLine("Rooms loaded successfully.");
        }
    }
}




