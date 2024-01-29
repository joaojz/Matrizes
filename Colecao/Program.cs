﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Vetores
            //int numero = 0;

            //int[] numeros = new int[5];

            //numeros[0] = 10;
            //numeros[1] = 20;
            //numeros[2] = 30;
            //numeros[3] = 40;
            //numeros[4] = 50;

            //numeros[2] = 55;

            // string[] nomes = new string[3];
            //string[] nomes = {"Gabriel","Joao","Diego"};

            //nomes[0] = "Gabriel";
            //nomes[1] = "Vitor";
            //nomes[2] = "Diego";
            #endregion

            int[,] numeros = new int[2, 3];
            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;

            numeros[1, 0] = 40;
            numeros[1, 1] = 50;
            numeros[1, 2] = 60;

            Console.Write("[" + numeros[0, 0] + "]");
            Console.Write("[" + numeros[0, 1] + "]");
            Console.Write("[" + numeros[0, 2] + "]");

            Console.WriteLine();//para fazer a quebra de linha

            Console.Write("[" + numeros[1, 0] + "]");
            Console.Write("[" + numeros[1, 1] + "]");
            Console.WriteLine("[" + numeros[1, 2] + "]");

            Console.WriteLine();

            string[,] nomes =
            {
                {"Joao","Vitor","Gomes"},
                {"Pirlo","Xavi","Iniesta" }
            };
            Console.Write("[" + nomes [0,0]  + "]");
            Console.Write("[" + nomes [0, 1] + "]");
            Console.Write("[" + nomes [0, 2] + "]");

            Console.WriteLine();

            Console.Write("[" + nomes  [1, 0] + "]");
            Console.Write("[" + nomes  [1, 1] + "]");
            Console.Write("[" + nomes  [1, 2] + "]");


            Console.ReadKey();
        }
       
    }
}
