using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolManagement
{
    public partial class AfterLogin : Form
    {
        public AfterLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void AfterLogin_Load(object sender, EventArgs e)
        {

        }

        private void facultyDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacultyRegistrationUpdate ob = new FacultyRegistrationUpdate();
            ob.MdiParent = this;
            ob.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            ob.MdiParent = this;
            ob.Show();
        }

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacultyRegistration ob = new FacultyRegistration();
            ob.MdiParent = this;
            ob.Show();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewSubject ob = new AddNewSubject();
            ob.MdiParent = this;
            ob.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeSubmit ob = new FeeSubmit();
            ob.MdiParent = this;
            ob.Show();
        }

        private void studentDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1update ob = new Form1update();
            ob.MdiParent = this;
            ob.Show();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_account ob = new create_account();
            ob.MdiParent = this;
            ob.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
