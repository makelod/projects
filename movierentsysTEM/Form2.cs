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
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=VideoClub;Integrated Security=True");
        int ID = 0;
        public Form2()
        {

            InitializeComponent();
        }

        private void Getmovies()
        {
            try
            {
                conn.Open();
                SqlCommand selectAllCmd = conn.CreateCommand();
                selectAllCmd.CommandText = "SELECT * FROM Film";
               
                DataTable dTable = new DataTable();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(selectAllCmd);
                sqlAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Getmovies();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
                conn.Open();
                SqlCommand insertCmd = conn.CreateCommand();
                var title = textBox1.Text;
                var director = textBox2.Text;
                var genre = comboBox1.Text;
                var actors = richTextBox1.Text;
                var premiere = checkBox1.Checked ? "Yes" : "NO";
                var available = Available.Checked ? "YES" : "NO";
                insertCmd.CommandText = $"INSERT INTO Film  VALUES('{title}', '{director}','{genre}','{actors}','{premiere}', '{available} ')";
                insertCmd.ExecuteNonQuery();
                conn.Close();
                Getmovies();
                /*Clear_Data();*/
                MessageBox.Show("Record Successfully Inserted!");
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void Clear_Data()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.ResetText();
            richTextBox1.Clear();
            ID = 0;
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
                conn.Open();
                SqlCommand updateCmd = conn.CreateCommand();
                var title = textBox1.Text;
                var director = textBox2.Text;
                var genre = comboBox1.Text;
                var actors = richTextBox1.Text;
                var premiere = checkBox1.Checked ? "Yes" : "NO";
                var available = Available.Checked ? "YES" : "NO";
                updateCmd.CommandText = $"UPDATE  Film  set  Title = '{title}', Director = '{director}',Genre = '{genre}',Actors= '{actors}',Premiere = '{premiere}', Available ='{available}' where FilmID = {ID}";
                updateCmd.ExecuteNonQuery();
                conn.Close();
                Getmovies();
                /*Clear_Data();*/
                MessageBox.Show("Record Successfully Updated!");
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ID == 0)
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
                var title = textBox1.Text;
                var director = textBox2.Text;
                var genre = comboBox1.Text;
                var actors = richTextBox1.Text;
                var premiere = checkBox1.Checked ? "Yes" : "NO";
                var available = Available.Checked ? "YES" : "NO";
                conn.Open();
                SqlCommand deleteCmd = conn.CreateCommand();
                deleteCmd.CommandText = $"DELETE FROM Film WHERE FilmID = {ID}";
                deleteCmd.ExecuteNonQuery();
                conn.Close();
                Getmovies();
                Clear_Data();
                MessageBox.Show("Record Deleted Successfully!");
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }

        }
    }
}
