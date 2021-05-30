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
using System.IO;
namespace schoolManagement
{
    public partial class FeeSubmit : Form
    {
        decimal a, b, c, d, z, f, g, h, i, j, k, l, m, n, o, sum;


        public void SumOfFee()
        {

            if (textBox3.Text != "")
            {
                a = decimal.Parse(textBox3.Text);
            }
            else
            {
                a = 0;
            }

            if (textBox4.Text != "")
            {
                b = decimal.Parse(textBox4.Text);
            }
            else
            {
                b = 0;
            }

            if (textBox5.Text != "")
            {
                c = decimal.Parse(textBox5.Text);
            }
            else
            {
                c = 0;
            }

            if (textBox6.Text != "")
            {
                d = decimal.Parse(textBox6.Text);
            }
            else
            {
                d = 0;
            }

            if (textBox7.Text != "")
            {
                z = decimal.Parse(textBox7.Text);
            }
            else
            {
                z = 0;
            }

            if (textBox8.Text != "")
            {
                f = decimal.Parse(textBox8.Text);
            }
            else
            {
                f = 0;
            }
            if (textBox9.Text != "")
            {
                g = decimal.Parse(textBox9.Text);
            }
            else
            {
                g = 0;
            }
            if (textBox10.Text != "")
            {
                h = decimal.Parse(textBox10.Text);
            }
            else
            {
                h = 0;
            }
            if (textBox15.Text != "")
            {
                i = decimal.Parse(textBox15.Text);
            }
            else
            {
                i = 0;
            }
            if (textBox16.Text != "")
            {
                j = decimal.Parse(textBox16.Text);
            }
            else
            {
                j = 0;
            }
            if (textBox17.Text != "")
            {
                k = decimal.Parse(textBox17.Text);
            }
            else
            {
                k = 0;
            }
            if (textBox18.Text != "")
            {
                l = decimal.Parse(textBox18.Text);
            }
            else
            {
                l = 0;
            }
            if (textBox19.Text != "")
            {
                m = decimal.Parse(textBox19.Text);
            }
            else
            {
                m = 0;
            }
            if (textBox20.Text != "")
            {
                n = decimal.Parse(textBox20.Text);
            }
            else
            {
                n = 0;
            }
            if (textBox21.Text != "")
            {
                o = decimal.Parse(textBox21.Text);
            }
            else
            {
                o = 0;
            }

            sum = a + b + c + d + z + f + g + h + i + j + k + l + m + n + o;
            textBox11.Text = sum.ToString();
        }

        public FeeSubmit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyCon ob = new MyCon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "insert into Feedetail values('" + textBox1.Text + "','" + comboBox1.Text + "','"+textBox2.Text+"','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "','" + textBox18.Text + "','" + textBox19.Text + "','" + textBox20.Text + "','" + textBox21.Text + "')";
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyCon ob = new MyCon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "select * from personaldetails where applicationNo='" + comboBox1.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {
                textBox2.Text = dr.GetString(0);

                textBox14.Text = dr.GetString(1);
                textBox13.Text = dr.GetString(2);
                pictureBox1.Load("C:/SSM/stuimg/" + dr.GetString(21));
                label2.Text = dr.GetString(21);
            }
            dr.Close();
          
            con.Close();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            SumOfFee();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox5.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox5.Text = "";
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox6.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox6.Text = "";
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox7.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox7.Text = "";
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox8.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox8.Text = "";
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox9.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox9.Text = "";
                }
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox10.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox10.Text = "";
                }
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox11.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox11.Text = "";
                }
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox15.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox15.Text = "";
                }
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox16.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox16.Text = "";
                }
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox17.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox17.Text = "";
                }
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox18.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox18.Text = "";
                }
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox19.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox19.Text = "";
                }
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox20.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox20.Text = "";
                }
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox21.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid character");
                    textBox21.Text = "";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            MyCon ob = new MyCon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "insert into TempFee values('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "','" + textBox18.Text + "','" + textBox19.Text + "','" + textBox20.Text + "','" + textBox21.Text + "')";
            int n = ob.putData(sqlcmd, con);
            if (n >= 1)
            {
            }
            else
            {
                MessageBox.Show("error");

            }

           ToPrintFee obj = new ToPrintFee();
            obj.Show(); 

            con.Close();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


