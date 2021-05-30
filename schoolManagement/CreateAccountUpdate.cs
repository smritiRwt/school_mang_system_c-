using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace schoolManagement
{
    public partial class CreateAccountUpdate : Form
    {
        public CreateAccountUpdate()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateAccountUpdate_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("please enter all details");

            }

            else
            {
                MyCon ob = new MyCon();
                OleDbConnection con = ob.conn();
                string sqlcmd = "update createaccount set psw='" + textBox2.Text + "',cpsw='" + textBox3.Text + "',sq='" + comboBox1.Text + "',ans='" + textBox4.Text + "' where userId='" + textBox1.Text + "'";
                int n = ob.putData(sqlcmd, con);
                if (n >= 1)
                {
                    MessageBox.Show("update successfully");
                }
                else
                {
                    MessageBox.Show("error");
                }
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyCon ob = new MyCon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "select * from createaccount where userId='"+textBox1.Text+"'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {
                textBox2.Text = dr.GetString(1);
                textBox3.Text = dr.GetString(2);
                comboBox1.Text = dr.GetString(3);
                textBox4.Text = dr.GetString(4);
   }
            dr.Close();
            con.Close();
        }
    }
}
