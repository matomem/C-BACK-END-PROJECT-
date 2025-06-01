using System;

namespace CryptoExchange.Backend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        // Add other relevant user properties like email, registration date, etc.
    }
} 