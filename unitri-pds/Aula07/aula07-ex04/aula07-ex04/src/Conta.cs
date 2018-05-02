using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula07_ex04.src
{
    class Conta
    {
        private Int32 agencia;
        private Double limite;
        private Int32 numero;
        private Double saldo;

        public Conta()
        {
        }

        public Conta(int agencia, double limite, int numero, double saldo)
        {
            Agencia = agencia;
            Limite = limite;
            Numero = numero;
            Saldo = saldo;
        }

        public int Agencia { get => agencia; set => agencia = value; }
        public double Limite { get => limite; set => limite = value; }
        public int Numero { get => numero; set => numero = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public void Depositar(Double valor)
        {
            if(valor > 0)
            {
                Saldo += valor;
            }
        }

        public void Sacar(Double valor)
        {
            if (valor > Limite || valor > saldo)
            {
                throw new Exception("Saque não efetuado, limite ultrapassado!");
            }

            Saldo -= valor;
        }

        public override string ToString()
        {
            return "Agência: " + Agencia + " Conta: " + Numero;
        }
    }
}
