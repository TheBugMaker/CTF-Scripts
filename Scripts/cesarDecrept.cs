using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 
namespace Scripts
{
    class cesarDecrept
    {
        public void decrypt(String[] file)
        {
            
            File.WriteAllText("resultats3.txt", "");

            for (int i = 0; i < file.Length; i++)
            {
                File.AppendAllText("resultats3.txt", "\r\n" + i + "\n");
                int k = 0;
                while (k < 27)
                {
                    StringBuilder sb = new StringBuilder();
                    k++;

                    for (int j = 0; j < file[i].Length; j++)
                    {
                        if ((int)file[i][j] != 32)
                        {
                            sb.Append((char)((((int)file[i][j] + k) % 26) + 97));
                        }
                        else
                        {
                            sb.Append(" ");
                        }



                    }
                    sb.Append("\n");
                    Console.WriteLine(sb);
                    File.AppendAllText("DecipherR.txt", sb.ToString() + "\r\n", ASCIIEncoding.ASCII);
                }
            }


            Console.Read();
        }
    }
}
