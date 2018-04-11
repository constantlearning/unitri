using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula05_ex01
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>

        /*
        Exercício1:
        Implementar um aplicativo Windows Forms para cadastro e manutenção
        (editar, deletar, listar) de dados de uma entidade Contato com atributos
        (Id, Nome, Endereço e Telefone) mantidos numa lista de contatos. Usar
        todos os componentes numa janela apenas.
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
