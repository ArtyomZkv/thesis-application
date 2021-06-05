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
    public partial class AddDirection : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=root;database=it-cube");
        public AddDirection()
        {
            InitializeComponent();
            txbx_hideID.Text = Guid.NewGuid().ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

            Forms.DirectionListWorkForm directionListWorkForm = new DirectionListWorkForm();
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {

            connection.Open();
            MySqlCommand command = new MySqlCommand("insert into directions (iddirection, diractionname, hoursqunatity) VALUES (@iddirection, @diractionname, @hoursqunatity)", connection);
            command.Parameters.AddWithValue("iddirection", txbx_hideID.Text);
            command.Parameters.AddWithValue("diractionname", txbx_directionName.Text);
            command.Parameters.AddWithValue("hoursqunatity", txbx_hours.Text);
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
