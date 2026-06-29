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

namespace TelephoneDirectoryApp.AppForms
{
    public partial class LoginForm : Form
    {
        Users currentUser = null;
        public LoginForm()
        {
            InitializeComponent();
            hopeTextBoxPassword.PasswordChar = '*';
            pictureBoxVisible.Visible = false;
            pictureBoxUnvisible.Visible = true;
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

        private void ValidatePassword()
        {
            ValidateGeneral(hopeTextBoxPassword.Text, "Пароль");
        }

        private void Validate()
        {
            ValidatePassword();
            ValidateEmail();
        }

        /// <summary>
        /// Проверка данных для входа в аккаунт
        /// </summary>
        /// <param name="email">e-mail юзера</param>
        /// <param name="password">пароль юзера</param>
        /// <returns>возвращает true если пароль и e-mail совпадают с DB</returns>
        public static bool CheckLogin(string email, string password)
        {
            List<Users> users = Program.context.Users.ToList();
            foreach (var user in users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return true;
                }
            }

            return false;
        }

        private void dreamButtonLogin_Click(object sender, EventArgs e)
        {
            //Валидация
            try
            {
                Validate();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Вход в аккаунт
            List<Users> users = Program.context.Users.ToList();
            string email = hopeTextBoxEmail.Text.Trim();

            string password = hopeTextBoxPassword.Text;

            bool found = false;
            foreach (var user in users)
            {
                if (user.Email == email && user.Password == password)
                {
                    found = true;
                    currentUser = user;

                    break;
                }
            }

            if (found)
            {
                MainForm mainForm = new MainForm(currentUser);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Неверный e-mail или пароль.");
            }
        }

        private void pictureBoxVisible_Click(object sender, EventArgs e)
        {
            hopeTextBoxPassword.PasswordChar = '*';

            pictureBoxVisible.Visible = false;
            pictureBoxUnvisible.Visible = true;
        }

        private void pictureBoxUnvisible_Click(object sender, EventArgs e)
        {
            hopeTextBoxPassword.PasswordChar = '\0';

            pictureBoxVisible.Visible = true;
            pictureBoxUnvisible.Visible = false;
        }

        private void dreamButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
