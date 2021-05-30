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
    public partial class ShowUserDetail : Form
    {
        public ShowUserDetail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                MyCon ob = new MyCon();
                OleDbConnection con = ob.conn();
                string sqlcmd = "select * from createaccount";
               // OleDbDataReader dr = ob.getData(sqlcmd, con);
               // dataGridView1.DataSource = dr;
                dataGridView1.DataSource=ob.getTable(sqlcmd,con);
               // dr.Close();
                con.Close();
        }
    }
}
