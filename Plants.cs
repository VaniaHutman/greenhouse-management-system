using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Greenhouse.classes;
using MySql.Data.MySqlClient;

namespace Greenhouse
{
    public partial class Plants : Form
    {
        public Plants()
        {
            InitializeComponent();
            conecting_to_sql();
            //Plant[] plants = new Plant();
        }

        private void Plants_Load(object sender, EventArgs e)
        {

        }

        private void conecting_to_sql()
        {
            label11.Text = "Getting Connection ...";
            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();

                label11.Text = ("Connection successful!");
            }
            catch (Exception e)
            {
                label11.Text = ("Error: " + e.Message);
            }

            conn.Close();
            conn.Dispose();
            conn = null;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string name = "\"" + textBox1.Text + "\"";
            int maturity = Convert.ToInt32( textBox2.Text);
            string sql = "Insert into greenhouse.plant(name, maturity)  values(" +
                 name + ", " + maturity + ")";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteScalar();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string id_plant = "\"" + textBox6.Text + "\"";
            string sql = "delete from greenhouse.plant where id_plant = " + id_plant;
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteScalar();
            conn.Close();
        }
    }
}
