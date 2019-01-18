using System;
using System.Security.Cryptography;
using System.Text;

namespace SecureDataProtectOrPasswordProtect
{
    class SecureDataProtected
    {
        private readonly Encoding _encoding = Encoding.Unicode;

        public string Unprotect(string encryptedDataString)
        {
            byte[] protectedData = Convert.FromBase64String(encryptedDataString);
            byte[] unprotectedData = ProtectedData.Unprotect(protectedData, null, DataProtectionScope.CurrentUser);

            return _encoding.GetString(unprotectedData);
        }

        public string Protect(string unprotectedDataString)
        {
            byte[] unprotectedData = _encoding.GetBytes(unprotectedDataString);
            byte[] protectedData = ProtectedData.Protect(unprotectedData, null, DataProtectionScope.CurrentUser);

            return Convert.ToBase64String(protectedData);
        }
    }
}