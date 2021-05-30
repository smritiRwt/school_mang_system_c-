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
    public partial class Form1update : Form
    {
        public Form1update()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox4.Text == "" || comboBox5.Text == "" ||
              comboBox6.Text == "" || comboBox7.Text == "" || comboBox8.Text == "" || comboBox9.Text == "" || comboBox10.Text == "" ||
              comboBox11.Text == "" || comboBox12.Text == "" || comboBox13.Text == "" || comboBox14.Text == "")
            {
                MessageBox.Show("please enter all details");
            }

            else
            {
                MyCon ob = new MyCon();
                OleDbConnection con = ob.conn();
                string sqlcmd = "update personaldetails set adddate='" + dateTimePicker1.Text + "',rollno='" + textBox2.Text + "',cls='" + comboBox1.Text + "',sec='" + comboBox2.Text + "',SN='" + textBox3.Text + "',gender='" + comboBox4.Text + "', DOB='" + dateTimePicker2.Text + "',birthplace='" + comboBox5.Text + "',adhaarno='" + textBox4.Text + "',bloodgroup='" + comboBox6.Text + "',nationality='" + comboBox7.Text + "',religion='" + comboBox8.Text + "',category='" + comboBox9.Text + "',caste='" + comboBox10.Text + "',physicallychallenged='" + comboBox11.Text + "',medium='" + comboBox12.Text + "',board='" + comboBox13.Text + "',behaviour='" + comboBox14.Text + "',remark='" + textBox5.Text + "',stuimg='"+label2.Text+"',stusig='"+label3.Text+"' where applicationNo='" + textBox1.Text + "'";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
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
                string sqlcmd = "update addressdetail set adddate='" + dateTimePicker1.Text + "',rollno='" + textBox2.Text + "',cls='" + comboBox1.Text + "',sec='" + comboBox2.Text + "',ses='" + comboBox3.Text + "',presentaddcountry='" + comboBox15.Text + "',PreAState='" + comboBox16.Text + "',presentaddcity='" + textBox6.Text + "',presentaddzipcode='" + textBox7.Text + "',presentaddlandmark='" + textBox8.Text + "',personaladdcountry='" + comboBox17.Text + "',personaladdstate='" + comboBox18.Text + "',personaladdcity='" + textBox9.Text + "',personaladdzipcode='" + textBox10.Text + "',personaladdlandmark='" + textBox11.Text + "' where applicationNo='" + textBox1.Text + "'";
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

        private void button19_Click(object sender, EventArgs e)
        {
            MyCon ob = new MyCon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "select * from personaldetails where applicationNo='" + textBox1.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {
                dateTimePicker1.Text = dr.GetString(0);
                textBox2.Text = dr.GetString(2);
                comboBox1.Text = dr.GetString(3);
                comboBox2.Text = dr.GetString(4);
                comboBox3.Text = dr.GetString(5);
                textBox3.Text = dr.GetString(6);
                comboBox4.Text = dr.GetString(7);
                dateTimePicker2.Text = dr.GetString(8);
                comboBox5.Text = dr.GetString(9);
                textBox4.Text = dr.GetString(10);
                comboBox6.Text = dr.GetString(11);
                comboBox7.Text = dr.GetString(12);
                comboBox8.Text = dr.GetString(13);
                comboBox9.Text = dr.GetString(14);
                comboBox10.Text = dr.GetString(15);
                comboBox11.Text = dr.GetString(16);
                comboBox12.Text = dr.GetString(17);
                comboBox13.Text = dr.GetString(18);
                comboBox14.Text = dr.GetString(19);
                textBox5.Text = dr.GetString(20);
                pictureBox2.Load("C:/SSM/stuimg/" + dr.GetString(21));
                label2.Text = dr.GetString(21);
                pictureBox1.Load("C:/SSM/stusig/" + dr.GetString(22));
                label3.Text =  dr.GetString(22);

            }
            dr.Close();
            con.Close();
        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                string sqlcmd = "update contactdetail set adddate='" + dateTimePicker1.Text + "',rollno='" + textBox2.Text + "',cls='" + comboBox1.Text + "',sec='" + comboBox2.Text + "',ses='" + comboBox3.Text + "',contactperson='" + textBox12.Text + "',relation='" + textBox13.Text + "',phoneno='" + textBox14.Text + "',mobileno='" + textBox15.Text + "',emailId='" + textBox16.Text + "' where applicationNo='" + textBox1.Text + "'";
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
               MessageBox.Show( "please enter all details");

            }

            else
            {
                MyCon ob = new MyCon();
                OleDbConnection con = ob.conn();
                string sqlcmd = "update familydetail set adddate='" + dateTimePicker1.Text + "',rollno='" + textBox2.Text + "',cls='" + comboBox1.Text + "',sec='" + comboBox2.Text + "',ses='" + comboBox3.Text + "',fathername='" + textBox17.Text + "',relationship='" + textBox18.Text + "',mobileno='" + textBox19.Text + "',phoneno='" + textBox20.Text + "',FaEmailid='" + textBox21.Text + "',Foccupation='" + textBox22.Text + "',Fdesignation='" + textBox23.Text + "',Fqualification='" + comboBox19.Text + "',monthlyincome='" + textBox24.Text + "',mother='" + textBox25.Text + "',Mmobileno='" + textBox26.Text + "',Mphoneno='" + textBox27.Text + "',MoEmailid='" + textBox28.Text + "',Moccupation='" + textBox29.Text + "',Mdesignation='" + textBox30.Text + "',MQualification='" + comboBox20.Text + "',Mmonthlyincome='" + textBox31.Text + "',fatherimg='"+label39.Text+"',fathersig='"+label40.Text+"',motherimg='"+label52.Text+"',mothersig='"+label53.Text+"' where applicationNo='" + textBox1.Text + "'";
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

        private void button16_Click(object sender, EventArgs e)
        {

            if (textBox32.Text == "" || textBox33.Text == "" || comboBox21.Text == "" ||

                  comboBox22.Text == "" || textBox34.Text == "" || textBox35.Text == "" || textBox36.Text == "")
            {
                MessageBox.Show( "please enter all details");

            }

            else
            {
                MyCon ob = new MyCon();
                OleDbConnection con = ob.conn();
                string sqlcmd = "update preschooldetail set adddate='" + dateTimePicker1.Text + "',rollno='" + textBox2.Text + "',cls='" + comboBox1.Text + "',sec='" + comboBox2.Text + "',ses='" + comboBox3.Text + "',schoolname='" + textBox32.Text + "',schooladdress='" + textBox33.Text + "',previousclass='" + comboBox21.Text + "',board='" + comboBox22.Text + "',obtainmarks='" + textBox34.Text + "',outofmarks='" + textBox35.Text + "',percentage='" + textBox36.Text + "',passoutdate='" + dateTimePicker3.Text + "' where applicationNo='" + textBox1.Text + "'";
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
                string sqlcmd = "update bankdetail set adddate='" + dateTimePicker1.Text + "',rollno='" + textBox2.Text + "',cls='" + comboBox1.Text + "',sec='" + comboBox2.Text + "',ses='" + comboBox3.Text + "',AccountHolderName='" + textBox37.Text + "',BankName='" + textBox38.Text + "',branchAddress='" + textBox39.Text + "',accountNumber='" + textBox40.Text + "',IFSCcode='" + textBox41.Text + "' where applicationNo='" + textBox1.Text + "'";
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
             pictureBox1.Load("C:/SSM/defaultimg/images.png");
             pictureBox2.Load("C:/SSM/defaultimg/images.png");
             label2.Text = "";
             label3.Text = "";
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

        private void button8_Click(object sender, EventArgs e)
        {
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";

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
            pictureBox3.Load("C:/SSM/defaultimg/images.png");
            pictureBox4.Load("C:/SSM/defaultimg/images.png");
            pictureBox5.Load("C:/SSM/defaultimg/images.png");
            pictureBox6.Load("C:/SSM/defaultimg/images.png");
            label39.Text = "";
            label40.Text="";
            label52.Text = "";
            label53.Text = "";
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

        private void button18_Click(object sender, EventArgs e)
        {

            textBox37.Text = "";
            textBox38.Text = "";
            textBox39.Text = "";
            textBox40.Text = "";
            textBox41.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MyCon ob = new MyCon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "select * from addressdetail where applicationNo='" + textBox1.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {
                dateTimePicker1.Text = dr.GetString(0);
                textBox2.Text = dr.GetString(2);
                comboBox1.Text = dr.GetString(3);
                comboBox2.Text = dr.GetString(4);
                comboBox3.Text = dr.GetString(5);
                comboBox15.Text = dr.GetString(6);
                comboBox16.Text = dr.GetString(7);
                textBox6.Text = dr.GetString(8);
                textBox7.Text = dr.GetString(9);
                textBox8.Text = dr.GetString(10);
                comboBox17.Text = dr.GetString(11);
                comboBox18.Text = dr.GetString(12);
                textBox9.Text = dr.GetString(13);
                textBox10.Text = dr.GetString(14);
                textBox11.Text = dr.GetString(15);

            }
            dr.Close();
            con.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MyCon ob = new MyCon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "select * from contactdetail where applicationNo='" + textBox1.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {

                dateTimePicker1.Text = dr.GetString(0);
                textBox2.Text = dr.GetString(2);
                comboBox1.Text = dr.GetString(3);
                comboBox2.Text = dr.GetString(4);
                comboBox3.Text = dr.GetString(5);
                textBox12.Text = dr.GetString(6);
                textBox13.Text = dr.GetString(7);
                textBox14.Text = dr.GetString(8);
                textBox15.Text = dr.GetString(9);
                textBox16.Text = dr.GetString(10);

            }
            dr.Close();
            con.Close();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            MyCon ob = new MyCon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "select * from bankdetail where applicationNo='" + textBox1.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {

                dateTimePicker1.Text = dr.GetString(0);
                textBox2.Text = dr.GetString(2);
                comboBox1.Text = dr.GetString(3);
                comboBox2.Text = dr.GetString(4);
                comboBox3.Text = dr.GetString(5);
                textBox37.Text = dr.GetString(6);
                textBox38.Text = dr.GetString(7);
                textBox39.Text = dr.GetString(8);
                textBox40.Text = dr.GetString(9);
                textBox41.Text = dr.GetString(10);

            }
            dr.Close();
            con.Close();


        }

        private void button23_Click(object sender, EventArgs e)
        {
            MyCon ob = new MyCon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "select * from preschooldetail where applicationNo='" + textBox1.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {

                dateTimePicker1.Text = dr.GetString(0);
                textBox2.Text = dr.GetString(2);
                comboBox1.Text = dr.GetString(3);
                comboBox2.Text = dr.GetString(4);
                comboBox3.Text = dr.GetString(5);
                textBox32.Text = dr.GetString(6);
                textBox33.Text = dr.GetString(7);
                comboBox21.Text = dr.GetString(8);
                comboBox22.Text = dr.GetString(9);
                textBox34.Text = dr.GetString(10);
                textBox35.Text = dr.GetString(11);
                textBox36.Text = dr.GetString(12);


            }
            dr.Close();
            con.Close();

        }

        private void button24_Click(object sender, EventArgs e)
        {
            MyCon ob = new MyCon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "select * from familydetail where applicationNo='" + textBox1.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {

                dateTimePicker1.Text = dr.GetString(0);
                textBox2.Text = dr.GetString(2);
                comboBox1.Text = dr.GetString(3);
                comboBox2.Text = dr.GetString(4);
                comboBox3.Text = dr.GetString(5);
                textBox17.Text = dr.GetString(6);
                textBox18.Text = dr.GetString(7);
                textBox19.Text = dr.GetString(8);
                textBox20.Text = dr.GetString(9);
                textBox21.Text = dr.GetString(10);
                textBox22.Text = dr.GetString(11);
                textBox23.Text = dr.GetString(12);
                textBox24.Text = dr.GetString(13);
                comboBox19.Text = dr.GetString(14);
                textBox25.Text = dr.GetString(15);
                textBox26.Text = dr.GetString(16);
                textBox27.Text = dr.GetString(17);
                textBox28.Text = dr.GetString(18);
                textBox29.Text = dr.GetString(19);
                textBox30.Text = dr.GetString(20);
                comboBox20.Text = dr.GetString(21);
                textBox31.Text = dr.GetString(22);
                pictureBox3.Load("C:/SSM/fatherimg/" + dr.GetString(23));
                label39.Text =  dr.GetString(23);
                pictureBox4.Load("C:/SSM/fathersig/" + dr.GetString(24));
                label40.Text =  dr.GetString(24);

                pictureBox6.Load("C:/SSM/motherimg/" + dr.GetString(25));
                label52.Text = dr.GetString(25);
                pictureBox5.Load("C:/SSM/mothersig/" + dr.GetString(26));
                label53.Text =  dr.GetString(26);
            }
            dr.Close();
            con.Close();

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
                    MessageBox.Show("invalid characte");
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
                    MessageBox.Show("invalid characte");
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
                if ((ch >= '0' && ch <= '9'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox20.Text = "";
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
                    MessageBox.Show("invalid characte");
                    textBox26.Text = "";
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
                    MessageBox.Show("invalid characte");
                    textBox27.Text = "";
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
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox40.Text = "";
                }
            }
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
            string destpath = "C:/SSM/fatherimg/";
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
                pictureBox6.Image = Image.FromFile(ofd.FileName);
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
                pictureBox5.Image = Image.FromFile(ofd.FileName);
                FileInfo f1 = new FileInfo(ofd.FileName);
                string newFileName = "IMG" + MyLogic.getId() + MyLogic.getRandom();
                f1.CopyTo(string.Format("{0}{1}{2}", destpath, newFileName, f1.Extension));
                string pa = newFileName + f1.Extension.ToString();
                label53.Text = pa;

            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1update_Load(object sender, EventArgs e)
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
                    MessageBox.Show("invalid character");
                    textBox10.Text = "";
                }
            }
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            string s3 = textBox34.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox34.Text = "";
                }
            }
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            string s3 = textBox35.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid characte");
                    textBox35.Text = "";
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}