using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using TelephoneDirectoryApp.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            hopeTextBoxFIO.Visible = false;
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
            hopeTextBoxFIO.Visible = false;
            hopeComboBoxPosition.Visible = false;
            hopeComboBoxDepartment.Visible = false;
            hopeComboBoxBuilding.Visible = false;
            hopeComboBoxOffice.Visible = false;

            dreamButtonSave.Visible = false;

            ShowUserInfo();
        }

        private void ValidateGeneral(string userInputText, string field, string messageAboutAllowedSymbols = "поле не должно быть пустым.", string pattern = @"^.+$")
        {
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            bool isValid = regex.IsMatch(userInputText.Trim());
            if (!isValid)
            {
                throw new ValidationException($"{field}: {messageAboutAllowedSymbols}");
            }
        }

        private void ValidateFIO()
        {
            ValidateGeneral(hopeTextBoxFIO.Text, "ФИО");
        }

        private void PersonalNumber()
        {
            ValidateGeneral(hopeTextBoxPersonalNumber.Text, "Личный номер");
        }

        /// <summary>
        /// Валидация электронной почты
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        private void ValidateEmail()
        {
            if (!IsValidEmail(hopeTextBoxEmail.Text.Trim()))
            {
                throw new ValidationException("Неверный формат электронной почты");
            }
        }
        private void Validate()
        {
            ValidateFIO();
            PersonalNumber();
            ValidateEmail();
        }

        /// <summary>
        /// Заполняет информацию о пользователе в label'ы
        /// </summary>
        private void ShowUserInfo()
        {
            Validate();
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
            hopeTextBoxFIO.Visible = true;
            hopeComboBoxPosition.Visible = true;
            hopeComboBoxDepartment.Visible = true;
            hopeComboBoxBuilding.Visible = true;
            hopeComboBoxOffice.Visible = true;

            labelWorkNumber.Text = $"Рабочий номер: ";
            labelFIO.Text = "";
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
            subscriber.Fio = hopeTextBoxFIO.Text.Trim();
            subscriber.PositionId = (int)this.hopeComboBoxPosition.SelectedValue;
            subscriber.DepartmentId = (int)this.hopeComboBoxDepartment.SelectedValue;
            subscriber.BuildingId = (int)this.hopeComboBoxBuilding.SelectedValue;
            subscriber.OfficeId = (int)this.hopeComboBoxOffice.SelectedValue;

            Program.context.SaveChanges();

            dreamButtonSave.Visible = false;
            hopeTextBoxWorkNumber.Visible = false;
            hopeTextBoxPersonalNumber.Visible = false;
            hopeTextBoxEmail.Visible = false;
            hopeTextBoxFIO.Visible = false;
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
