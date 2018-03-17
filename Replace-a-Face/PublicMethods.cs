using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_a_Face
{
    //method(s) that are used accross mutliple classes. 
    public class PublicMethods
    {
        //Checks that a face key is valid. Correct Length and hex characters only
        public static bool faceValid(string faceKey)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(faceKey, @"\A\b[0-9a-fA-F]+\b\Z") && faceKey.Length == 64)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
