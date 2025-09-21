using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedular.App.Forms
{
    public partial class frmClassActions : Form
    {
        public frmClassActions()
        {
            InitializeComponent();
        }

        private void btnPrevFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {

        }

        private void btnShowUnits_Click(object sender, EventArgs e)
        {
            frmCourseList courseList = new frmCourseList();
            courseList.Show();
        }
    }
}
