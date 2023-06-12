using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace movierentsys
{
    public partial class Form5 : Form
    {
        readonly SqlConnection cont = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=VideoClub;Integrated Security=True");
        int searchID = 0;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                cont.Open();
                SqlCommand cmd = cont.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Film WHERE Title='" + textBox1.Text + "'";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
               
            }
            catch (Exception ex)
            {
                cont.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
