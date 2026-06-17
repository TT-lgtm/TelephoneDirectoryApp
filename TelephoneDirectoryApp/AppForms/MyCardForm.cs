using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using TelephoneDirectoryApp.Models;

namespace TelephoneDirectoryApp.AppForms
{
    public partial class MyCardForm : Form
    {
        private Users _currentUser;
        private Subscribers _subscribers;
        public MyCardForm(Users users)
        {
            InitializeComponent();
            _currentUser = users;

            labelFIO.TextAlign = ContentAlignment.MiddleCenter;
            dreamButtonSave.Visible = false;
            hopeTextBoxWorkNumber.Visible = false;
            hopeTextBoxPersonalNumber.Visible = false;
            hopeTextBoxEmail.Visible = false;
            hopeComboBoxPosition.Visible = false;
            hopeComboBoxDepartment.Visible = false;
            hopeComboBoxBuilding.Visible = false;
            hopeComboBoxOffice.Visible = false;

            dreamButtonSave.Visible = false;

            ShowUserInfo();
        }

        public MyCardForm(Subscribers subscribers)
        {
            InitializeComponent();

            _subscribers = subscribers;

            labelFIO.TextAlign = ContentAlignment.MiddleCenter;
            dreamButtonSave.Visible = false;
            hopeTextBoxWorkNumber.Visible = false;
            hopeTextBoxPersonalNumber.Visible = false;
            hopeTextBoxEmail.Visible = false;
            hopeComboBoxPosition.Visible = false;
            hopeComboBoxDepartment.Visible = false;
            hopeComboBoxBuilding.Visible = false;
            hopeComboBoxOffice.Visible = false;

            dreamButtonSave.Visible = false;

            ShowUserInfo();
        }

        /// <summary>
        /// Заполняет информацию о пользователе в label'ы
        /// </summary>
        private void ShowUserInfo()
        {
            var subscriber = Program.context.Subscribers.FirstOrDefault(s => s.UserId == _currentUser.IdUser);

            if (subscriber != null)
            {
                
                labelFIO.Text = $"{subscriber.Fio}";
                labelWorkNumber.Text = $"Рабочий номер: {subscriber.WorkPhoneNumber}";
                labelPersonalNumber.Text = $"Личный номер: {subscriber.PersonalPhoneNumber}"; 
                labelEmail.Text = $"Адрес электронной почты: {subscriber.EmailAdress}"; 
                labelPosition.Text = $"Должность: {subscriber.Positions.PositionName}"; 
                labelDepartment.Text = $"Подразделение: {subscriber.Departments.DepartmentName}"; 
                labelBuilding.Text = $"Корпус: {subscriber.Buildings.BuildingName}"; 
                labelOffice.Text = $"Кабинет: {subscriber.Offices.RoomNumber}"; 
            }
            else 
            { 
                MessageBox.Show("Не удалось получить данные. Попробуйте позже.");
                return;
            }
        }

        /// <summary>
        /// Заполняет TextBox'ы при нажатии кнопки "Изменить"
        /// </summary>
        private void FillEditFields()
        {
            var subscriber = Program.context.Subscribers.FirstOrDefault(s => s.UserId == _currentUser.IdUser);

            if (subscriber != null)
            {

                hopeTextBoxWorkNumber.Text = subscriber.WorkPhoneNumber;
                hopeTextBoxPersonalNumber.Text = subscriber.PersonalPhoneNumber;
                hopeTextBoxEmail.Text = subscriber.EmailAdress;
                hopeComboBoxPosition.Text = subscriber.Positions.PositionName;
                hopeComboBoxDepartment.Text = subscriber.Departments.DepartmentName;
                hopeComboBoxBuilding.Text = subscriber.Buildings.BuildingName;
                hopeComboBoxOffice.Text = subscriber.Offices.RoomNumber;
            }
            else
            {
                MessageBox.Show("Не удалось получить данные. Попробуйте позже.");
                return;
            }

        }

        private void dreamButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dreamButtonChange_Click(object sender, EventArgs e)
        {
            dreamButtonChange.Visible = false;
            dreamButtonSave.Visible = true;

            dreamButtonSave.Visible = true;
            hopeTextBoxWorkNumber.Visible = true;
            hopeTextBoxPersonalNumber.Visible = true;
            hopeTextBoxEmail.Visible = true;
            hopeComboBoxPosition.Visible = true;
            hopeComboBoxDepartment.Visible = true;
            hopeComboBoxBuilding.Visible = true;
            hopeComboBoxOffice.Visible = true;

            labelWorkNumber.Text = $"Рабочий номер: ";
            labelPersonalNumber.Text = $"Личный номер: ";
            labelEmail.Text = $"Адрес электронной почты: ";
            labelPosition.Text = $"Должность: ";
            labelDepartment.Text = $"Подразделение: ";
            labelBuilding.Text = $"Корпус: ";
            labelOffice.Text = $"Кабинет: ";
        }

        private void dreamButtonSave_Click(object sender, EventArgs e)
        {

            var subscriber = Program.context.Subscribers.FirstOrDefault(s => s.UserId == _currentUser.IdUser);

            subscriber.WorkPhoneNumber = hopeTextBoxWorkNumber.Text.Trim();
            subscriber.PersonalPhoneNumber = hopeTextBoxPersonalNumber.Text.Trim();
            subscriber.EmailAdress = hopeTextBoxEmail.Text.Trim();
            subscriber.PositionId = (int)this.hopeComboBoxPosition.SelectedValue;
            subscriber.DepartmentId = (int)this.hopeComboBoxDepartment.SelectedValue;
            subscriber.BuildingId = (int)this.hopeComboBoxBuilding.SelectedValue;
            subscriber.OfficeId = (int)this.hopeComboBoxOffice.SelectedValue;

            Program.context.SaveChanges();

            dreamButtonSave.Visible = false;
            hopeTextBoxWorkNumber.Visible = false;
            hopeTextBoxPersonalNumber.Visible = false;
            hopeTextBoxEmail.Visible = false;
            hopeComboBoxPosition.Visible = false;
            hopeComboBoxDepartment.Visible = false;
            hopeComboBoxBuilding.Visible = false;
            hopeComboBoxOffice.Visible = false;

            dreamButtonChange.Visible = true;
            dreamButtonSave.Visible = false;

            ShowUserInfo();
        }

        private void MyCardForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telephone_directory_DBDataSet.Offices". При необходимости она может быть перемещена или удалена.
            this.officesTableAdapter.Fill(this.telephone_directory_DBDataSet.Offices);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telephone_directory_DBDataSet.Buildings". При необходимости она может быть перемещена или удалена.
            this.buildingsTableAdapter.Fill(this.telephone_directory_DBDataSet.Buildings);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telephone_directory_DBDataSet.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.telephone_directory_DBDataSet.Departments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telephone_directory_DBDataSet.Positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.telephone_directory_DBDataSet.Positions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telephone_directory_DBDataSet.Subscribers". При необходимости она может быть перемещена или удалена.
            this.subscribersTableAdapter.Fill(this.telephone_directory_DBDataSet.Subscribers);

        }
    }
}
