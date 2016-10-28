using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 
namespace Scripts
{
    class SplitToChunks
    {
        public void work(String path)
        {
            var f = File.ReadAllBytes(path);
            List<byte> l = new List<byte>();
            int marg = 100;
            int sep = marg;
            bool flag = false; 
            int chunk = 0  ;
            foreach (var b in f)
            {
                if (b == 0)
                {
                    sep--;
                }
                else
                {
                    flag = true;
                    sep = marg;
                }

                if (sep < 0)
                {
                    if (flag == true)
                    {   
                        int count = 0 ; 
                        foreach (var k in l)
                        {
                            if (k == 0) count++; 
                        }
                        if( (l.Count - count) > 100)
                        File.WriteAllBytes("chunks" + chunk, l.ToArray<byte>());
                        l.Clear();
                        chunk++;
                        flag = false;
                    }
                }
                else
                {
                    if (flag)
                    {
                        l.Add(b);
                    }
                }
            }
            }
         }
    }

