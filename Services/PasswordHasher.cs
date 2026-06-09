using System.Security.Cryptography;
using System.Text;

namespace Sakany.Services
{
    /// <summary>
    /// Replaces the plain-text password storage used everywhere in the project.
    /// Drop-in: call Hash() on save, Verify() on login.
    /// Uses PBKDF2 with SHA-256, 100 000 iterations, 32-byte salt + 32-byte hash.
    /// </summary>
    public static class PasswordHasher
    {
        private const int SaltSize    = 32;   // bytes
        private const int HashSize    = 32;   // bytes
        private const int Iterations  = 100_000;

        // ── Hash ────────────────────────────────────────────────
        /// <summary>Returns a storable "salt:hash" string for <paramref name="password"/>.</summary>
        public static string Hash(string password)
        {
            using var rng = RandomNumberGenerator.Create();
            byte[] salt = new byte[SaltSize];
            rng.GetBytes(salt);

            byte[] hash = Pbkdf2(password, salt);

            return $"{Convert.ToBase64String(salt)}:{Convert.ToBase64String(hash)}";
        }

        // ── Verify ──────────────────────────────────────────────
        /// <summary>
        /// Returns true if <paramref name="password"/> matches the stored hash.
        /// Also accepts the LEGACY plain-text passwords that were in the seed
        /// (anything that doesn't contain a colon is treated as plain-text and
        /// compared directly — remove this branch once all users have re-hashed
        /// passwords, e.g. after first login migration).
        /// </summary>
        public static bool Verify(string password, string storedHash)
        {
            // Legacy plain-text path (seed data has "hashed_pass" literally)
            if (!storedHash.Contains(':'))
                return password == storedHash;

            var parts = storedHash.Split(':', 2);
            if (parts.Length != 2) return false;

            byte[] salt;
            byte[] expectedHash;
            try
            {
                salt         = Convert.FromBase64String(parts[0]);
                expectedHash = Convert.FromBase64String(parts[1]);
            }
            catch { return false; }

            byte[] actualHash = Pbkdf2(password, salt);

            // Constant-time comparison to resist timing attacks
            return CryptographicOperations.FixedTimeEquals(actualHash, expectedHash);
        }

        // ── Private helper ──────────────────────────────────────
        private static byte[] Pbkdf2(string password, byte[] salt)
        {
            using var pbkdf2 = new Rfc2898DeriveBytes(
                password,
                salt,
                Iterations,
                HashAlgorithmName.SHA256);

            return pbkdf2.GetBytes(HashSize);
        }
    }
}