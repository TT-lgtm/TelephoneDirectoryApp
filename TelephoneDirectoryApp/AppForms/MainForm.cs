using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelephoneDirectoryApp.Models;
using TelephoneDirectoryApp.CustomControls;

namespace TelephoneDirectoryApp.AppForms
{
    public partial class MainForm : Form
    {
        private Users _currentUser;
        public MainForm(Users user)
        {
            InitializeComponent();
            ShowSubscribers();
            this.WindowState = FormWindowState.Maximized;
            _currentUser = user;
            ShowGreeting();
        }

        /// <summary>
        /// Выводит на панель FlowLayout все карточки пользователей
        /// </summary>
        private void ShowSubscribers()
        {
            List<Subscribers> subscribers = Program.context.Subscribers.OrderBy(r => r.Fio).ToList();

            foreach (Subscribers subscriber in subscribers)
            {
                flowLayoutPanelMain.Controls.Add(new InfoUserControl(subscriber, _currentUser));
            }
        }

        private void ShowSubscribersFilter(string search = "")
        {
            flowLayoutPanelMain.Controls.Clear();

            var subscribers = Program.context.Subscribers.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();

                subscribers = subscribers.Where(s =>
                    s.Fio.Contains(search) ||
                    s.Positions.PositionName.Contains(search) ||
                    s.Departments.DepartmentName.Contains(search) ||
                    (s.WorkPhoneNumber ?? "").Contains(search) ||
                    (s.PersonalPhoneNumber ?? "").Contains(search) ||
                    (s.EmailAdress ?? "").Contains(search));
            }

            foreach (Subscribers subscriber in subscribers.OrderBy(s => s.Fio).ToList())
            {
                flowLayoutPanelMain.Controls.Add(new InfoUserControl(subscriber, _currentUser));
            }
        }

        public void Refresh()
        {
            flowLayoutPanelMain.Controls.Clear();
            ShowSubscribers();
        }

        /// <summary>
        /// Приветствие пользователя
        /// В зависимости от времени суток приветствует пользователя с учётом его username
        /// </summary>
        private void ShowGreeting()
        {
            int hour = DateTime.Now.Hour;

            string greeting = "";

            if (hour >= 5 && hour < 12)
            {
                greeting = "Доброго утра";
            }
            else if (hour >= 12 && hour < 18)
            {
                greeting = "Доброго дня";
            }
            else
            {
                greeting = "Доброго вечера";
            }

            GreetingLabel.Text = greeting + ", " + _currentUser.Username + "!";
        }

        private void dreamButtonRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void dreamButton1_Click(object sender, EventArgs e)
        {
            MyCardForm myCardForm = new MyCardForm(_currentUser);
            myCardForm.ShowDialog();
        }

        private void dreamButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hopeTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ShowSubscribersFilter(hopeTextBoxSearch.Text);
        }
    }
}
