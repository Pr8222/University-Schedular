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
        private readonly CourseService service;
        public frmMainPage()
        {
            InitializeComponent();
            service = new CourseService();
            BindGrid();
        }
        //Get The data from the service
        void BindGrid()
        {
            var schedules = service.GetAllCourseSchedules();
            dgvSchedules.DataSource = schedules;
        }
        //Opening the add form to add a schedule for the course
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            frmAddCourse frmAdd = new frmAddCourse();
            if(frmAdd.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }
        //Opening the edit form to update a schedule
        private void btnEditCourse_Click(object sender, EventArgs e)
        {

        }
        //Removes a schedule
        private void btnRemoveClass_Click(object sender, EventArgs e)
        {
            if(dgvSchedules.CurrentRow != null)
            {
                var course = new
                {
 
                    Title = dgvSchedules.CurrentRow.Cells[1].Value.ToString(),
                    TeacherName = dgvSchedules.CurrentRow.Cells[3].Value.ToString(),
                };
                if(MessageBox.Show($"آیا از حذف درس {course.Title} با استاد {course.TeacherName} اطمینان دارید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int courseID = int.Parse(dgvSchedules.CurrentRow.Cells[0].Value.ToString());
                    service.RemoveCourse(courseID);
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("لطفا یک کلاس را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Refreshes the table
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            BindGrid();
        }
        //Filters the table
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           dgvSchedules.DataSource = service.SearchCourseSchedule(txtSearch.Text);
        }
    }
}
