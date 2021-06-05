using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;

namespace it_cube_application.Classes
{
    class DAL
    {
        //DAL dal = new DAL();
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=root;database=it-cube");
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        public bool MessageBoxShow()
        {
            string message = "Вы действительно хотите закрыть приложение?"; 
            string caption = "Закрытие приложения";
            bool closeResult = false;
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);//перегрузки: сообщение, заголовок, кнопки с ответами, иконка со знаком вопроса
            if (result == DialogResult.Yes)
            {
                closeResult = true;
            }
            return closeResult;
        }
        public void GetDataVertical(DataGridView dataGridView, String query, MySqlConnection connection)
        {
            ArrayList empty = new ArrayList();
            dataGridView.DataSource = empty;
            var list = new List<string>();
            using (connection)
            {
                using (var command = new MySqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(0));
                    }
                }
                var dt = new DataTable();
                for (int i = 0; i < list.Count; i++)
                {
                    dt.Columns.Add(i.ToString());
                }
                dt.Rows.Add(list.ToArray());
                dataGridView.DataSource = dt;
                dataGridView.ColumnHeadersVisible = false;
                dataGridView.RowHeadersVisible = false;
                dataGridView.AllowUserToAddRows = false;
            }
        }
        public void GetAllData(string query, DataGridView dataGridView)
        {
            using (connection)
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
            }
        }
        public void SetDGVSetting(DataGridView dataGridView)
        {
            dataGridView.ColumnHeadersVisible = false;
            dataGridView.RowHeadersVisible = false;
            //dataGridView.AllowUserToAddRows = false;
        }
        public bool UpdateRowInDirectionList(string attendanceValue, string studentID, string date)
        {
            bool flagresult = false;
            string query = string.Format("update academicperfomance set attendance = '{0}' where Idstudent = '{1}' and date = '{2}'", attendanceValue, studentID, date);
            MySqlCommand command = new MySqlCommand(query, connection);
            using (connection)
            {
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        flagresult = true;
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
                return flagresult;
        }
        public bool UpdateDateInDateList(string attendanceValue, string studentID, string date)
        {
            bool flagresult = false;
            string query = string.Format("delete from academicperfomance where Idstudent = '{0}' and attendance = '{1}' and date = '{2}'", studentID, attendanceValue, date);
            MySqlCommand command = new MySqlCommand(query, connection);
            using (connection)
            {
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        flagresult = true;
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
            return flagresult;
        }
    }
}
