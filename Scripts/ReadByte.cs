using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections; 
namespace Scripts
{
    class ReadByte
    {
        public void work(int n, int p, int b) {
            
            var file = File.ReadAllBytes("stego100.jpg");
            BitArray ba = new BitArray(file.Length);
            int i = 0; 
            foreach (var item in file)
            {
                ba[i] = (item % 2 )== 1;
                ba[i + 1] = (item % 4) >= 2;
                i+=2;
            }

            byte[] a = new byte[ba.Length];
            ba.CopyTo(a, 0);
            
            File.WriteAllBytes("ITWONTWORKTRUSTME.txt", a); 
        }
    }
}
