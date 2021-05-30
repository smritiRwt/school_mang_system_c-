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
    public partial class user_login : Form
    {
        public user_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdatePassword ob = new UpdatePassword();
            ob.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword ob = new ForgetPassword();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyCon ob = new MyCon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "select * from createaccount where userId='" + textBox1.Text + "' and psw='"+textBox2.Text+"'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {
                AfterLogin obj = new AfterLogin();
                obj.Show();
            }
            else
            {
                MessageBox.Show("incorrect userid or password");
            }
            dr.Close();
            con.Close();
        
        }
    }
}
