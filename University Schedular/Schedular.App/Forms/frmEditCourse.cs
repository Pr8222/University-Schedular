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
    public partial class frmEditCourse : Form
    {
        private readonly CourseService service;
        private readonly UnitService unitService;
        private readonly TeacherService teacherService;
        public frmEditCourse(CourseScheduleViewModel model)
        {
            InitializeComponent();
            service = new CourseService();
            unitService = new UnitService();
            teacherService = new TeacherService();
            txtCourseTiltle.DataSource = unitService.GetAllUnits();
            txtCourseTiltle.DisplayMember = "CourseName";
            txtTeacherName.DataSource = teacherService.GetAllTeachers();
            txtTeacherName.DisplayMember = "TeacherName";
            lableID.Text = model.Id.ToString();
            txtCourseTiltle.Text = model.CourseTitle;
            txtUnits.Text = model.Units.ToString();
            txtTeacherName.Text = model.TeacherName;
            txtTerm.Text = model.Term;
            txtClassGroup.Text = model.ClassGroup.ToString();
            txtDayOfWeek.Text = model.DayOfWeek;
            txtStartTime.Text = model.StartTime;
            txtEndTime.Text = model.EndTime;
            txtCapacity.Text = model.Capacity.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CourseService service = new CourseService();
            service.EditCourse(new EditCourseViewModel
            {
                Id = int.Parse(lableID.Text),
                CourseTitle = txtCourseTiltle.Text,
                Units = int.Parse(txtUnits.Text),
                TeacherName = txtTeacherName.Text,
                Term = txtTerm.Text,
                ClassGroup = int.Parse(txtClassGroup.Text),
                DayOfWeek = txtDayOfWeek.Text,
                StartTime = TimeSpan.Parse(txtStartTime.Text),
                EndTime = TimeSpan.Parse(txtEndTime.Text),
                Capacity = int.Parse(txtCapacity.Text)
            });
            DialogResult = DialogResult.OK;
        }

        private void txtCourseTiltle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCourseTiltle.SelectedItem is CoursesViewModel selectedCourse)
            {
                txtUnits.Text = selectedCourse.Units.ToString();
            }
        }
    }
}
