using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPReportCard.Models;

namespace OOPReportCard.Data
{
    namespace OOPReportCard.Data
    {
        public class StudentData
        {
            private const char D = '|';
            public List<StudentModel> students = new List<StudentModel>();
            public StudentModel GetStudent()
            {
                StudentModel student = new StudentModel()
                {
                    FirstName = DataHelper.GetString("Please enter first name:"),
                    LastName = DataHelper.GetString("Please enter last name:"),
                    Age = DataHelper.GetInt("Please enter age:"),
                    Email = DataHelper.GetString("Please enter Email:"),
                    GradeLevel = DataHelper.GetInt("Please enter grade level:")
                };

                students.Add(student);
                return student;

            }

            public void SaveStudents()
            {
                string docPath = Environment.GetFolderPath
                   (Environment.SpecialFolder.MyDocuments);

                using (StreamWriter sw = new StreamWriter(Path.Combine(docPath, "StudentFile.txt")))
                {
                    sw.WriteLine("FirstName|LastName|Age|Email|Gradelevel");
                    foreach (StudentModel s in students)
                    {
                        sw.WriteLine($"{s.FirstName}{D}{s.LastName}{D}{s.Age}{D}{s.Email}{D}{s.GradeLevel}{D}");
                    }
                }

            }

            public List<StudentModel> LoadStudents()
            {
                students.Clear();

                string docPath = Environment.GetFolderPath
                    (Environment.SpecialFolder.MyDocuments);

                using (StreamReader reader = new StreamReader(docPath + "\\StudentFile.txt"))
                {
                    List<string> lines = new List<string>();
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }

                    for (int i = 1; i < lines.Count; i++)
                    {
                        string[] fields = lines[i].Split(D);
                        StudentModel student = new StudentModel()
                        {
                            FirstName = fields[0],
                            LastName = fields[1],
                            Age = Int32.Parse(fields[2]),
                            Email = fields[3],
                            GradeLevel = Int32.Parse(fields[4])
                        };
                        students.Add(student);
                    }
                    return students;
                }

            }
        }
    }
}