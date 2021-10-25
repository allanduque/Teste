using System;

namespace Desafio_Paradigma
{
    class Program
    {
        static void Main(string[] args)
        {
           // int[] tree = { 3,2,1,6,0,5 };
            int[] tree = { 7,5,13,9,1,6,4 };
            string result = Tree.GerarArvore(tree);
            Console.WriteLine(result);
        }

    }
}
