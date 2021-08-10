using System;
using GameTOP.Interface;

namespace GameTOP.Lib
{
   public class Jogador1 : iJogador
    {
        public readonly string _Nome;
        public Jogador1(string nome = "Vinixius")
        {
            _Nome = nome;
        }

        public string Chuta()
        {
             return $"{_Nome} esta Chutando \n";
        }
         public string Corre()
         {
              return $"{_Nome} esta Correndo \n";
         }
         public string Passa()
         {
              return $"{_Nome} esta Passando \n";
         }
    }
}