using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Scripts
{
    class FileDef
    {
        public void work()
        {
            var f1 = File.ReadAllBytes("stego100.jpg");
            var f2 = File.ReadAllBytes("stego200.jpg");
            Console.WriteLine(f1.Length);
            Console.WriteLine(f2.Length);
            for (int i = 0; i < f2.Length;i++ )
            {
                if (f1[i] == f2[i])
                {
                    f1[i] = 0;
                    f2[i] = 0;
                }
            }

            File.WriteAllBytes("def1.txt",f1) ; 
            File.WriteAllBytes("def2.txt",f2) ; 
        }
    }
}
