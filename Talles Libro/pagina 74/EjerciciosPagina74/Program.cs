using System;

namespace EjerciciosPagina74
{
    class Program
    {
        static void Main(string[] args)
        {


            //Ejercicio 1.

            int a = 10, b = 3, c, d, e;
            float x, y;
            x = a / b;

            if (a < b < c)
            {
                a < b && c < 3;

            } 

            d = a + b++;
            e = ++a - b;
            y = (float)a / b;






            //Ejercicio 2

            String minuscula = "q";

            foreach (byte b2 in System.Text.Encoding.UTF8.GetBytes(minuscula.ToCharArray()))
                Console.WriteLine(b.ToString()); 

            String mayuscula = "Q";
            foreach (byte b2 in System.Text.Encoding.UTF8.GetBytes(mayuscula.ToCharArray()))
                Console.WriteLine(b.ToString());







            //ejercicio 3

            int a1 = 5, c1 = 2, k1 = 3;
            double b1 = -1.7, d1 = 3.5, x1 = 10.5, total;

            double resultadoA = Math.Pow(a1, 4);
            double resultadoB = Math.Pow(b1, 3);
            double resultadoC = Math.Pow(c1, 2);
            double resultadoD = d * x;

            total = ((resultadoA + resultadoB) - resultadoC) + (resultadoD + k1);

            Console.WriteLine(total);
            



            //Ejercicio 4

            class CEcuacion
            {
                 private double c3, c2, c1, c0;

                    public void Ecuacion(double a, double b, double c, double d)
                     {
                         c3 = a; c2 = b; c1 = c; c0 = d;
                     }

                        public double ValorPara(double x)
                         {
                             double resultado;
                                resultado = c3 * x * x * x + c2 * x * x + c1 * x + c0;
                                    return resultado;
                         }
            }   





        }
    }
}
