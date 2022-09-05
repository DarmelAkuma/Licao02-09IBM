using System;
using System.Collections.Generic;

namespace ContCaracter {
    class Program {
        static void Main(string[] args) {


            Console.WriteLine("Digite a mensagem: ");
            string[] frase;
            string Palavra = "";

            for (; ; )
            {
                frase = Console.ReadLine().Split(' ');
                if (frase[0] == "0") {                  
                    break;
                }
                string numLetras = "";

                for (int i = 0; i < frase.Length; i++) {
                    if (frase[i].Length >= Palavra.Length) {
                        Palavra = frase[i];
                    }
                    if (i == (frase.Length - 1)) {
                        numLetras += $"{frase[i].Length}";
                    }
                    else {
                        numLetras += $"{frase[i].Length}-";
                    }
                }

                Console.WriteLine("Numeros de caracteres: " + numLetras);
                Console.WriteLine("The biggest word: " + Palavra);
            }
        }
    }
}