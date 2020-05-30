namespace IP_NTier.Common.Core.Security
{
    public static class CryptoRuts
    {
        #region Public Methods
        public static string CreatePasswordHash(string pwd)
        {
            return BCrypt.Net.BCrypt.HashPassword(pwd, BCrypt.Net.BCrypt.GenerateSalt());
        }

        public static bool DoesPasswordMatch(string hash, string pwd)
        {
            return BCrypt.Net.BCrypt.Verify(pwd, hash);
        }
        #endregion
    }
}
