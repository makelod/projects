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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Reflection.Metadata.Ecma335;

namespace movierentsys
{
    public partial class Form3 : Form
    {
        readonly SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=VideoClub;Integrated Security=True");
        int rentID = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Getrent()
        {

            try
            {
                con.Open();
                SqlCommand selectAllCmd = con.CreateCommand();
                selectAllCmd.CommandText = "SELECT RentID as [Rent], [Return] as [Return], Rental as [Rental],Price as [Price], UserID as [UserID], FilmID as [FilmID] FROM Rent";

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





        private void Form3_Load(object sender, EventArgs e)
        {
            Getrent();
            Getmovies();
            getUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       

            try
            {
                con.Open();
                SqlCommand insertCmd = con.CreateCommand();
                var reeturn = dateTimePicker1.Text;
                var rental = dateTimePicker2.Text;
                var price = textBox3.Text;
               

                insertCmd.CommandText = $"INSERT INTO Rent  VALUES('{reeturn}', '{rental}','{price}','{comboBox2.SelectedValue}','{comboBox3.SelectedValue}')";
                insertCmd.ExecuteNonQuery();
                con.Close();
                Getrent();
                /*Clear_Data();*/
                MessageBox.Show("Record Successfully Inserted!");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void getUsers ()
        {
            try
            {
                con.Open();
                SqlCommand selectAllCmd = con.CreateCommand();
                selectAllCmd.CommandText = "SELECT * FROM [User]";

                DataTable dTable = new DataTable();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(selectAllCmd);
                sqlAdapter.Fill(dTable);
                comboBox2.DataSource = dTable;
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "UserID";
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Getmovies()
        {
            try
            {
                con.Open();
                SqlCommand selectAllCmd = con.CreateCommand();
                selectAllCmd.CommandText = "SELECT * FROM Film";

                DataTable dTable = new DataTable();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(selectAllCmd);
                sqlAdapter.Fill(dTable);
                comboBox3.DataSource = dTable;
                comboBox3.DisplayMember = "Title";
                comboBox3.ValueMember = "FilmID";
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
