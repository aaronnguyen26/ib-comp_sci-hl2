using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPReportCard.Models;

namespace OOPReportCard.Data
{
    public class StudentData
    {
        private const char D = '|'; // why don't we get it seperated by a comma
        public List<StudentModel> students = new List<StudentModel>();
        public StudentModel GetStudent()
        {
            StudentModel student = new StudentModel()
            {
                FirstName = DataHelper.GetString("Please enter first name:"),
                LastName = DataHelper.GetString("Please enter last name:"),
                Age = DataHelper.GetInt("Please enter age:"),
                Email = DataHelper.GetString("Please enter email:"),
                GradeLevel = DataHelper.GetInt("Please enter grade level:")
            };

            students.Add(student);
            return student;
        }

        public void SaveStudent()
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter sw = new StreamWriter(Path.Combine(docPath, "Students.txt")))
            {
                sw.WriteLine("FirstName|LastName|Age|Email|GradeLevel");
                foreach (StudentModel s in students)
                {
                    sw.WriteLine($"{s.FirstName}{D}{s.LastName}{D}{s.Age}{D}{s.Email}{D}{s.GradeLevel}");
                }
            }
        }


    }
}