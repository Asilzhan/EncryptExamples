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


        private Dictionary<char, byte> dict;
        public Vizhiner()
        {
            dict = new Dictionary<char, byte>();
        }
        public Vizhiner(string key)
        {
            Key = key;
            dict = new Dictionary<char, byte>();
        }
        private void InitDict()
        {
            dict = new Dictionary<char, byte>();
            for (byte i = 0; i < 26; i++)
            {
                dict.Add((char)((byte)'a' + i), i);
                dict.Add((char)((byte)'A' + i), i);
            }
        }
        public string Encrypt(string m)
        {
            StringBuilder stringBuilder = new StringBuilder(m);
            for (int i = 0; i < m.Length; i++)
            {
                stringBuilder[i] = dict. a dict[m[i]]+dict[Key[i%Key.Length]]
                stringBuilder[i] = (char)((byte)m[i] + (byte)Key[i%Key.Length]);
            }
            return stringBuilder.ToString();
        }

        public string Decrypt(string c)
        {
            StringBuilder stringBuilder = new StringBuilder(c);
            for (int i = 0; i < c.Length; i++)
            {
                stringBuilder[i] = (char)((byte)c[i] - (byte)Key[i%Key.Length]);
            }
            return stringBuilder.ToString();
        }
    }
}
