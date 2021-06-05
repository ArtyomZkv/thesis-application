using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Drawing;

namespace it_cube_application
{

    public partial class MainForm : Form
    {
        private bool isDragging = false;

        private Point lastCursor;
        private Point lastForm;


        Classes.DAL dAL = new Classes.DAL();
        Forms.StudentsWorkForm studentsWorkForm = new Forms.StudentsWorkForm();
        public MainForm()
        {
            InitializeComponent();
        }


        private void btn_studentsWork_Click(object sender, EventArgs e)
        {
            Form studentsWorkForm = new Forms.StudentsWorkForm();
            studentsWorkForm.Show();
            this.Close();
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            string message = "Вы действительно хотите выйти из учётной записи?";
            string caption = "Выход из учётной записи";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);//перегрузки: сообщение, заголовок, кнопки с ответами, иконка со знаком вопроса
            if (result == DialogResult.Yes)
            {
                Forms.EntryForm entryForm = new Forms.EntryForm();
                entryForm.Show();
                this.Close();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            bool result;
            result = dAL.MessageBoxShow();
            if (result == true)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn_billWork_Click(object sender, EventArgs e)
        {
            Forms.DirectionListWorkForm directionListWorkForm = new Forms.DirectionListWorkForm();
            directionListWorkForm.Show();
            this.Close();
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

        private void btn_helpOpen_Click(object sender, EventArgs e)
        {
            Forms.Help help = new Forms.Help();
            help.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Forms.EntryForm entryForm = new Forms.EntryForm();
            textBox1.Text = entryForm.Login;
        }
    }
}

