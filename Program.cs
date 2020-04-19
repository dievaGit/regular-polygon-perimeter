using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetroPoligonoRegular
{
    class Program
    {
        static void Main(string[] args)
        {
            float lado = 0.0f;
            int cantLado = 0;
            float perimetro = 0.0f;

            Console.Write("Escriba cuanto mide un lado del poligono:");
            lado = Convert.ToSingle(Console.ReadLine());
            Console.Write("Escriba la cantidad de lados del poligono:");
            cantLado = Convert.ToInt32(Console.ReadLine());

            perimetro = lado * cantLado;

            Console.WriteLine("El perimetro del poligono regular es: {0} unidades", perimetro);

            Console.ReadKey();

        }
    }
}
