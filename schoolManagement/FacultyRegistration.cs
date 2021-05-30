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
    public partial class FacultyRegistration : Form
    {
        string Gender;
        public FacultyRegistration()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FacultyRegistration_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox3.Text == "" ||
                textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || comboBox4.Text == "" || comboBox5.Text == "" || comboBox6.Text == "" || comboBox7.Text == "" ||
                textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || comboBox8.Text == "" || comboBox9.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "")
            {
                MessageBox.Show("enter all details");
            }
            else
            {   MyCon ob = new MyCon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "insert into facultyregistration values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"+Gender+"','" + comboBox3.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + comboBox6.Text + "','" + comboBox7.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + comboBox8.Text + "','" + comboBox9.Text + "','"+textBox13.Text+"','"+textBox14.Text+"','"+textBox15.Text+"')";
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "female";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "male";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox3.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox3.Text = "";
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox4.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox4.Text = "";
                }
            }
        }
    }
}
