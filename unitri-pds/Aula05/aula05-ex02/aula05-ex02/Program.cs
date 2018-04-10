using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula05_ex02
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>

        /*
         Exercício2:
        Implementar um aplicativo Windows Forms para cadastro e manutenção
        (editar, deletar, listar) de dados de uma entidade Contato com atributos
        (Id, Nome, Endereço e Telefone). Usar duas janelas, sendo a principal com
        o componente de grid (DataGrid) para apresentar os Contatos armazenados
        numa lista de contatos, além de botões para apagar, editar, criar. Os
        componentes de dados do contato estarão em outra janela para cadastro e
        edição.
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
