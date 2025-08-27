using OOPReportCard.Data;
using OOPReportCard.Data.OOPReportCard.Data;
using OOPReportCard.Models;

namespace OOPReportCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentData _db = new StudentData();
            for (int i = 0; i < 3; i++)
            {
                _db.GetStudent();
            }
            foreach (StudentModel s in _db.students)
            {
                Console.WriteLine(s);
            }
            _db.SaveStudents();



            TeacherData teacherDb = new TeacherData();
            for (int i = 0; i < 2; i++)
            {
                teacherDb.GetTeacher();
            }
            foreach (TeacherModel t in teacherDb.teachers)
            {
                Console.WriteLine(t);
            }

            CourseData courseDb = new CourseData();
            for (int i = 0; i < 2; i++)
            {
                courseDb.GetCourse();
            }
            foreach (CourseModel c in courseDb.courses)
            {
                Console.WriteLine(c);
            }

        }

        public static bool GetBoolean(string msg)
        {
            Console.WriteLine(msg);
            string answer = Console.ReadLine();

            if (answer.Equals("yes"))
            {
                return true;
            }
            return false;
        }

        public static string GetString(string msg)
        {
            Console.WriteLine(msg);
            string output = Console.ReadLine();
            return output;
        }

        public static int GetInt(string msg)
        {
            Console.WriteLine(msg);
            bool isInt = false;
            int output = 0;

            while (!isInt)
            {
                Console.WriteLine("Integers only please");
                isInt = Int32.TryParse(Console.ReadLine(), out output);
            }
            return output;
        }

    }

}
