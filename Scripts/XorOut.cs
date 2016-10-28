using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 
namespace Scripts
{
    class XorOut
    {
        public String getXor(byte[] key, string file) {
           var sec =  File.ReadAllBytes(file);
           byte[]res = new byte[sec.Length] ; 
           for (int i = 0; i < sec.Length; i++)
           {
               res [i]= (byte)(sec[i] ^ key[i % key.Length]); 
           }
           File.WriteAllBytes("reselutXOR.txt", res);
           return null; 
        }
    }
}
