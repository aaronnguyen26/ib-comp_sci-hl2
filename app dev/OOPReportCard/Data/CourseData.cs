using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPReportCard.Models;

namespace OOPReportCard.Data
{
    public class CourseData
    {
        private const char D = '|';
        public List<CourseModel> courses = new List<CourseModel>();

        public CourseModel GetCourse()
        {
            CourseModel course = new CourseModel()
            {
                Title = DataHelper.GetString("Enter course title:"),
                Subject = DataHelper.GetString("Enter course subject:"),
                IsWeighted = DataHelper.GetBoolean("Is the course weighted? (yes/no):"),
                AGCat = (CourseModel.AGCategory)DataHelper.GetInt("Enter A-G category (1=A, 2=B, ... 7=G):")

            };

            courses.Add(course);
            return course;

        }

        public void SaveCourses()
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter sw = new StreamWriter(Path.Combine(docPath, "CourseFile.txt")))
            {
                sw.WriteLine("Title|Subject|IsWeighted|AGCategory");
                foreach (CourseModel c in courses)
                {
                    sw.WriteLine($"{c.Title}{D}{c.Subject}{D}{c.IsWeighted}{D}{(int)c.AGCat}{D}");
                }
            }
        }

        public List<CourseModel> LoadCourses()
        {
            courses.Clear();
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(docPath, "CourseFile.txt");

            if (!File.Exists(filePath))
                return courses;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string? line;
                bool isFirstLine = true;
                while ((line = reader.ReadLine()) != null)
                {
                    if (isFirstLine) { isFirstLine = false; continue; }
                    string[] fields = line.Split(D);
                    if (fields.Length < 4) continue;

                    CourseModel course = new CourseModel()
                    {
                        Title = fields[0],
                        Subject = fields[1],
                        IsWeighted = bool.Parse(fields[2]),
                        AGCat = (CourseModel.AGCategory)int.Parse(fields[3])
                    };
                    courses.Add(course);
                }
            }
            return courses;
        }


    }
}
