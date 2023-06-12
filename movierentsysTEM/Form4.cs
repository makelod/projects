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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace movierentsys
{
    public partial class Form4 : Form
    {

        readonly SqlConnection connet = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=VideoClub;Integrated Security=True");
        int UsedID = 0;
        public Form4()
        {
            InitializeComponent();
        }
        private void Getuse()
        {

            try
            {
                connet.Open();
                SqlCommand selectAllCmd = connet.CreateCommand();
                selectAllCmd.CommandText = "SELECT * FROM [User]";

                DataTable dTable = new DataTable();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(selectAllCmd);
                sqlAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
                connet.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }
        private void Form4_Load(object sender, EventArgs e)
        {
            Getuse();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please, fill out the form first");
                return;
            }
            try
            {
                connet.Open();
                SqlCommand insertCmd = connet.CreateCommand();
                var name = textBox1.Text;
                var address = textBox2.Text;
                var number = textBox3.Text;
                var email = textBox4.Text;
                var zipcode = textBox5.Text;
                insertCmd.CommandText = $"INSERT INTO [User]  VALUES('{name}', '{address}','{number}','{email}','{zipcode}')";
                insertCmd.ExecuteNonQuery();
                connet.Close();
                Getuse();
                /*Clear_Data();*/
                MessageBox.Show("Record Successfully Inserted!");
            }
            catch (Exception ex)
            {
                connet.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please, fill out the form first");
                return;
            }
            try
            {
                connet.Open();
                SqlCommand updateCmd = connet.CreateCommand();
                var name = textBox1.Text;
                var address = textBox2.Text;
                var number = textBox3.Text;
                var email = textBox4.Text;
                var zipcode = textBox5.Text;
                updateCmd.CommandText = $"UPDATE  [User]  set  Name = '{name}', Address = '{address}',Number = '{number}',Email= '{email}',ZipCode = '{zipcode}' where UserID = {UsedID}";
                updateCmd.ExecuteNonQuery();
                connet.Close();
                Getuse();
                /*Clear_Data();*/
                MessageBox.Show("Record Successfully Updated!");
            }
            catch (Exception ex)
            {
                connet.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UsedID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }
        private void Clear_Data()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            UsedID = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (UsedID == 0)
            {
                MessageBox.Show("Please Select a Record to Delete");
                return;
            }
            if (MessageBox.Show("Are you sure that you want to delete this record?", "Deleting...", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) != DialogResult.OK)
            {
                return;
            }
            try
            {
                var name = textBox1.Text;
                var address = textBox2.Text;
                var number = textBox3.Text;
                var email = textBox4.Text;
                var zipcode = textBox5.Text;
                connet.Open();
                SqlCommand deleteCmd = connet.CreateCommand();
                deleteCmd.CommandText = $"DELETE FROM [User] WHERE UserID = {UsedID}";
                deleteCmd.ExecuteNonQuery();
                connet.Close();
                Getuse();
                Clear_Data();
                MessageBox.Show("Record Deleted Successfully!");
            }
            catch (Exception ex)
            {
                connet.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }

}

