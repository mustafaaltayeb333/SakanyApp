using Microsoft.AspNetCore.Identity;
using Sakany.Models;

namespace Sakany.Services
{
    /// <summary>
    /// Secure password hashing service using ASP.NET Core Identity's PasswordHasher.
    /// Implements PBKDF2 with HMAC-SHA256, 128-bit salt, 256-bit subkey, 10,000 iterations.
    /// </summary>
    public class PasswordHasher
    {
        private readonly PasswordHasher<User> _passwordHasher;

        public PasswordHasher()
        {
            _passwordHasher = new PasswordHasher<User>();
        }

        /// <summary>
        /// Hashes a plain-text password for secure storage.
        /// </summary>
        public string HashPassword(User user, string password)
        {
            return _passwordHasher.HashPassword(user, password);
        }

        /// <summary>
        /// Verifies a plain-text password against a stored hash.
        /// Returns true if the password matches.
        /// </summary>
        public bool VerifyPassword(User user, string hashedPassword, string providedPassword)
        {
            var result = _passwordHasher.VerifyHashedPassword(user, hashedPassword, providedPassword);
            return result == PasswordVerificationResult.Success 
                || result == PasswordVerificationResult.SuccessRehashNeeded;
        }

        /// <summary>
        /// Checks if a stored hash needs rehashing (e.g., algorithm upgrade).
        /// </summary>
        public bool NeedsRehash(User user, string hashedPassword, string providedPassword)
        {
            var result = _passwordHasher.VerifyHashedPassword(user, hashedPassword, providedPassword);
            return result == PasswordVerificationResult.SuccessRehashNeeded;
        }
    }
}