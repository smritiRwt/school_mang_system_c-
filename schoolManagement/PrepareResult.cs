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
    public partial class PrepareResult : Form
    {
        decimal summ = 0;
        decimal per=0;
        decimal maxmarks = 500;
        public void sumOfMarks()
        {
            MyCon ob = new MyCon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "select * from prepareresult where applicationNo='" + textBox2.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            while (dr.Read())
            {
            summ=summ+decimal.Parse(dr.GetString(8));
            per = (summ * 100) /maxmarks;
            if (per <= 100 && per > 80)
            {
                textBox11.Text = "A";
            }
            else if(per<=80&&per>60){
                textBox11.Text = "B";
            }
            else if(per<=60&&per>40)
            {
                textBox11.Text = "C";
            }
            else if (per <=40 && per >= 30)
            {
                textBox11.Text = "D";
            }
            else
            {
                textBox11.Text = "fail";
            }
   
            }

            textBox9.Text = summ.ToString();
            textBox10.Text = per.ToString();

            dr.Close();
            con.Close();
        }

      


        public void showGrid()
        {
            MyCon ob = new MyCon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "select * from prepareresult where applicationNo='"+textBox2.Text+"'";

            dataGridView1.DataSource = ob.getTable(sqlcmd, con);
            con.Close();

        }
        public void addSubjet()
        {

            MyCon ob = new MyCon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "select subname from subject where cls='" + textBox5.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            while (dr.Read())
            {
                comboBox1.Items.Add( dr.GetString(0));

            }
            dr.Close();
            con.Close();
        
        }
        public PrepareResult()
        {
            InitializeComponent();
        }

        private void PrepareResult_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MyCon ob = new MyCon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "select rollno,SN,cls,sec from personaldetails where applicationNo='"+textBox2.Text+"'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {
                textBox3.Text = dr.GetString(0);
                textBox6.Text = dr.GetString(1);
                textBox4.Text = dr.GetString(3);
                textBox5.Text = dr.GetString(2);

   }
            dr.Close();
            //crystal report integration
          
            sqlcmd = "select fathername from familydetail where applicationNo='" + textBox2.Text + "'";
            dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {
                textBox7.Text = dr.GetString(0);
            }
            dr.Close();
            addSubjet();
            showGrid();
            sumOfMarks();
           con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||textBox2.Text==""||textBox3.Text==""||textBox4.Text==""||textBox5.Text==""||textBox6.Text==""||textBox7.Text==""||comboBox1.Text==""||textBox8.Text=="")
            {
            MessageBox.Show("entr all details");
            }
            else
            {
            MyCon ob = new MyCon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "insert into prepareresult values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox1.Text + "','" + textBox8.Text + "')";
            int n = ob.putData(sqlcmd, con);
            if (n >= 1)
            {
                MessageBox.Show("data store");
            }
            else
            {
                MessageBox.Show("error");

            }
            showGrid();
            sumOfMarks();
                con.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
           
            comboBox1.Text = "";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }