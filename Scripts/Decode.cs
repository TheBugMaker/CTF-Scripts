using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 
namespace Scripts
{
    class Decode
    {
        public void work() {

            var f = File.ReadAllBytes("flag") ;
            byte [] key = new byte[54] ;
            // sign 
             key[0] = (byte)(f[0] ^ Convert.ToByte('B'));
             key[1] = (byte)(f[1] ^ Convert.ToByte('M'));
            
            // size 
             key[2] = (byte)(f[2] ^ Convert.ToByte('\x36'));
             key[3] = (byte)(f[3] ^ Convert.ToByte('\xF9'));
             key[4] = (byte)(f[4] ^ Convert.ToByte('\x15'));
             key[5] = (byte)(f[5] ^ Convert.ToByte('\x00'));
            
            // 0 
             key[6] = (byte)(f[6] ^ Convert.ToByte('\x00'));
             key[7] = (byte)(f[7] ^ Convert.ToByte('\x00'));
            
            // 0 
             key[8] = (byte)(f[8] ^ Convert.ToByte('\x00'));
             key[9] = (byte)(f[9] ^ Convert.ToByte('\x00'));

            // offset to image start 
             key[10] = (byte)(f[10] ^ Convert.ToByte('\x36'));
             key[11] = (byte)(f[11] ^ Convert.ToByte('\x00'));
             key[12] = (byte)(f[12] ^ Convert.ToByte('\x00'));
             key[13] = (byte)(f[13] ^ Convert.ToByte('\x00'));
            
            // 40 
             key[14] = (byte)(f[14] ^ Convert.ToByte('\x28'));
             key[15] = (byte)(f[15] ^ Convert.ToByte('\x00'));
             key[16] = (byte)(f[16] ^ Convert.ToByte('\x00'));
             key[17] = (byte)(f[17] ^ Convert.ToByte('\x00'));
            
            // WIDTH ?
             key[18] = (byte)(f[18] ^ Convert.ToByte('\x20'));
             key[19] = (byte)(f[19] ^ Convert.ToByte('\x03'));
             key[20] = (byte)(f[20] ^ Convert.ToByte('\x00'));
             key[21] = (byte)(f[21] ^ Convert.ToByte('\x00'));
            
            // HEIGHT ? 
             key[22] = (byte)(f[12] ^ Convert.ToByte('\x58'));
             key[23] = (byte)(f[23] ^ Convert.ToByte('\x02'));
             key[24] = (byte)(f[24] ^ Convert.ToByte('\x00'));
             key[25] = (byte)(f[25] ^ Convert.ToByte('\x00'));
    
            // 1 
             key[26] = (byte)(f[26] ^ Convert.ToByte('\x01'));
             key[27] = (byte)(f[27] ^ Convert.ToByte('\x00'));

            // 24 pits per pixel 
             key[28] = (byte)(f[28] ^ Convert.ToByte('\x18')); //  24  BIT BITMAP 
             key[29] = (byte)(f[29] ^ Convert.ToByte('\x00'));

            // COMpression type  , 1 | 2 | 0 (SELECTED) guess
             key[30] = (byte)(f[30] ^ Convert.ToByte('\x00'));  
             key[31] = (byte)(f[31] ^ Convert.ToByte('\x00'));
             key[32] = (byte)(f[32] ^ Convert.ToByte('\x00'));
             key[33] = (byte)(f[33] ^ Convert.ToByte('\x00'));
            
            // SIZE OF IMAGE 
             key[34] = (byte)(f[34] ^ Convert.ToByte('\x00'));
             key[35] = (byte)(f[35] ^ Convert.ToByte('\xf9'));
             key[36] = (byte)(f[36] ^ Convert.ToByte('\x15'));
             key[37] = (byte)(f[37] ^ Convert.ToByte('\x00'));
            
            // HOr Resolution 
             key[38] = (byte)(f[38] ^ Convert.ToByte('\x00'));
             key[39] = (byte)(f[39] ^ Convert.ToByte('\x00'));
             key[40] = (byte)(f[40] ^ Convert.ToByte('\x00'));
             key[41] = (byte)(f[41] ^ Convert.ToByte('\x00'));
            
            // Ver Resosultion
             key[42] = (byte)(f[42] ^ Convert.ToByte('\x00'));
             key[43] = (byte)(f[43] ^ Convert.ToByte('\x00'));
             key[44] = (byte)(f[44] ^ Convert.ToByte('\x00'));
             key[45] = (byte)(f[45] ^ Convert.ToByte('\x00'));

            // number of colors 
             key[46] = (byte)(f[46] ^ Convert.ToByte('\x00'));
             key[47] = (byte)(f[47] ^ Convert.ToByte('\x00'));
             key[48] = (byte)(f[48] ^ Convert.ToByte('\x00'));
             key[49] = (byte)(f[49] ^ Convert.ToByte('\x00'));

            // number important color
             key[50] = (byte)(f[50] ^ Convert.ToByte('\x00'));
             key[51] = (byte)(f[51] ^ Convert.ToByte('\x00'));
             key[52] = (byte)(f[52] ^ Convert.ToByte('\x00'));
             key[53] = (byte)(f[53] ^ Convert.ToByte('\x00'));
            

            int z = 0 ; 
            foreach(var k in key ){
                Console.WriteLine(z+": "+(char)k);
                z++ ; 
            }


            Console.WriteLine(f.Length);
            var f2 = new byte[f.Length];
            for (int i = 0; i < f.Length; i++)
            {
               
            }
            StringBuilder sb = new StringBuilder(); 
            foreach (var b in key)
            {
                sb.Append((char)b); 
            }

            File.WriteAllText("THEKEY.txt",sb.ToString() );
        }

    }
}
