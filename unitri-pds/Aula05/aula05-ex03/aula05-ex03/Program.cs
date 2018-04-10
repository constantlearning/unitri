using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula05_ex03
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>

        /*
         Exercício3:
        Implementar um sistema que controla uma simples agenda de contatos. O
        formulário principal deverá mostrar a listagem de Contatos (numa Grade) e
        deverá ter controles (botões) para permitir adicionar contados, apagar
        contato, e editar contato. Para adicionar e/ou editar contato um novo
        formulário deverá ser apresentado com os dados do contato. Nesse novo
        formulário os dados como nome, e endereço deverão aparecer diretamente
        no form com uma listagem dos telefones num controle ListBox. Para
        adicionar telefone um novo formulário deverá ser mostrado. Para apagar
        telefone a seleção e o clique num botão deverão resolver. O sistema deverá
        ter as classes abaixo:
         */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
