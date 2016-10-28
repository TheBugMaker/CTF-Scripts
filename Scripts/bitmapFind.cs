using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections; 

namespace Scripts
{
    class bitmapFind
    {
        public void work()
        {
             
            using (FileStream f = new FileStream("RESULT.txt", FileMode.Append, FileAccess.Write))
            {


                StreamWriter sw = new StreamWriter(f);
              
            Bitmap bmp = new Bitmap("ch9.png");
            Bitmap bmp2 = new Bitmap( bmp.Width, bmp.Height); 
            Console.WriteLine(bmp.Height+"  "+bmp.Width);
            BitArray bit = new BitArray(bmp.Height * bmp.Width *3 ); 
          
            int j = 0 ; 
            for (int i = 0; i < bmp.Height * bmp.Width; ++i)
            {
                int row = i / bmp.Width;
                int col = i % bmp.Height;
                if (row % 2 != 0) col = bmp.Width - col - 1;
                 
                    var pixel = bmp.GetPixel( col,row);
                    bit[j] = (pixel.R % 2 )== 1;
                    bit[j+1] = (pixel.G % 2) == 1;
                    bit[j+2] =( pixel.B % 2 )== 1;


                    byte[] k = new byte[3];
                    k[0] =(byte)( ((pixel.R % 2) == 1) ? 0 : 255);
                    k[1] =(byte) (((pixel.G % 2) == 1) ? 0 : 255);
                    k[2] = (byte)(((pixel.B % 2) == 1) ? 0 : 255); 
                bmp2.SetPixel(col, row, Color.FromArgb(k[0],k[1],k[2])); 
                   j +=3 ; //  File.AppendAllText("STegNO.txt", pixel.R + " " + pixel.G + " " + pixel.B + " \r\n"); 
                }
                
                    
          
               byte []btt= new byte[bit.Length] ;
                bit.CopyTo(btt,0) ; 
            
                File.WriteAllBytes("isITAfile22" ,btt ); 
            
                bmp2.Save("restgt.btm");

                File.WriteAllText("TEXTFILE.txt",System.Text.Encoding.ASCII.GetString(btt));
            }
        }
        }

    }

