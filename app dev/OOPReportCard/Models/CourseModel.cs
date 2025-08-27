using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPReportCard.Models
{

    public class CourseModel
    {
        public enum AGCategory
        {
            A = 1,
            B = 2,
            C = 3,
            D = 4,
            E = 5,
            F = 6,
            G = 7,

        }

        public string Subject { get; set; }
        public string Title { get; set; }
        public bool IsWeighted { get; set; }
        public AGCategory AGCat { get; set; }

        public override string ToString()
        {
            string output;
            output = $"Course Title: {Title}\nSubject: {Subject}\nWeighted: {IsWeighted}\nAG Category: {AGCat}";
            return output;
        }
    }
}