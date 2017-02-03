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
            int number = 0; // Variable de tipo entero
            String hexadecimal = ""; // Variable de tipo string (cadena de caracteres)
            
            Console.Write("Escriba un numero decimal: "); //Imprime en pantalla un mensaje
            number = int.Parse(Console.ReadLine()); // Lee un dato digitado por el usuario y lo convierte a entero
            
            while(true) { // Ciclo while infinito
              if((number % 16) != 0) { // Condicion que evalua si el residuo es diferente de 0
                if((number % 16) > 9) { // Si es diferente de 0 y mayor que 9, entonces hara
                  switch(number % 16) { // una estructura multicondicional
                    case 10: // Si el residuo es 10, sera A
                      hexadecimal = "A" + hexadecimal; // Guardara el valor en la variable string
                      break; // Sale del switch
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
                } else // si no es mayor que 9, entonces tomara el valor normal
                  hexadecimal = (number % 16).ToString() + hexadecimal;
                
              } else // si no es diferente de 0 entonces sera 0
                hexadecimal = "0" + hexadecimal;
              
              number /= 16; // Dividimos el numero dentro de 16 y lo igualamos
              if(number <= 0) // condicion para salir del while infinito
                break;
            }
            
            Console.WriteLine("El numero hexadecimal es: " + hexadecimal); // Imprime en pantalla el resultado en hexadecimal
            Console.ReadKey();  // Hace una pausa
        }
    }
}
