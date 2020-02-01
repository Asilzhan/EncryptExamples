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
            int index, t;
            for (int i = 0; i < m.Length; i++)
            {
                index = m[i];
                t = index <= 'Z' ? 65 : 97;
                index -= t;
                index = (index + Key) % 26 + t;
                stringBuilder[i] = (char)index;
            }
            return stringBuilder.ToString();
        }

        public string Decrypt(string c)
        {
            StringBuilder stringBuilder = new StringBuilder(c);
            int index, t;
            for (int i = 0; i < c.Length; i++)
            {
                index = c[i];
                t = index <= 'Z' ? 65 : 97;
                index -= t;
                index = (index - Key) % 26 + t;
                stringBuilder[i] = (char)index;
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
            Key = key.ToLower();
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
            string text = m.ToLower();
            char c;
            for (int i = 0; i < m.Length; i++)
            {
                c = (char)((text[i] - 'a' + Key[i % Key.Length]-'a') % 26 + 'a');
                stringBuilder[i] = char.IsUpper(m[i]) ? char.ToUpper(c) : c;
            }
            return stringBuilder.ToString();
        }

        public string Decrypt(string c)
        {
            StringBuilder stringBuilder = new StringBuilder(c);
            string text = c.ToLower();
            int t;
            for (int i = 0; i < c.Length; i++)
            {
                t = (text[i] - Key[i % Key.Length]) % 26;
                if (t < 0) t += 26;
                stringBuilder[i] = char.IsUpper(c[i])?char.ToUpper((char)(t+'a')) : (char)(t + 'a');
            }
            return stringBuilder.ToString();
        }
    }
}
