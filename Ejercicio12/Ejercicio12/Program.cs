using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nom= "Wilkes";
            int NHT=45, VHN =54,HET=0, HEE8, Salario;
            if(NHT >40)
            {
                HET = NHT - 40;
                if (HET > 8)
                {
                    HEE8 = HET - 8;
                    Salario = 40 * VHN + 16 * VHN + HEE8 * 3 * VHN;
                }
                else
                {
                    Salario = 40 * VHN + HET * 2 * VHN;
                }
            }
            else
            {
                Salario = NHT * VHN;

            }
            Console.WriteLine("El trabajador " + Nom + "  Devengó: $" + Salario); 
        }
    }
}
