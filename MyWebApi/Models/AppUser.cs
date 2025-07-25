﻿namespace MyWebApi.Models
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string Role { get; set; }

    }
}
