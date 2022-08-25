using System;

namespace SomaDeImparesConsecutivos
{
    class Program
    {
        static void Main(string[] args){
            int[] numeros = new int[2];
            for (int p = 0; p < numeros.Length; p++)
                numeros[p]= Convert.ToInt32(Console.ReadLine());
            Array.Sort(numeros);
            var soma = 0;
            for (int i = numeros[0] + 1; i < numeros[1]; i++){
                if (i % 2 != 0)
                    soma = i + soma;
            }
            Console.WriteLine(soma);
        }
    }
}

