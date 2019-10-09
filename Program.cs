using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "";
            char[] determinante = { ',', ' ' };
            char[] determinante1 = { '[', '(', ')', ']' };

            Console.WriteLine("Ingresar valores en el siguiente formato [(1,1) (3,4) (5,5) (4,1)]");
            cadena = Console.ReadLine();
            string[] valores1 = cadena.Split(determinante);
            string[] valores2 = new string[valores1.Length];
            double[] num = new double[valores2.Length];

            for (int i = 0; i < valores1.Length; i++)
            {
                valores2[i] = valores1[i].Trim(determinante1);
                num[i] = Convert.ToDouble(valores2[i]);
            }


            List<calcu> calco = new List<calcu>();

            for (int u = 0; u < valores2.Length; u++)
            {
                if((u==0)||(u%2==0))
                {
                    double x = num[u];
                    double y = num[u + 1];
                    double Respuesta = Math.Sqrt(Math.Pow(((x) - 0), 2) + Math.Pow(((y) - 0), 2));
                    calcu calcoo=new calcu
                    {
                        n1 = x,
                        n2 = y,
                        re = Respuesta
                    };

                    calco.Add(calcoo);
                }
            }


            Console.WriteLine("Ingrese el numero 'k'");
            int f = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();


            calco = calco.OrderBy(b => b.re).ToList();


            for (int l = 0; l < f; l++)
            {
                Console.WriteLine("El punto mas cercano es ({0},{1}), con una distancia de :{2}"
                    , calco[l].n1, calco[l].n2, calco[l].re);
            }

            Console.ReadKey();
        }
    }
}