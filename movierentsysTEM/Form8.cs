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
    public partial class Form8 : Form
    {
        readonly SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=VideoClub;Integrated Security=True");

        public Form8()
        {
            InitializeComponent();
        }

        private void Getused()
        {
            try
            {
                con.Open();
                SqlCommand selectAllCmd = con.CreateCommand();
                selectAllCmd.CommandText = "SELECT * FROM [User]";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Getused();
        }
    }
}
