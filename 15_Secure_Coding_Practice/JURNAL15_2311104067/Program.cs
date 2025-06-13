using Jurnal15_2311104060;

class Program
{
    static void Main(string[] args)
    {
        UserService userService = new UserService();

        Console.WriteLine("1. Register");
        Console.WriteLine("2. Login");
        Console.Write("Pilih menu: ");
        var menu = Console.ReadLine();

        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        if (menu == "1")
        {
            if (userService.Register(username, password))
                Console.WriteLine("Registrasi berhasil!");
        }
        else if (menu == "2")
        {
            if (userService.Login(username, password))
                Console.WriteLine("Login berhasil!");
            else
                Console.WriteLine("Login gagal!");
        }
    }
}
