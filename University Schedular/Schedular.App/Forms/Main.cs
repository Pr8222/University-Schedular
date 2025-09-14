using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schedular.Business;
using Schedular.ViewModels;

namespace Schedular.App.Forms
{
    public partial class frmMainPage : Form
    {

        public frmMainPage()
        {
            InitializeComponent();
            BindGrid();
        }

        void BindGrid()
        {
            var service = new CourseService();
            var schedules = service.GetAllCourseSchedules();
            dgvSchedules.DataSource = schedules;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            frmAddCourse frmAdd = new frmAddCourse();
            if(frmAdd.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveClass_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
