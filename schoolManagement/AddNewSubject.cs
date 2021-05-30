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
    public partial class AddNewSubject : Form
    {
        public AddNewSubject()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MyCon ob = new MyCon();
                OleDbConnection con = ob.conn();
                string sqlcmd = "insert into subject values('"+comboBox1.Text+"','"+textBox1.Text+"','"+textBox2.Text+"');";
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
    }
