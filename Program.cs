using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace aula_05032024._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            double vt;
            double vp;
            Console.Write("Valor da Diária: ");
            double vd = double.Parse(Console.ReadLine());//bruto
            Console.Write("Quantidade de adultos: ");
            double qa = double.Parse(Console.ReadLine());//+
            Console.Write("Quantidade de crianças: ");
            double qc = double.Parse(Console.ReadLine());//*vhe
            Console.Write("numero de dias hospedado: ");
            double nd = double.Parse(Console.ReadLine());//*he
            Console.Write("forma de pagamento: ");
            string fp= Console.ReadLine();

            //Processamento
            vd = (vd * qa) + (vd * qc / 2);
            vt = vd;

            

            if (fp == "d")
            {
                vt = vt - (vt / 100 * 10);

            }
            else if (fp == "cd")
            {
                vt = nd * (vt - (vt / 100 * 5));
            }
            else
            {
                Console.WriteLine("quantas parcelas:");
                int p = int.Parse(Console.ReadLine());
                if (p < 5)
                {
                    vp = vt / p;
                }
                else
                {
                    vp = (vt + (vt / 100 * 10))/p;
                }
                Console.WriteLine("valor de parcelas a pagar: " + vp);
            }
            //Saída

            Console.WriteLine("valor da diaria da familia: " + vd);
            Console.Write("valor da total a pagar: " + vt);
            
            //Encerramento

            Console.ReadKey();
        }
    }
}
