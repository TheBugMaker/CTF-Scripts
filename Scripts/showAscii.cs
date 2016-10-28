using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO ; 
namespace Scripts
{
    class showAscii
    {
        public void show (String file)
        {
            var bfile = File.ReadAllBytes(file);
            for (int i = 0; i < bfile.Length; i++)
            {
                int k = 0;
                for (int j = 0; j < bfile.Length; j++)
                    if (bfile[i] == bfile[j]) k++; 
                Console.WriteLine(i+"  = "+bfile[i]+"  "+k);
            }
        }
    }
}
