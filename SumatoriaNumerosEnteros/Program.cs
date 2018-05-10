using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumatoriaNumerosEnteros
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int numero1, numero2, suma;
            
            Console.Write("ingrese el primer nùmero : ");
           
            numero1 = int.Parse(Console.ReadLine());
          
            Console.Write("ingrese el segundo número : ");
          
            numero2 = int.Parse(Console.ReadLine());
      
            suma = numero1 + numero2;
          
            Console.Write("la suma es : ", suma);
            Console.ReadLine();        
        }
    }
}
