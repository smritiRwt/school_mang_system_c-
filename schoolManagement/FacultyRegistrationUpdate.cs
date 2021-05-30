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
    public partial class FacultyRegistrationUpdate : Form
    {
        public FacultyRegistrationUpdate()
        {
            InitializeComponent();
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
            {
                MyCon ob = new MyCon();
                OleDbConnection con = ob.conn();
                string sqlcmd = "update facultyregistration set facName='" + textBox2.Text + "',dept='" + comboBox1.Text + "',sub='" + comboBox2.Text + "',mobno='" + textBox3.Text + "',phnno='" + textBox4.Text + "',emailid='" + textBox5.Text + "',relStatus='" + comboBox3.Text + "',adharno='" + textBox6.Text + "',bldgrp='" + textBox7.Text + "',jdate='" + dateTimePicker1.Text + "',bdate='" + dateTimePicker2.Text + "',age='" + textBox8.Text + "',father='" + textBox9.Text + "',quali='" + comboBox4.Text + "',experi='" + comboBox5.Text + "',co1='" + comboBox6.Text + "',st1='" + comboBox7.Text + "',cit1='" + textBox10.Text + "',zcode1='" + textBox11.Text + "',lm1='" + textBox12.Text + "',co2='" + comboBox8.Text + "',st2='" + comboBox9.Text + "',cit2='" + textBox13.Text + "',zcode2='" + textBox14.Text + "',lm2='" + textBox15.Text + "' where empid='" + textBox1.Text + "'";
                    
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

        private void button3_Click(object sender, EventArgs e)
        {
            MyCon ob = new MyCon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "select * from facultyregistration where empid='" + textBox1.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {
                textBox2.Text = dr.GetString(1);
                comboBox1.Text = dr.GetString(2);
                comboBox2.Text = dr.GetString(3);
                textBox3.Text = dr.GetString(4);
                textBox4.Text = dr.GetString(5);
                textBox5.Text = dr.GetString(6);
                comboBox3.Text = dr.GetString(8);
                textBox6.Text = dr.GetString(9);
                textBox7.Text = dr.GetString(10);
                dateTimePicker1.Text = dr.GetString(11);
                dateTimePicker2.Text = dr.GetString(12);
                textBox8.Text = dr.GetString(13);
                textBox9.Text = dr.GetString(14);
                comboBox4.Text = dr.GetString(15);
                comboBox5.Text = dr.GetString(16);
                comboBox6.Text = dr.GetString(17);
                comboBox7.Text = dr.GetString(18);
                textBox10.Text = dr.GetString(19);
                textBox11.Text = dr.GetString(20);
                textBox12.Text = dr.GetString(21);
                comboBox8.Text = dr.GetString(22);
                comboBox9.Text = dr.GetString(23);
                textBox13.Text = dr.GetString(24);
                textBox14.Text = dr.GetString(25);
                textBox15.Text = dr.GetString(26);

                
            }
            dr.Close();
            con.Close();
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox3.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            comboBox8.Text = "";
            comboBox9.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox3.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
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
