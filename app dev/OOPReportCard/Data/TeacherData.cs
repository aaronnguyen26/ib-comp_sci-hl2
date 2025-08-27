using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPReportCard.Models;

namespace OOPReportCard.Data
{
    public class TeacherData
    {
        private const char D = '|';
        public List<TeacherModel> teachers = new List<TeacherModel>();

        public TeacherModel GetTeacher()
        {
            TeacherModel teacher = new TeacherModel()
            {
                FirstName = DataHelper.GetString("Enter teacher's first name:"),
                LastName = DataHelper.GetString("Enter teacher's last name:"),
                Age = DataHelper.GetInt("Enter teacher's age:"),
                BirthDate = DateTime.Parse(DataHelper.GetString("Enter teacher's birth date (yyyy-MM-dd):")),
                Prefix = DataHelper.GetInt("Enter teacher's prefix (e.g., 1=Mr, 2=Ms, etc.):"),
                HireDate = DateTime.Parse(DataHelper.GetString("Enter hire date (yyyy-MM-dd):")),
                DistrictTeacherID = DataHelper.GetInt("Enter district teacher ID:"),
                Email = DataHelper.GetString("Enter teacher's email:")
            };

            teachers.Add(teacher);
            return teacher;
        }

        public void SaveTeachers()
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter sw = new StreamWriter(Path.Combine(docPath, "TeacherFile.txt")))
            {
                sw.WriteLine("FirstName|LastName|Age|BirthDate|Prefix|HireDate|DistrictTeacherID|Email");
                foreach (TeacherModel t in teachers)
                {
                    sw.WriteLine($"{t.FirstName}{D}{t.LastName}{D}{t.Age}{D}{t.BirthDate:yyyy-MM-dd}{D}{t.Prefix}{D}{t.HireDate:yyyy-MM-dd}{D}{t.DistrictTeacherID}{D}{t.Email}{D}");
                }
            }
        }
    }
}

