using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 
namespace Scripts
{
    class subst
    {
        public void work() {
            var files = File.ReadAllBytes("ch12.txt");

          //  var secret = new byte[] { (int)'a', (int)'c', (int)'e', (int)'.', (int)'.', (int)'.', (int)'.', (int)'.'};
          //  var secret = new byte[] { (int)'a', (int)'c', (int)'e', (int)'.', (int)'.', (int)'.', (int)'.', (int)'.', (int)'.' };
         // var secret = new byte[] { (int)'a', (int)'c', (int)'e', (int)'.', (int)'.', (int)'.', (int)'.', (int)'.', (int)'.', (int)'.', (int)'.', (int)'.' };
         // var secret = new byte[] { (int)'a', (int)'c', (int)'e', (int)'.', (int)'.', (int)'.', (int)'.', (int)'.', (int)'.', (int)'.', (int)'.', (int)'.', (int)'.', (int)'.', (int)'.', (int)'.', (int)'.', (int)'.' };
          
           var secret = new byte[] { (int)'t', (int)'h', (int)'e', (int)'m', (int)'e', (int)'n', (int)'t', (int)'o', (int)'r' };
            // var secret = new byte[] { (int)'a' };  
            StringBuilder sb = new StringBuilder(); 
            for (int i=0,j = 0; i < files.Length; j++ , i++)
            {
                if ((files[i] >= 65 && files[i] <= 90) || (files[i] >= 97 && files[i] <= 122))
                {
                    if (secret[j % secret.Length] == (int)'.')
                    {
                        files[i] = (int)'.';
                        sb.Append((char)files[i]);
                    }
                    else
                    {


                        int a = (files[i] >= 97 && files[i] <= 122) ? (int)'a' : (int)'A';
                        var dec = (secret[j % secret.Length] - (int)'a');
                        for (int k = 0; k < dec; k++)
                        {
                            if (files[i] == a)
                            {
                                files[i] = (byte)(a + 25);
                            }
                            else
                            {
                                files[i]--;
                            }


                        }
                        sb.Append((char)files[i]);
                    }
                }
                else
                {
                    sb.Append((char)files[i] );
                    j--; 
                }
                if (j % 36 == 0)
                {
                   // sb.Append("\n--\n"); 
                }
                
            }
            File.WriteAllText("Result12.txt", sb.ToString()); 
            Console.WriteLine(sb.ToString());

        } 
    }
}
