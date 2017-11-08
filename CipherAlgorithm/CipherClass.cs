using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherAlgorithm
{
    public class CipherClass
    {
        private string plain;
        private int shift;

        public string openPlain
        {
            get { return plain; }
            set { plain = value; }
        }

        public int openShift
        {
            get { return shift; }
            set { shift = value; }
        }

        public string returnCipher()
        {
            char[] buffer = plain.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                
                char letter = buffer[i];
                
                letter = (char)(letter + shift);
               
                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }               
                buffer[i] = letter;
            }
            return new string(buffer);          
        }
       
    }
}
