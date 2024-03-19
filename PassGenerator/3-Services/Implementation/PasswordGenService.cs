using PassGenerator._3_Services.Interface;
using System;

namespace PassGenerator._3_Services
{
    public class PasswordGenService : IPasswordGenService
    {
        public string GenerateRandomPassword()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] password = new char[8];
            for (int i = 0; i < 8; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }
            return new string(password);
        }
    }
}