using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Cesar
    {
        public byte Key { get; set; }

        public Cesar(byte key)
        {
            Key = key;
        }
        public Cesar()
        {
        }
        public string Encrypt(string m)
        {
            StringBuilder stringBuilder = new StringBuilder(m);
            for (int i = 0; i < m.Length; i++)
            {
                stringBuilder[i] = (char)((byte)m[i] + Key);
            }
            return stringBuilder.ToString();
        }

        public string Decrypt(string c)
        {
            StringBuilder stringBuilder = new StringBuilder(c);
            for (int i = 0; i < c.Length; i++)
            {
                stringBuilder[i] = (char)((byte)c[i] - Key);
            }
            return stringBuilder.ToString();
        }
    }

    class Vizhiner
    {
        public string Key { get; set; }

        public Vizhiner() { }
        public Vizhiner(string key)
        {
            Key = key;
        }

        public string Encrypt(string m)
        {
            StringBuilder stringBuilder = new StringBuilder(m);
            for (int i = 0; i < m.Length; i++)
            {
                stringBuilder[i] = (char)((byte)m[i] + (byte)Key[i]);
            }
            return stringBuilder.ToString();
        }

        public string Decrypt(string c)
        {
            StringBuilder stringBuilder = new StringBuilder(c);
            for (int i = 0; i < c.Length; i++)
            {
                stringBuilder[i] = (char)((byte)c[i] - (byte)Key[i]);
            }
            return stringBuilder.ToString();
        }
    }
}
