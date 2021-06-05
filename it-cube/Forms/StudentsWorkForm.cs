using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace it_cube_application.Forms
{

    public partial class StudentsWorkForm : Form
    {
        private bool isDragging = false;

        private Point lastCursor;
        private Point lastForm;
        //bool Formshow = false;
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=root;database=it-cube");
        Classes.DAL dal = new Classes.DAL();
        public StudentsWorkForm()
        {
            InitializeComponent();
        }

        private void btn_addProject_Click(object sender, System.EventArgs e)
        {
            Form AddProject = new Forms.AddProject();
            AddProject.ShowDialog();
 
            /*if (Formshow == true)
            {
                AddProject.Close();
              
            }
            Formshow = true; */


        }

        private void btn_home_Click(object sender, EventArgs e)
        {
           var result = MessageBox.Show("Вернуться на главную страницу?", "Начальная страница", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Close();
                connection.Close();
            }
        }

        private void btn_takeData_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("Select name, groupname, diractionname, dateofbirth, parentsname, district, city, email, date, parentsphone  from students, globalgroup, directions where globalgrpID = groupid and iddirection = directionid", connection);
                DataTable table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                dgv_students.DataSource = table;
               
            }
            catch
            {
                MessageBox.Show("Произошла ошибка. Данные уже загружены", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (connection.State == ConnectionState.Open)
            {
                txbx_citySearch.Enabled = true;
                cmbbx_directionSearch.Enabled = true;
                txbx_nameSearch.Enabled = true;
                cmbbx_groupSearch.Enabled = true;
                обновитьДанныеВТаблицеToolStripMenuItem.Enabled = true;
            }
        }

        private void толькоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                MySqlDataAdapter adapter = new MySqlDataAdapter("Select name, dateofbirth from students", connection);
                DataTable table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                dgv_students.DataSource = table;
                
            }
            catch
            {
                MessageBox.Show("Сначала необходимо получить данные из базы данных", "Ошибка отображения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void поФИОРодителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter("Select name, parentsname, parentsphone from students", connection);
                DataTable table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                dgv_students.DataSource = table;

            }
            catch
            {
                MessageBox.Show("Сначала необходимо получить данные из базы данных", "Ошибка отображения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void поРайонуПроживанияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter("Select name, district from students", connection);
                DataTable table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                dgv_students.DataSource = table;

            }
            catch
            {
                MessageBox.Show("Сначала необходимо получить данные из базы данных", "Ошибка отображения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void поГородуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter("Select name, city from students", connection);
                DataTable table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                dgv_students.DataSource = table;

            }
            catch
            {
                MessageBox.Show("Сначала необходимо получить данные из базы данных", "Ошибка отображения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void поНомеруТелефонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter("Select name, phone from students", connection);
                DataTable table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                dgv_students.DataSource = table;

            }
            catch
            {
                MessageBox.Show("Сначала необходимо получить данные из базы данных", "Ошибка отображения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void поEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter("Select name, email from students", connection);
                DataTable table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                dgv_students.DataSource = table;

            }
            catch
            {
                MessageBox.Show("Сначала необходимо получить данные из базы данных", "Ошибка отображения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void поДатеЗачисленияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter("Select name, date from students", connection);
                DataTable table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                dgv_students.DataSource = table;

            }
            catch
            {
                MessageBox.Show("Сначала необходимо получить данные из базы данных", "Ошибка отображения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void поНомеруГруппыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("select name, groupname from students, globalgroup where globalgrpID = groupid", connection);
                
                DataTable table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                dgv_students.DataSource = table;
            }
            catch
            {
                MessageBox.Show("Сначала необходимо получить данные из базы данных", "Ошибка отображения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void поНапрвлениюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("select name, diractionname from students, directions where iddirection = directionid", connection);

                DataTable table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                dgv_students.DataSource = table;
            }
            catch
            {
                MessageBox.Show("Сначала необходимо получить данные из базы данных", "Ошибка отображения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
           bool result = dal.MessageBoxShow();
            if (result == true)
            {
                connection.Close();
                Application.Exit();
            }
        }

        private void btn_billWork_Click(object sender, EventArgs e)
        {
            Forms.DirectionListWorkForm directionListWorkForm = new DirectionListWorkForm();
            directionListWorkForm.Show();
            connection.Close();
            this.Close();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txbx_nameSearch_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                (dgv_students.DataSource as DataTable).DefaultView.RowFilter = $"name LIKE '%{txbx_nameSearch.Text}%'";
            }
            catch(Exception)
            {
                //MessageBox.Show(ex, "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }


        private void cmbbx_groupSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                (dgv_students.DataSource as DataTable).DefaultView.RowFilter = $"groupname LIKE '{cmbbx_groupSearch.Text}' AND diractionname LIKE '{cmbbx_directionSearch.Text}'";
            }
            catch
            {

            }
        }

        private void btn_refreshLogin_Click(object sender, EventArgs e)
        {
            txbx_nameSearch.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbbx_directionSearch.Text= "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbbx_groupSearch.Text = "";
            //DataTable table = new DataTable();
            //dgv_students.DataSource = table;
            //table.Rows.RE
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txbx_citySearch.Clear();
        }

        private void txbx_citySearch_TextChanged(object sender, EventArgs e)
        {
            (dgv_students.DataSource as DataTable).DefaultView.RowFilter = $"city LIKE '%{txbx_citySearch.Text}%'";
        }
        
        private void StudentsWorkForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_it_cubeDataSet5.directions". При необходимости она может быть перемещена или удалена.
            this.directionsTableAdapter.Fill(this._it_cubeDataSet5.directions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_it_cubeDataSet4.globalgroup". При необходимости она может быть перемещена или удалена.
            this.globalgroupTableAdapter.Fill(this._it_cubeDataSet4.globalgroup);
            if (connection.State == ConnectionState.Closed)
            {
                txbx_citySearch.Enabled = false;
                cmbbx_directionSearch.Enabled = false;
                txbx_nameSearch.Enabled = false;
                cmbbx_groupSearch.Enabled = false;
                обновитьДанныеВТаблицеToolStripMenuItem.Enabled = false;
            }

        }

        private void txbx_nameSearch_Click(object sender, EventArgs e)
        {
        }

        private void обновитьДанныеВТаблицеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("Select name, groupname, diractionname, dateofbirth, parentsname, district, city, email, date, parentsphone  from students, globalgroup, directions where globalgrpID = groupid and iddirection = directionid", connection);
                DataTable table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                dgv_students.DataSource = table;

            }
            catch
            {

            }
            if (connection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Ошибка. Соединение с базой данных не установлена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgv_students_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgv_students.CurrentRow.Cells[].Value=
        }

        private void поНомеруГруппыИНаправлениюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("select name, diractionname, groupname from students, directions, globalgroup where iddirection = directionid and globalgrpID = groupid", connection);

                DataTable table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                dgv_students.DataSource = table;
            }
            catch
            {
                MessageBox.Show("Сначала необходимо получить данные из базы данных", "Ошибка отображения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbbx_directionSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                (dgv_students.DataSource as DataTable).DefaultView.RowFilter = $"groupname LIKE '{cmbbx_groupSearch.Text}' AND diractionname LIKE '{cmbbx_directionSearch.Text}'";
            }
            catch
            {

            }
        }
        

        private void txbx_citySearch_Click(object sender, EventArgs e)
        {
            txbx_citySearch.Clear();
            cmbbx_groupSearch.Text = "";
            cmbbx_directionSearch.Text = "";
        }
    }
}
