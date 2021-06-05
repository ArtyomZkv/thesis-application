using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace it_cube_application.Forms
{

    public partial class DirectionListWorkForm : Form
    {
        bool txbx_clear = false;
        Classes.DAL dal = new Classes.DAL();
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=root;database=it-cube");

        public DirectionListWorkForm()
        {
            InitializeComponent();
        }

        private void btn_getData_Click(object sender, EventArgs e)
        {
            string query = "select distinct date from academicperfomance order by date";
            string query1 = "Select name, diractionname, groupname from students, directions, globalgroup " +
                "where globalgrpID = groupid and iddirection = directionid";
            dal.GetAllData(query, dgv_dates);
            dal.SetDGVSetting(dgv_dates);
            dal.GetAllData(query1, dgv_students);
            dal.SetDGVSetting(dgv_students);
            txbx_nameSearch.Enabled = true;
            txbx_dateSearch.Enabled = true;
            cmbbx_directions.Enabled = true;
            cmbbx_groups.Enabled = true;
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            bool result = dal.MessageBoxShow();
            if (result == true)
            {
                connection.Close();
                Application.Exit();
            }
        }

        private void DirectionListWorkForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_it_cubeDataSet7.globalgroup". При необходимости она может быть перемещена или удалена.
            this.globalgroupTableAdapter1.Fill(this._it_cubeDataSet7.globalgroup);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_it_cubeDataSet6.directions". При необходимости она может быть перемещена или удалена.
            this.directionsTableAdapter2.Fill(this._it_cubeDataSet6.directions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_it_cubeDataSet3.globalgroup". При необходимости она может быть перемещена или удалена.
            //this.globalgroupTableAdapter.Fill(this._it_cubeDataSet3.globalgroup);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_it_cubeDataSet2.directions". При необходимости она может быть перемещена или удалена.
            //this.directionsTableAdapter1.Fill(this._it_cubeDataSet2.directions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_it_cubeDataSet1.directions". При необходимости она может быть перемещена или удалена.
            //this.directionsTableAdapter.Fill(this._it_cubeDataSet1.directions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_it_cubeDataSet.academicperfomance". При необходимости она может быть перемещена или удалена.
            //this.academicperfomanceTableAdapter.Fill(this._it_cubeDataSet.academicperfomance);
            txbx_academicId.Text = Guid.NewGuid().ToString();
        }

        private void add_direction_Click(object sender, EventArgs e)
        {
            Form AddDirection = new Forms.AddDirection();
            AddDirection.ShowDialog();
        }

        private void btn_studentsWorkForm_Click(object sender, EventArgs e)
        {
            Forms.StudentsWorkForm studentsWorkForm = new StudentsWorkForm();
            studentsWorkForm.Show();
            this.Hide();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btn_saveData_Click(object sender, EventArgs e)
        {
            txbx_academicId.Text = Guid.NewGuid().ToString();
            {
                connection.Open();
                MySqlCommand command1 = new MySqlCommand("insert into academicperfomance (idacademicperfomance, Idstudent, idproject, attendance, date) values (@idacademicperfomance, @Idstudent, @idproject, @attendance, @date)", connection);
                command1.Parameters.AddWithValue("idacademicperfomance", txbx_academicId.Text);
                command1.Parameters.AddWithValue("Idstudent", txbx_hideStudentsID.Text);
                command1.Parameters.AddWithValue("idproject", txbx_hideID.Text);
                command1.Parameters.AddWithValue("attendance", dgv_directionList.CurrentCell.Value.ToString());
                command1.Parameters.AddWithValue("date", dgv_dates.CurrentCell.Value.ToString());
                if (command1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные успешно добавлены");
                }
                else
                {
                    MessageBox.Show("Данные не добавлены!!!!");
                }
                connection.Close();
            }
        }

        private void cmbbx_directions_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                (dgv_students.DataSource as DataTable).DefaultView.RowFilter = $"groupname LIKE '{cmbbx_groups.Text}' AND diractionname LIKE'{cmbbx_directions.Text}'";
            }
            catch (Exception)
            {

            }
        }

        private void cmbbx_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            (dgv_students.DataSource as DataTable).DefaultView.RowFilter = $"groupname LIKE '{cmbbx_groups.Text}' AND diractionname LIKE'{cmbbx_directions.Text}'";
        }

        private void dgv_directionList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgv_dates.Rows[dgv_directionList.CurrentRow.Index].Selected = true;
            this.dgv_dates.CurrentCell = this.dgv_dates[0, dgv_directionList.CurrentRow.Index];
            txbx_selectedDate.Text = dgv_dates.CurrentCell.Value.ToString();
            //dgv_students.Rows[dgv_directionList.CurrentRow.Index].Selected = true;
            //dgv_students.Rows[dgv_directionList.CurrentRow.Index].Cells[0].Selected = true;
            try
            {
                txbx_attendanceValue.Text = dgv_directionList.CurrentCell.Value.ToString();
            }
            catch
            {

            }
            //for (int RowIndex = 0; RowIndex < dgv_directionList.Columns.Count; RowIndex++)
            //{
            // }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dal.UpdateRowInDirectionList(dgv_directionList.CurrentCell.Value.ToString(), txbx_hideStudentsID.Text.Trim(), dgv_dates.CurrentCell.Value.ToString()))
            {
                MessageBox.Show("Данные успешно изменены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dal.GetAllData($"select attendance from academicperfomance where Idstudent like '{txbx_hideStudentsID.Text}' order by date", dgv_directionList);
            }
            else
            {
                MessageBox.Show("Данные не удалось изменить!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Clear(DataGridView dgv_directionList)
        {
            while (dgv_directionList.Rows.Count > 1)
                for (int i = 0; i < dgv_directionList.Rows.Count - 1; i++)
                    dgv_directionList.Rows.Remove(dgv_directionList.Rows[i]);
        }

        private void dgv_students_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            connection.Open();
            {
                string query1 = $"select ID from students where name like '%{dgv_students.SelectedCells[0].Value}%'";
                MySqlCommand command = new MySqlCommand(query1, connection);
                MySqlDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    txbx_hideStudentsID.Text = id;
                }

            }
            connection.Close();
            connection.Open();
            {
                string query2 = $"select idproject from projects where idstudent like '%{txbx_hideStudentsID.Text}%'";
                MySqlCommand command = new MySqlCommand(query2, connection);
                MySqlDataReader reader;

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    txbx_hideID.Text = id;
                    txbx_clear = false;
                }
                if (reader.HasRows == false)
                {
                    txbx_hideID.Clear();
                    txbx_clear = true;
                }
                if (txbx_clear == true)
                {
                    if (MessageBox.Show("К данному студенту необходимо прикрепить проект", "Предупрждение", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        Form AddProject = new Forms.AddProject();
                        AddProject.ShowDialog();
                    }
                }
            }
            connection.Close();
            connection.Open();
            {
                string query3 = $"select projectname from projects where idproject LIKE '{txbx_hideID.Text}'";
                MySqlCommand command = new MySqlCommand(query3, connection);
                MySqlDataReader reader;

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    txbx_projectName.Text = name;
                }
            }
            connection.Close();
            string query = $"select attendance from academicperfomance where Idstudent like '{txbx_hideStudentsID.Text}' order by date";
            {
                dal.GetAllData(query, dgv_directionList);
                dal.SetDGVSetting(dgv_directionList);
            }
        }

        private void txbx_nameSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dgv_students.DataSource as DataTable).DefaultView.RowFilter = $"name LIKE '%{txbx_nameSearch.Text}%'";
            }
            catch (Exception)
            {
                //MessageBox.Show(ex, "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbx_dateSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dgv_dates.DataSource as DataTable).DefaultView.RowFilter = $"date LIKE'%{txbx_dateSearch.Text}%'";
            }
            catch (Exception)
            {
                //MessageBox.Show(ex, "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_directionList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgv_dates.CurrentCell = this.dgv_directionList.CurrentCell;
        }

        private void btn_changeDate_Click(object sender, EventArgs e)
        {
            if (dal.UpdateDateInDateList(txbx_attendanceValue.Text.Trim(), txbx_hideStudentsID.Text.Trim(), txbx_selectedDate.Text.Trim()))
            {
                MessageBox.Show("Данные успешно изменены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dal.GetAllData($"select date from academicperfomance where Idstudent like '{txbx_hideStudentsID.Text}' order by date", dgv_directionList);
            }
            else
            {
                MessageBox.Show("Данные не удалось изменить!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
