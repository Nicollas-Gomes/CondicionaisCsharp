using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Variaveis
            int n1; //Numero 1
            int n2; //Numero 2
            int n3; //Numero 3
            
            //Entrada do Usuario    
            Console.WriteLine("Digite o primeiro Numero:");
            n1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo Numero:");
            n2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o terceiro Numero:");
            n3 = int.Parse(Console.ReadLine());

            //Condicionais
            if (n1 < n2 & n1 < n3)
            {
                Console.WriteLine("O primeiro número é o menor!");
            }
            else if (n2 < n1 & n2 < n3)
            {
                Console.WriteLine("O segundo número é o menor!");
            }
            else if (n3 < n1 & n3 < n2)
            {
                Console.WriteLine("O terceiro número é o menor!");
            }
            else if(n1 == n2 & n2 == n3 & n1 == n3)
            {
                Console.WriteLine("Os números são iguais!");
            }
            else
            {
                Console.WriteLine("A operação falhou tente novamente!");
            }
            
            Console.ReadLine();
        }
            
            

            

         
    }
}
