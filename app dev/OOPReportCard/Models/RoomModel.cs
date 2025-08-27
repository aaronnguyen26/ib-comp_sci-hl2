using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPReportCard.Models
{

    public class RoomModel
    {
        public int ID { get; set; }
        public string RoomNum { get; set; }
        public int Category { get; set; }

        public override string ToString()
        {
            string output;
            output = $"Room ID: {ID}\nRoom Number: {RoomNum}\nCategory: {Category}";
            return output;
        }
    }
}