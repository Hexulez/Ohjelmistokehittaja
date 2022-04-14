using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eramake;

namespace Encrypt_Decrypt
{
    public class ERAMAKE
    {
        public string EraEncrypt(string salasana)
        {
            return eCryptography.Encrypt(salasana);
        }

        public string EraDecrypt(string salasana)
        {
            return eCryptography.Decrypt(salasana);
        }

    }
}
