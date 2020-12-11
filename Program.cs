using System;
using AulaPOO_PolimosrfismoSobreposicao.Classes;

namespace AulaPOO_PolimosrfismoSobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan jogador = new MegaMan();
           Console.WriteLine($"jogador 1 = {jogador.Correr()}");

           Zero jogador2 = new Zero();
           Console.WriteLine($"Jogador 2 = {jogador2.Correr()}");
        }
    }
}
