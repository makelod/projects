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
    public partial class Form10 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=VideoClub;Integrated Security=True");

        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            getAvailable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void getAvailable()
        {
            try
            {
                con.Open();
                SqlCommand selectAllCmd = con.CreateCommand();
                selectAllCmd.CommandText = "SELECT Title, Director, Actors, Genre, Premiere, Available FROM Film";

                DataTable dTable = new DataTable();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(selectAllCmd);
                sqlAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
