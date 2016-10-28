using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Web; 
using System.Drawing;
using System.Text.RegularExpressions;

namespace Scripts
{

    class Program
    {
        static void Main(string[] args)
        {
            DecipherXor d = new DecipherXor();
            d.work("enc_photo.png", "Garfield" , "test.txt"); 

        }




    }
}
