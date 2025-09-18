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
        public frmEditCourse(CourseScheduleViewModel model)
        {
            InitializeComponent();
            lableID.Text = model.Id.ToString();
            txtCourseTiltle.Text = model.CourseTitle;
            txtUnits.Text = model.Units.ToString();
            txtTeacherName.Text = model.TeacherName;
            txtTerm.Text = model.Term;
            txtClassGroup.Text = model.ClassGroup;
            txtDayOfWeek.Text = model.DayOfWeek;
            txtStartTime.Text = model.StartTime;
            txtEndTime.Text = model.EndTime;
            txtCapacity.Text = model.Capacity.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
