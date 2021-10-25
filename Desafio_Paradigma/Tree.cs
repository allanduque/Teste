using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Paradigma
{
    public class Tree
    {
        internal static string GerarArvore(int[] entrada)
        {
            int maiorValor = 0;
            ArrayList galhoEsq = new ArrayList();
            ArrayList galhoDir = new ArrayList();
            //localiza o nó
            foreach (int item in entrada)
            {
                if (item > maiorValor) maiorValor = item;
            }

            if (entrada[0] != maiorValor)
            {
                for (int i = 0; entrada[i] != maiorValor; i++)
                {
                    galhoEsq.Add(entrada[i]);
                }
            }

            if (entrada[entrada.Length-1] != maiorValor)
            {
                for (int i = entrada.Length-1; entrada[i] != maiorValor; i--)
                {
                    galhoDir.Add(entrada[i]);
                }
            }

            galhoEsq.Sort();
            galhoDir.Sort();
            galhoEsq.Reverse();
            galhoDir.Reverse();
            string resp = "Array de entrada\n" +
                "Raiz: " + maiorValor +
                "\n Galhos da esquerda: "+ PrintGalho(galhoEsq) +
                "\n Galhos da direita: " + PrintGalho(galhoDir);
            return resp;
        }

        private static string PrintGalho(ArrayList galho)
        {
            string resp = string.Empty;

            foreach (int item in galho)
            {
                resp += item + ", ";
            }
            return resp.Substring(0, resp.Length - 2);
        }
    }
}
