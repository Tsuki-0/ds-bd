using projeto_agenda.formularios;
using System;
using System.Windows.Forms;

namespace projeto_agenda
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDI_menu());
            Application.Run(new exibir());
        }
    }
}
