//tipo valor armazenado na memória, não herdam,
using System.Net;
using System.Runtime.Intrinsics.X86;

namespace _0_1_Estrutura_passagem
{
    quando você copia uma internal struct, uma nova cópia independente dos dados originais é criada.

    internal struct Polegada
    {
        private double cm; //não pode atribuir valor diferente de classe
        private double pol;

        public Polegada(double polegadas)
        {
            cm = 2.54;
            pol = cm * polegadas;
        }

        public double GetPolegada()
        { return pol; }
    }
}