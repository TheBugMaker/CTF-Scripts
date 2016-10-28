using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 

namespace Scripts
{
    class DecipherXor
    {
        public void work(string file, String key , string fileout)
        {
            var data = File.ReadAllBytes(file);
            byte[] b = Encoding.ASCII.GetBytes(key);

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (byte)(~data[i]);
                data[i] = (byte)(data[i] ^ b[i % b.Length]);
                data[i] = (byte)(~data[i]);
            }

            File.WriteAllBytes(fileout , data); 
            
        }

    }
}
