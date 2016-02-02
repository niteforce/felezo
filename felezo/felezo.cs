using System;
using static System.Console;

namespace felezo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WriteLine("X hatvanya?:  ");
            var fokszam = int.Parse(ReadLine());
            Write("X^" + fokszam + " = ");
            var valtozo = float.Parse(ReadLine());


            WriteLine("Adj meg egy felso becslest!");
            var felso = float.Parse(ReadLine());
            WriteLine("Adj meg egy also becslest!");
            var also = float.Parse(ReadLine());


            float gyok;

            while (Math.Abs(also - felso) > 0.000001)
            {
                gyok = (also + felso) /2;

                if (Math.Pow(gyok, fokszam) - valtozo > 0)
                {
                    felso = gyok;
                }
                else
                {
                    also = gyok;
                }
            }

            WriteLine("X = " + (also + felso) /2);
            ReadLine();
        }
    }
}