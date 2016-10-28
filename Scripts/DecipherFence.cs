using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 
namespace Scripts
{
    class DecipherFence
    {
        public void work()
        {
            //String a = File.ReadAllText("Fence.txt");
            String a = "WECRLTEERDSOEEFEAOCAIVDEN";
            String b = "WECRLTEERDSOEEFEAOCAIVDEN";
             
            int i = 1 ;
            StringBuilder res = new StringBuilder(); 
            do
            {   
                int j = i+1;
                StringBuilder[] lines = new StringBuilder[j];
                for (int z = 0; z < lines.Length; z++)
                {
                    lines[z] = new StringBuilder(); 
                }
                StringBuilder temp = new StringBuilder() ;
                a = b; 
               
                for (int y = 0 ; y <j ;y++)
                {   var l = a.Length;
                    int k = ((j-y)- 2) * 2 + 1+y;
                    if (k == -1)
                    {
                        lines[y].Append(a);
                        Console.WriteLine(lines[y]);
                        break; 
                    }
                    
                    int wl =  ((l)+(k+1)) / ((k + 1)*(y+1));
                    
                    for (int wt=0,w = 0; w < a.Length; wt++,w++)
                    {
                         
                            if (wt < wl)
                            {
                                lines[y].Append(a[w]);
                            }
                            else
                            {
                                temp.Append(a[w]);   
                            }
                    }
                    a = temp.ToString();
                    temp.Clear(); 

                    Console.WriteLine(lines[y].ToString( ));
                    lines[y].Clear();

                }

                Console.WriteLine();

                i++; 
            } while (i < 5);
            

        }

    }
}
