using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelephoneDirectoryApp.AppForms;
using TelephoneDirectoryApp.Models;

namespace TelephoneDirectoryApp.CustomControls
{
    public partial class InfoUserControl : UserControl
    {
        private Subscribers _subscribers;
        private Users _currentUser;
        public InfoUserControl(Subscribers subscribers, Users currentUser)
        {
            InitializeComponent();
            _subscribers = subscribers;
            SetLabelTextValues();
            _currentUser = currentUser;
        }

        /// <summary>
        /// Выводит в label'ы информацию из базы данных
        /// </summary>
        private void SetLabelTextValues()

        {
            labelUsername.Text = _subscribers.Fio;
            labelWorkNumber.Text = $"Рабочий номер: {_subscribers.WorkPhoneNumber}";
            labelPersonalNumber.Text = $"Личный номер: {_subscribers.PersonalPhoneNumber}";
            labelEmail.Text = $"Адрес электронной почты: {_subscribers.EmailAdress}";
            labelPosition.Text = $"Должность: {_subscribers.Positions.PositionName}";
            labelDepartment.Text = $"Подразделение: {_subscribers.Departments.DepartmentName}";
            labelBuilding.Text = $"Корпус: {_subscribers.Buildings.BuildingName}";
            labelOffice.Text = $"Кабинет: {_subscribers.Offices.RoomNumber}";
        }

        private void dreamButtonChange_Click(object sender, EventArgs e)
        {
            MyCardForm myCardForm = new MyCardForm(_currentUser);
            myCardForm.ShowDialog();
        }
    }
}
