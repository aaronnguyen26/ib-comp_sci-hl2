using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPReportCard.Models
{
    public class StudentModel : PersonModel
    {
        public string GradeLevel { get; set; }
        public string DistrictStudentID { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            string output;
            output = $"{FirstName} {LastName}, Grade Level: {GradeLevel}, Age: {Age}";
            return output;
        }

    }
}