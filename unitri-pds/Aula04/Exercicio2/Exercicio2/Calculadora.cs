using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Calculadora
    {

        private Int32 firstNumber;
        private Int32 secondNumber;

        public int FirstNumber { get => firstNumber; set => firstNumber = value; }
        public int SecondNumber { get => secondNumber; set => secondNumber = value; }

        public Calculadora(Int32 first, Int32 second)
        {
            FirstNumber = first;
            SecondNumber = second;
        }

        public Int32 calcular(Operation operation)
        {
            switch (operation)
            {
                case Operation.SOMAR:
                    return somar();
                case Operation.SUBTRAIR:
                    return subtrair();
                case Operation.MULTIPLICAR:
                    return multiplicar();
                case Operation.DIVIDIR:
                    return dividir();
                default:
                    throw new Exception("Operation not especified!");
            }
        }

        private Int32 somar()
        {
            return this.FirstNumber + this.SecondNumber;
        }

        private Int32 subtrair()
        {
            return this.FirstNumber - this.SecondNumber;
        }

        private Int32 multiplicar()
        {
            return this.FirstNumber * this.SecondNumber;
        }

        private Int32 dividir()
        {
            return this.FirstNumber / this.SecondNumber;
        }

    }

}
