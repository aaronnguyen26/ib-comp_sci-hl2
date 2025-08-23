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
}