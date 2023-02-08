using System;
using System.Security.Cryptography;
using System.Text;


namespace DbManager.Security
{
    public class User
    {
        public string Username { get; set; }
        public string EncryptedPassword { get; set; }

        public User(string username, string password)
        {
            Username = username;

            //Encrypt the password
            EncryptedPassword = Encryption.Encrypt(password);
        }

        public User() { }
    }
}
