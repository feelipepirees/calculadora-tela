using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caulculadora_Tela
{
    class Model
    {
        public Model()
        {

        }



        public int Somar(int num1, int num2)
        {
            return num1 + num2;

        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public int multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public double dividir(int num1, int num2)
        {
            return num1 / num2;
        }

    }//fim do construtor
}