using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Scripts
{
    class WebWithCoockie
    {
        public string send(String url , String cookies)
        {
            
            ServicePointManager.ServerCertificateValidationCallback += ValidateRemoteCertificate;
          
            WebClient wb = new WebClient();
            wb.Headers.Add(HttpRequestHeader.Cookie, cookies ) ; 
            //  "cookiename1=cookievalue1;" +
            //  "cookiename2=cookievalue2");
            return wb.DownloadString(url) ; 
        }

        private static bool ValidateRemoteCertificate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error)
        {
            // If the certificate is a valid, signed certificate, return true.
             
            return true;
             
        }
    }
}
