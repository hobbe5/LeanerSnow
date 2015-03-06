using LeanerSnow.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanerSnow.Core.Encryption
{
    public class Security
    {
        public static string Encrypt(int num_to_encrypt)
        {
            return Encrypt(num_to_encrypt.ToString());
        }

        public static string Encrypt(string string_to_encrypt)
        {
            //I noticed a lot of this unable to encrypt message in the logs, I figured it would be best to silence this 
            if (String.IsNullOrEmpty(string_to_encrypt)) return "";

            try
            {
                Crypto c = new Crypto(Crypto.CryptoTypes.encTypeTripleDES);
                return c.Encrypt(string_to_encrypt);
            }
            catch (Exception ex)
            {
                LogHelper.logError("CryptoUtils.cs", "Unable to encrypt " + string_to_encrypt + " " + ex.Message + " " + ex.StackTrace);
                return "";
            }
        }

        public static string Decrypt(string string_to_decrypt)
        {
            if (string.IsNullOrWhiteSpace(string_to_decrypt)) return string.Empty;

            try
            {
                Crypto c = new Crypto(Crypto.CryptoTypes.encTypeTripleDES);
                return c.Decrypt(string_to_decrypt);
            }
            catch (Exception ex)
            {
                LogHelper.logError("Security.cs", "Unable to decrypt " + string_to_decrypt + " " + ex.Message + " " + ex.StackTrace);
                return "";
            }
        }
    }
}
