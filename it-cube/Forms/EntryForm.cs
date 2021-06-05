using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it_cube_application.Forms
{
    public partial class EntryForm : Form
    {
        private string login;
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }
        private bool isDragging = false;

        private Point lastCursor;
        private Point lastForm;
        bool isClickedLogin = false;
        bool isClickedPassword = false;
        public EntryForm()
        {
            InitializeComponent();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            String loginUser = txbx_login.Text;//создаём переменную для txbx с логином
            String passUser = txbx_password.Text;//создаём переменную для txbx с паролем
            Classes.DAL dal = new Classes.DAL();
            DataTable table = new DataTable();//выделяем память для переменной table (таблица данных). Нужна
            MySqlDataAdapter adapter = new MySqlDataAdapter();//объект класса MySqlDataAdapter. Класс отвечает за взаимодействие с источником данных
            MySqlCommand command = new MySqlCommand("SELECT * FROM `auth` WHERE `login` = @uL AND `password` = @uP", dal.GetConnection());//объект класса MySqlCommand. Класс позволяет обратиться к SQL DB через запросы
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;//изменяем параметр для логина. Считываем его с переменной loginUser
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;//изменяем параметр для пароля. Считываем его с переменной passUser
            adapter.SelectCommand = command;//указали объекту adapter, какую команду нужно выполнить
            adapter.Fill(table);//объект adapter выполняет заполнение таблицы (объекта table)
            if (table.Rows.Count > 0)//Проверка условия, есть ли в таблице (в объекте table) какие-лио записи
            {
                Forms.EntryForm entryForm = new EntryForm();
                entryForm.Login = txbx_login.Text.Trim();
                MessageBox.Show("Вход успешно выполнен!","", MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Вход не выполнен. Проверьте правильность введённых данных", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void txbx_login_Click(object sender, EventArgs e)
        {
            
            while (isClickedLogin != true)
            {
                txbx_login.Clear();
                isClickedLogin = true;
            }
        }
        private void txbx_password_Click(object sender, EventArgs e)
        {
            txbx_password.PasswordChar = '*';
            while (isClickedPassword != true)
            {
                txbx_password.Clear();
                isClickedPassword = true;
            }
        }

        private void btn_refreshLogin_Click(object sender, EventArgs e)
        {
            txbx_login.Clear();
            txbx_login.Focus();
        }

        private void btn_refreshPassword_Click(object sender, EventArgs e)
        {
            txbx_password.Clear();
            txbx_password.Focus();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            const string message = "Вы действительно хотите закрыть приложение?";//сообщение, которое будет выводиться
            const string caption = "Закрытие приложения";//заголовок для диалогового окна
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);//перегрузки: сообщение, заголовок, кнопки с ответами, иконка со знаком вопроса
            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }

        private void EntryForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txbx_login.Focus();
            }
            else
            if (e.KeyCode == Keys.Down)
            {
                txbx_password.Focus();
            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;

            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location =
                    Point.Add(lastForm, new Size(Point.Subtract(Cursor.Position, new Size(lastCursor))));
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        public string GetLogin()
        {
            return login;
        }
    }
}
