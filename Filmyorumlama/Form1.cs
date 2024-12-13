using Puanlama;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;

namespace Puanlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "SELECT * FROM users";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            rd.Read();

            if (rd["user_name"].ToString() == textBox1.Text && rd["pass"].ToString() == textBox2.Text)
            {
                MessageBox.Show("başarılı");
                Form1 fr = new Form1();
                this.Hide();
                fr.ShowDialog();
            }

            else
            {
                MessageBox.Show("hatalı");
            }

            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}













