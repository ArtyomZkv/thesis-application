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
    public partial class AddProject : Form
    {
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=root;database=it-cube");
        private bool isDragging = false;

        private Point lastCursor;
        private Point lastForm;
        public AddProject()
        {

            InitializeComponent();
            FillCombo();
            txbx_ID.Text = Guid.NewGuid().ToString();


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
           
            Forms.StudentsWorkForm studentsWorkForm = new StudentsWorkForm();
            this.Close();
        }

        private void AddProject_Load(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                string query = "select name from students";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader;
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string Name = dataReader.GetString("name");
                    cmbx_studentName.Items.Add(Name);

                }
            connection.Close();
             }
             catch
            {
              MessageBox.Show("Ошибка, проверьте подключение с базой данных");
            }
        }
        void FillCombo()
        {

            
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                MySqlCommand command = new MySqlCommand("insert into projects (idproject, projectname, idstudent) VALUES (@idproject, @projectname, @idstudent)", connection);
                command.Parameters.AddWithValue("idproject", txbx_ID.Text);
                command.Parameters.AddWithValue("projectname", txbx_projectName.Text);
                command.Parameters.AddWithValue("idstudent", txbx_hideID.Text);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные успешно добавлены");
                }
                else
                {
                    MessageBox.Show("Данные не добавлены!!!!");
                }
                connection.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cmbx_studentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = $"select ID from students, projects where name like '%{cmbx_studentName.Text}%'";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    txbx_hideID.Text = id;
                }
            connection.Close();
           

            

            /*try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string sID = reader.GetString("ID");
                    txbx_hideID.Text = sID;
                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            */


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
