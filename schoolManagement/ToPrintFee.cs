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
    public partial class ToPrintFee : Form
    {
        public ToPrintFee()
        {
            InitializeComponent();
        }

        private void ToPrintFee_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyCon ob = new MyCon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "delete *  from TempFee ";
            int n = ob.putData(sqlcmd, con);
            if (n >= 1)
            {

            }
            else
            {
                MessageBox.Show("error");

            }
            con.Close();
        }
    }
}
