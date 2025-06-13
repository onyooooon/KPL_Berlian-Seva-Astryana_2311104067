using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text.Json;

namespace Jurnal15_2311104060
{

    public class UserService
    {
        private const string filePath = "users.json";
        private List<User> users;

        public UserService()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }
            else
            {
                users = new List<User>();
            }
        }

        public bool Register(string username, string password)
        {
            if (!IsValidUsername(username) || !IsValidPassword(password))
            {
                Console.WriteLine("Username atau password tidak valid.");
                return false;
            }

            if (users.Any(u => u.Username == username))
            {
                Console.WriteLine("Username sudah digunakan.");
                return false;
            }

            string hashedPassword = HashPassword(password);
            users.Add(new User { Username = username, HashedPassword = hashedPassword });
            Save();
            return true;
        }

        public bool Login(string username, string password)
        {
            string hashedPassword = HashPassword(password);
            var user = users.FirstOrDefault(u => u.Username == username && u.HashedPassword == hashedPassword);
            return user != null;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        private void Save()
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        // --- Secure Input Validation ---
        private bool IsValidUsername(string username)
        {
            return username.All(char.IsLetter) && username.Length >= 4 && username.Length <= 20;
        }

        private bool IsValidPassword(string password)
        {
            bool hasSpecialChar = password.Any(ch => "!@#$%^&*".Contains(ch));
            bool notContainUsername = true; // untuk demonstrasi
            return password.Length >= 8 && password.Length <= 20 && hasSpecialChar && notContainUsername;
        }
    }

}
