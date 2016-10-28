using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions; 
namespace Scripts
{
    class NoMorse
    {    
        #region morse dic
            Dictionary<char, String> morse = new Dictionary<char, String>()
            {   {'0' , "-----"},
                {'1' , ".----"},
                {'2' , "..---"},
                {'3' , "...--"},
                {'4' , "....-"},
                {'5' , "....."},
                {'6' , "-...."},
                {'7' , "--..."},
                {'8' , "---.."},
                {'9' , "----."},
                {'X' , "-..-"},
                {'Y' , "-.--"},
                {'Z' , "--.."},
                {'F' , "..-."},
                {'B' , "-..."},
                {'C' , "-.-."},
                {'J' , ".---"},
                {'H' , "...."},
                {'P' , ".--."},
                {'Q' , "--.-"},
                {'V' , "...-"},
                {'L' , ".-.."},
                {'D' , "-.."},
                {'G' , "--."},
                {'U' , "..-"},
                {'W' , ".--"},
                {'K' , "-.-"},
                {'O' , "---"},
                {'R' , ".-."},
                {'S' , "..."},
                {'I' , ".."},
                {'M' , "--"},
                {'A' , ".-"},
                {'N' , "-."},
                {'T' , "-"},
                {'E' , "."},
                
                
            };
#endregion
        public void work()
        {



            var code = "--.-...--....---...----.-.----..--.--..-.----..-----.-..-.-----.--.-----....-.--.-..--..-.---....-.--..----....-.--.-.-.--.....--.-...--.-.-.--.--..--..----..-...--.-.---..--.--...-.--..--..--.-.---..-...--.--..--.-..--..-...--.-...--..--.--..-.--..--.--.--..-.-.---..-.--....--...--.--.--."; 
            int dot =  0; 
            int dash = 0 ;
              for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == '.')
                {
                    dot++;

                }
                else
                {
                    dash++; 
                }

             
            }
              Console.WriteLine("dot: "+dot+"\ndash: "+dash+"\ntotal: "+(dot+dash));
              
              string keep = "";
              int min = 10;


              foreach (KeyValuePair<char, string> entry in morse)
              {
                  Console.WriteLine(entry.Key + " : " + new Regex(Regex.Escape(entry.Value)).Matches(code).Count);
              }

              var word = getMorse("kcah");
              Console.WriteLine("count : " + new Regex(Regex.Escape(word)).Matches(code).Count);

              int sub = 0;
              StringBuilder sb = new StringBuilder(); 
              while (sub < code.Length)
              {
                  foreach (KeyValuePair<char, string> entry in morse)
                  {
                      if (code.Substring(sub, Math.Min(entry.Value.Length,code.Length-sub)).Equals(entry.Value))
                      {
                          sb.Append(entry.Key); 
                          sub+= entry.Value.Length;
                          break; 
                      }
                  }
              }
              Console.WriteLine(sb.ToString());
              File.WriteAllText("maybeKEY", sb.ToString());
        }

        public String getMorse(String a)
        {   StringBuilder sb = new StringBuilder() ;

        foreach (var i in a)
        {
            var k = ( i+"" ).ToUpper()[0] ; 
            sb.Append(morse[k]);  
        }
        return sb.ToString();
        }   
    }
}
