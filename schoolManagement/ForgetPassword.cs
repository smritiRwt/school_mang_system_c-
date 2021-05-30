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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             MyCon ob = new MyCon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "select sq from createaccount where userId='"+textBox1.Text+"'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {
                label5.Text = dr.GetString(0);

            }
            else
            {
                MessageBox.Show( "invalid userid");
            }
            dr.Close();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                MyCon ob = new MyCon();
                OleDbConnection con = ob.conn();
                string sqlcmd = "select psw from createaccount where userId='" + textBox1.Text + "' and ans='"+textBox2.Text+"'";
                OleDbDataReader dr = ob.getData(sqlcmd, con);
                if (dr.Read())
                {
                    label6.Text = dr.GetString(0);

                }
                else
                {
                    MessageBox.Show("incorrect answer");
                }
                dr.Close();
                con.Close();
        }

          
        }
        }
    
