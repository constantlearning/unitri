﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Source.domain
{
    class Cliente
    {
        private Int32 id;
        private String nome;
        private String cpf;
        private DateTime nascimento;
        private Telefone telefone;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => validarCpf(value); }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        internal Telefone Telefone { get => telefone; set => telefone = value; }

        public Cliente()
        {
        }

        public Cliente(string nome, string cpf, DateTime nascimento)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.nascimento = nascimento;
        }

        private void validarCpf(string cpf)
        {
            validadeCpfSize(cpf);
            validateCpfDigits(cpf);
            this.cpf = cpf;
        }

        private void validateCpfDigits(string cpf)
        {
            if (!cpf.All(char.IsDigit))
            {
                throw new Exception("Valor inválido no CPF, inserir apenas números.");
            }
        }

        private void validadeCpfSize(string cpf)
        {
            if (cpf.Length != 11)
            {
                throw new Exception("O CPF precisa ter o tamanho de 11 digitos.");
            }
        }
    }
}
