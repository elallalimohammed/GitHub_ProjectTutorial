internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello GitFlow, fix bugs ! ( v1.0.0)");
    }

    public void createAccount()
    {
        Console.WriteLine("profile created  successfully");
    }

    public void UI()
    {
        Console.WriteLine("User Interface Code");
    }  
    public bool Authenticate (string username, string password)
    {
        // Authentication logic here
        return true;
    }
    
}