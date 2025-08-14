internal class Program
{
    static void Main(string[] args)
    {
        string userName = GetString("Hello, what is your name?");
        int gradeLevel = GetInt($"Hello {userName}, what is your grade level?: ");
        int numClass = GetInt($"How many classes do you have this semester {userName}?: ");

        List<string> studentSchedule = GetStudentSchedule(numClass);
        List<int> studentGrades = GetGrades(studentSchedule);

        for (int i = 0; i < studentGrades.Count; i++)
        {
            System.Console.WriteLine($"{i + 1} {studentSchedule[i]}: {studentGrades[i]}");
        }

        double studentGpa = CalculateGPA(studentGrades);
        PrintTranscript(userName, gradeLevel, studentSchedule, studentGrades, studentGpa);
    }


    public static void PrintTranscript(string userName, int gradeLevel, List<string> studentSchedule, List<int> studentGrades, double GPACalculation)
    {
        System.Console.WriteLine(" ====== REPORT CARD ======");

        Console.WriteLine($"Student Name: {userName}");
        Console.WriteLine($"Grade Level: {gradeLevel}");
        Console.WriteLine("-----------------------------");

        Console.WriteLine("Course Grades:");
        for (int i = 0; i < studentSchedule.Count; i++)
        {
            Console.WriteLine($"  - {studentSchedule[i]}: {studentGrades[i]}");
        }
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"GPA: {GPACalculation:F2}");
        Console.WriteLine("-----------------------------");
    }

    public static double CalculateGPA(List<int> grades)
    {
        double totalGPA = 0.0;
        foreach (int grade in grades)
        {
            totalGPA += grade;
        }
        return totalGPA / grades.Count;
    }

    public static string ToLetter(int grade)
    {
        if (grade == 5 || grade == 4)
        {
            return "A";
        }
        else if (grade == 3)
        {
            return "B";
        }
        else if (grade == 2)
        {
            return "C";
        }
        else if (grade == 1)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }

    public static List<int> GetGrades(List<string> schedule)
    {
        List<int> grades = new List<int>();
        Console.WriteLine("Grades: F=0, D=1, C=2, B=3, A=4, Weighted A=5");

        foreach (string s in schedule)
        {
            int grade = GetInt($"ENTER YOUR GRADE !!!! for {s}: ");
            if (grade > 5 || grade < 0)
            {
                Console.WriteLine($"Please enter a valid grade between 0 and 5 for {s}");
            }
            grades.Add(grade);
        }
        return grades;
    }

    public static List<string> GetStudentSchedule(int numClass)
    {
        List<string> studentSchedule = new List<string>();

        for (int i = 0; i < numClass; i++)
        {
            studentSchedule.Add(GetString($"Enter your period {i + 1} class name:"));
        }
        return studentSchedule;
    }

    public static int GetInt(string strMessage)
    {
        bool isInt = false;
        int output = 0;
        Console.WriteLine(strMessage);

        while (!isInt)
        {
            isInt = Int32.TryParse(Console.ReadLine(), out output);
            if (!isInt)
            {
                Console.WriteLine("Please use integers only.");
            }
        }
        return output;
    }

    public static string GetString(string strMessage)
    {
        System.Console.WriteLine(strMessage);
        return Console.ReadLine() ?? "";
    }
}
