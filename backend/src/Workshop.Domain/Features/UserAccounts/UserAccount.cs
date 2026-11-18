using System;
using System.Collections.Generic;
using System.Text;
public enum UserRole { Customer, Seller, Admin }

namespace Workshop.Domain.Features.UserAccounts {
    public class UserAccount {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Username { get; set; }
        public UserRole Role { get; set; } = UserRole.Customer;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastLoginAt { get; set; }
    }
}