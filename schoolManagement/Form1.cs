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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox4.Text == "" || comboBox5.Text == "" ||
                comboBox6.Text == "" || comboBox7.Text == "" || comboBox8.Text == "" || comboBox9.Text == "" || comboBox10.Text == "" ||
                comboBox11.Text == "" || comboBox12.Text == "" || comboBox13.Text == "" || comboBox14.Text == "")
            {
                MessageBox.Show("enter all details");
            }

            else
            {
                MyCon ob = new MyCon();
                OleDbConnection con = ob.conn();
                string sqlcmd = "insert into personaldetails values('" + dateTimePicker1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox3.Text + "','" + comboBox4.Text + "','" + dateTimePicker2.Text + "','" + comboBox5.Text + "','" + textBox4.Text + "','" + comboBox6.Text + "','" + comboBox7.Text + "','" + comboBox8.Text + "','" + comboBox9.Text + "','" + comboBox10.Text + "','" + comboBox11.Text + "','" + comboBox12.Text + "','" + comboBox13.Text + "','" + comboBox14.Text + "','" + textBox5.Text + "','" + label2.Text + "','" + label3.Text + "')";
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

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";
            comboBox9.Text = "";
            comboBox10.Text = "";
            comboBox11.Text = "";
            comboBox12.Text = "";
            comboBox13.Text = "";
            comboBox14.Text = "";
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (comboBox15.Text == "" || comboBox16.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" ||

                comboBox17.Text == "" || comboBox18.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("please enter all details");

            }

            else
            {
                MyCon ob = new MyCon();
                OleDbConnection con = ob.conn();
                string sqlcmd = "insert into addressdetail values('" + dateTimePicker1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox15.Text + "','" + comboBox16.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + comboBox17.Text + "','" + comboBox18.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "')";
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

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox15.Text = "";
            comboBox16.Text = "";
            comboBox17.Text = "";
            comboBox18.Text = "";
            textBox6.Text = "";

            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" ||

                textBox15.Text == "" || textBox16.Text == "")
            {
                MessageBox.Show("please enter all details");

            }

            else
            {
                MyCon ob = new MyCon();
                OleDbConnection con = ob.conn();
                string sqlcmd = "insert into contactdetail values('" + dateTimePicker1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "')";
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

        private void button13_Click(object sender, EventArgs e)
        {


            if (textBox17.Text == "" || textBox18.Text == "" || textBox19.Text == "" || textBox20.Text == "" || textBox21.Text == "" ||

             textBox22.Text == "" || textBox23.Text == "" || comboBox19.Text == "" || textBox24.Text == "" || textBox25.Text == ""
             || textBox26.Text == "" ||
             textBox27.Text == "" || textBox28.Text == "" || textBox29.Text == "" || textBox30.Text == "" || comboBox20.Text == ""
             || textBox31.Text == "")
            {
                MessageBox.Show("please enter all details");

            }

            else
            {
                MyCon ob = new MyCon();
                OleDbConnection con = ob.conn();
                string sqlcmd = "insert into familydetail values('" + dateTimePicker1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox17.Text + "','" + textBox18.Text + "','" + textBox19.Text + "','" + textBox20.Text + "','" + textBox21.Text + "','" + textBox22.Text + "','" + textBox23.Text + "','" + comboBox19.Text + "','" + textBox24.Text + "','" + textBox25.Text + "','" + textBox26.Text + "','" + textBox27.Text + "','" + textBox28.Text + "','" + textBox29.Text + "','" + textBox30.Text + "','" + comboBox20.Text + "','" + textBox31.Text + "','"+label39.Text+"','"+label40.Text+"','"+label52.Text+"','"+label53.Text+"')";
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

        private void button14_Click(object sender, EventArgs e)
        {
            textBox17.Text = "";

            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textBox29.Text = "";
            textBox30.Text = "";
            textBox31.Text = "";
            comboBox19.Text = "";
            comboBox20.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox32.Text == "" || textBox33.Text == "" || comboBox21.Text == "" ||

                  comboBox22.Text == "" || textBox34.Text == "" || textBox35.Text == "" || textBox36.Text == "")
            {
                MessageBox.Show("please enter all details");

            }

            else
            {
                MyCon ob = new MyCon();
                OleDbConnection con = ob.conn();
                string sqlcmd = "insert into preschooldetail values('" + dateTimePicker1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox32.Text + "','" + textBox33.Text + "','" + comboBox21.Text + "','" + comboBox22.Text + "','" + textBox34.Text + "','" + textBox35.Text + "','" + textBox36.Text + "','" + dateTimePicker3.Text + "')";
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

        private void button15_Click(object sender, EventArgs e)
        {
            textBox32.Text = "";
            textBox33.Text = "";
            textBox34.Text = "";
            textBox35.Text = "";
            textBox36.Text = "";
            comboBox21.Text = "";
            comboBox22.Text = "";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox37.Text == "" || textBox38.Text == "" || textBox39.Text == "" || textBox40.Text == "" || textBox41.Text == "")
            {
                MessageBox.Show("please enter all details");

            }

            else
            {
                MyCon ob = new MyCon();
                OleDbConnection con = ob.conn();
                string sqlcmd = "insert into bankdetail values('" + dateTimePicker1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox37.Text + "','" + textBox38.Text + "','" + textBox39.Text + "','" + textBox40.Text + "','" + textBox41.Text + "')";
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

        private void button18_Click(object sender, EventArgs e)
        {

            textBox37.Text = "";
            textBox38.Text = "";
            textBox39.Text = "";
            textBox40.Text = "";
            textBox41.Text = "";
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Title = "Image selection";
            ofd.FileName = "";
            ofd.Filter = "JPEG Image|*.jpg|GIF Image|*.gif|PNG Image|*.png";
            ofd.Multiselect = false;
            string destpath = "C:/SSM/stuimg/";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(ofd.FileName);
                FileInfo f1 = new FileInfo(ofd.FileName);
                string newFileName = "IMG" + MyLogic.getId() + MyLogic.getRandom();
                f1.CopyTo(string.Format("{0}{1}{2}", destpath, newFileName, f1.Extension));
                string pa = newFileName + f1.Extension.ToString();
                label2.Text = pa;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ofd.Title = "Image selection";
            ofd.FileName = "";
            ofd.Filter = "JPEG Image|*.jpg|GIF Image|*.gif|PNG Image|*.png";
            ofd.Multiselect = false;
            string destpath = "C:/SSM/stusig/";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                FileInfo f1 = new FileInfo(ofd.FileName);
                string newFileName = "IMG" + MyLogic.getId() + MyLogic.getRandom();
                f1.CopyTo(string.Format("{0}{1}{2}", destpath, newFileName, f1.Extension));
                string pa = newFileName + f1.Extension.ToString();
                label3.Text = pa;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ofd.Title = "Image selection";
            ofd.FileName = "";
            ofd.Filter = "JPEG Image|*.jpg|GIF Image|*.gif|PNG Image|*.png";
            ofd.Multiselect = false;
            string destpath = "C:/SSM/fatherimg/";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(ofd.FileName);
                FileInfo f1 = new FileInfo(ofd.FileName);
                string newFileName = "IMG" + MyLogic.getId() + MyLogic.getRandom();
                f1.CopyTo(string.Format("{0}{1}{2}", destpath, newFileName, f1.Extension));
                string pa = newFileName + f1.Extension.ToString();
                label39.Text = pa;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ofd.Title = "Image selection";
            ofd.FileName = "";
            ofd.Filter = "JPEG Image|*.jpg|GIF Image|*.gif|PNG Image|*.png";
            ofd.Multiselect = false;
            string destpath = "C:/SSM/fathersig/";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.Image = Image.FromFile(ofd.FileName);
                FileInfo f1 = new FileInfo(ofd.FileName);
                string newFileName = "IMG" + MyLogic.getId() + MyLogic.getRandom();
                f1.CopyTo(string.Format("{0}{1}{2}", destpath, newFileName, f1.Extension));
                string pa = newFileName + f1.Extension.ToString();
                label40.Text = pa;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ofd.Title = "Image selection";
            ofd.FileName = "";
            ofd.Filter = "JPEG Image|*.jpg|GIF Image|*.gif|PNG Image|*.png";
            ofd.Multiselect = false;
            string destpath = "C:/SSM/motherimg/";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox5.Image = Image.FromFile(ofd.FileName);
                FileInfo f1 = new FileInfo(ofd.FileName);
                string newFileName = "IMG" + MyLogic.getId() + MyLogic.getRandom();
                f1.CopyTo(string.Format("{0}{1}{2}", destpath, newFileName, f1.Extension));
                string pa = newFileName + f1.Extension.ToString();
                label52.Text = pa;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ofd.Title = "Image selection";
            ofd.FileName = "";
            ofd.Filter = "JPEG Image|*.jpg|GIF Image|*.gif|PNG Image|*.png";
            ofd.Multiselect = false;
            string destpath = "C:/SSM/mothersig/";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox6.Image = Image.FromFile(ofd.FileName);
                FileInfo f1 = new FileInfo(ofd.FileName);
                string newFileName = "IMG" + MyLogic.getId() + MyLogic.getRandom();
                f1.CopyTo(string.Format("{0}{1}{2}", destpath, newFileName, f1.Extension));
                string pa = newFileName + f1.Extension.ToString();
                label53.Text = pa;
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox14.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9'))
                {

                }
                else
                {
                    MessageBox.Show("invalid character");
                    textBox14.Text = "";
                }
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            string s3 = textBox15.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9'))
                {

                }
                else
                {
                    MessageBox.Show("invalid character");
                    textBox15.Text = "";
                }
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            string s3 = textBox19.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9'))
                {

                }
                else
                {
                    MessageBox.Show("invalid character");
                    textBox19.Text = "";
                }
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            string s3 = textBox20.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9'))
                {

                }
                else
                {
                    MessageBox.Show("invalid character");
                    textBox20.Text = "";
                }
            }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            string s3 = textBox27.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9'))
                {

                }
                else
                {
                    MessageBox.Show("invalid character");
                    textBox27.Text = "";
                }
            }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            string s3 = textBox26.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9'))
                {

                }
                else
                {
                    MessageBox.Show("invalid character");
                    textBox26.Text = "";
                }
            }
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox31.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox31.Text = "";
                }
            }
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox36.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.')||(ch=='%'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox36.Text = "";
                }
            }
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox40.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') )
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox40.Text = "";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = MyLogic.getRandom();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = MyLogic.getRandom();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label78_Click(object sender, EventArgs e)
        {
            
        }

        private void label79_Click(object sender, EventArgs e)
        {

        }

        private void label81_Click(object sender, EventArgs e)
        {

        }

        private void label82_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox4.Text;
            foreach (char ch in s3)
            {
                if (ch >= '0' && ch <= '9')
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox4.Text = "";
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox7.Text;
            foreach (char ch in s3)
            {
                if (ch >= '0' && ch <= '9')
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox7.Text = "";
                }
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox10.Text;
            foreach (char ch in s3)
            {
                if (ch >= '0' && ch <= '9')
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox10.Text = "";
                }
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

            string s3 = textBox24.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox24.Text = "";
                }
            }
        
        }
    }
}