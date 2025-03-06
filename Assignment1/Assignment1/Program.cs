
internal class Program
{
    private static void Main(string[] args)
    {
        SecuritySystem securitysystem = new SecuritySystem();
        securitysystem.AuthenticateUser();
    }
}

sealed class  SecuritySystem
{
    public void AuthenticateUser()
    {
        Console.WriteLine("user authenticated");
    }
}

//class AdvancedSecurity : SecuritySystem { } //error