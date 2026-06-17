using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelephoneDirectoryApp.AppForms;
using TelephoneDirectoryApp.Models;

namespace TelephoneDirectoryApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>

        public static PhoneDirectoryModel context = new PhoneDirectoryModel();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

            if (!context.Database.Exists())
            {
                MessageBox.Show("Не удаётся установить соединение с базой данных.");
                return;
            }
        }
    }
}
