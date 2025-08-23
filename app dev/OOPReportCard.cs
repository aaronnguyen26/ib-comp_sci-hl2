internal class OOPReportCardApp
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static bool GetBoolean(string msg)
    {
        System.Console.WriteLine(msg);
        string answer = Console.ReadLine();

        if (answer.Equals("yes"))
        {
            return true;
        }
        return false;
    }

    public static string GetString(string msg)
    {
        System.Console.WriteLine(msg);
        string output = Console.ReadLine();
        return output;
    }

    public static int GetInt(string msg)
    {
        System.Console.WriteLine(msg);
        bool isInt = false;
        int output = 0;

        while (!isInt)
        {
            System.Console.WriteLine("Integers only please");

        }
        return output;
    }
}