//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 0;
            String hexadecimal = "";
            
            Console.Write("Escriba un numero decimal: ");
            number = int.Parse(Console.ReadLine());
            
            while(true) {
              if((number % 16) != 0) {
                if((number % 16) > 9) {
                  switch(number % 16) {
                    case 10:
                      hexadecimal = "A" + hexadecimal;
                      break;
                    case 11:
                      hexadecimal = "B" + hexadecimal;
                      break;
                    case 12:
                      hexadecimal = "C" + hexadecimal;
                      break;
                    case 13:
                      hexadecimal = "D" + hexadecimal;
                      break;
                    case 14:
                      hexadecimal = "E" + hexadecimal;
                      break;
                    case 15:
                      hexadecimal = "F" + hexadecimal;
                      break;
                  }
                } else 
                  hexadecimal = (number % 16).ToString() + hexadecimal;
                
              } else 
                hexadecimal = "0" + hexadecimal;
              
              number /= 16;
              if(number <= 0)
                break;
            }
            
            Console.WriteLine("El numero hexadecimal es: " + hexadecimal);
            Console.ReadKey();
        }
    }
}
      