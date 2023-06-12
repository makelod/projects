using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movierentsys
{
    public partial class Form7 : Form
    {

        readonly SqlConnection cod = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=VideoClub;Integrated Security=True");
        int genresearchID = 0;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cod.Open();
                SqlCommand cmd = cod.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Film WHERE Genre='" + textBox1.Text + "'";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                cod.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
