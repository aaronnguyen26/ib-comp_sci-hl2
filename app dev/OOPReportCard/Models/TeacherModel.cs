using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPReportCard.Models
{

    public class TeacherModel : PersonModel
    {
        public int Prefix { get; set; }
        public DateTime HireDate { get; set; }
        public int DistrictTeacherID { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            string output;
            output = $"{Prefix} {FirstName} {LastName}, Age: {Age}, Birth Date: {BirthDate.ToShortDateString()}, Hire Date: {HireDate.ToShortDateString()}, District ID: {DistrictTeacherID}, Email: {Email}";
            return output;
        }

    }
}