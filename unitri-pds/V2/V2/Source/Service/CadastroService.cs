using System;
using V2.Source.Entity;

namespace V2.Forms.Cadastro
{
    internal class CadastroService
    {
        internal static void SalvarConveniada(string nome, string telefone)
        {
            Conveniada conveniada = new Conveniada();
            conveniada.Nome = nome;
            conveniada.Telefone = telefone;
            ConveniadaDAO.SalvarConveniada(conveniada);
        }
    }
}