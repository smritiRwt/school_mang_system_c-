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
    public partial class create_account : Form
    {
      
        public create_account()
        {
            InitializeComponent();
        }

        private void create_account_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text==""||textBox2.Text==""||textBox3.Text==""||textBox4.Text==""||comboBox1.Text=="")
            {
                MessageBox.Show("please enter all details");
                
            }
               
            else {

                MyCon ob = new MyCon();
                OleDbConnection con = ob.conn();
                string sqlcmd = "insert into createaccount values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+comboBox1.Text+"','"+textBox4.Text+"')";
                int n = ob.putData(sqlcmd, con);
                if (n >= 1)
                {
                    MessageBox.Show("data store");
                }
                else
                {
                    MessageBox.Show("error");

                }
                con.Close();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
