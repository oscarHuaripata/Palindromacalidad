using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploTesting20212
{
  public class StringUtilities1
    {
        public bool Espalindrome(string word) {
            var wordchar = word.Replace(" ", "");
            var invertido = new string(word.ToCharArray().Reverse().ToArray());
           
            return word == invertido;
        }
    }
}
