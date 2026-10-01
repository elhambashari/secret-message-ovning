static class InputHelper
{
    public static string ReadString(string message)
    {
        Console.Write(message);
        return Console.ReadLine() ?? "";
    }

    public static int ReadChoice()
    {
        Console.Write("Välj ett alternativ: ");

        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out int choice))
        {
            return choice;
        }

        return 0;
    }
}