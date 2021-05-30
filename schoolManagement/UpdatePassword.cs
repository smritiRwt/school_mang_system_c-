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
    public partial class UpdatePassword : Form
    {
        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              MyCon ob = new MyCon();
                OleDbConnection con = ob.conn();
                string sqlcmd = "update createaccount set psw='" + textBox3.Text + "',cpsw='"+textBox4.Text+"' where userId='" + textBox1.Text + "' and psw='"+textBox2.Text+"'";
                int n = ob.putData(sqlcmd, con);
                if (n >= 1)
                {
                    MessageBox.Show("update successfully");
                }
                else
                {
                    MessageBox.Show("userid or password not matched");
                }
                con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        }
    }
