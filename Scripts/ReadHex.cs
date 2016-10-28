using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography; 
namespace Scripts
{
    class ReadHex
    {
        public void work() {
            StringBuilder sb = new StringBuilder(); 

            var lines = File.ReadAllLines("hey.txt");
            byte[]k = new byte[lines.Length] ; 
            int j = 0 ; 
            foreach (var l in lines)
            {   
                if(l.Length > 0 )
                k[j] = ((byte)Convert.ToInt32(l, 16)) ;
                j++;
            }    
                MD5 md5 = System.Security.Cryptography.MD5.Create();
                byte[] hash = md5.ComputeHash(k);

                // step 2, convert byte array to hex string

                StringBuilder sb3 = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)

                {

                    sb3.Append(hash[i].ToString("X2"));

                }

                File.WriteAllText("THERESULT.txt", sb3.ToString());
        }

    }
}
