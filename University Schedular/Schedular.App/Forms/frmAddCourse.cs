using Schedular.Business;
using Schedular.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedular.App.Forms
{
    public partial class frmAddCourse : Form
    {
        public frmAddCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var service = new CourseService();
            service.AddSchedule(new ViewModels.AddCourseViewModel
            {
                CourseTitle = txtCourseTitle.Text,
                Term = txtTerm.Text,
                TeacherName = txtTeacherName.Text,
                ClassGroup = int.Parse(txtClassGroup.Text),
                Units  = int.Parse(txtUnits.Text),
                Capacity = int.Parse(txtCapacity.Text),
                DayOfWeek = comboBoxDayOfWeek.Text,
                StartTime = TimeSpan.Parse(maskedTextStartTime.Text),
                EndTime = TimeSpan.Parse(maskedTextEndTime.Text)
            });
            DialogResult = DialogResult.OK;
        }

        private async void btnSuggestWithAi_Click(object sender, EventArgs e)
        {
            try
            {
                string apiKey = ConfigurationManager.AppSettings["APIKey"];

                IAiService aiService = new AiService(apiKey);

                // اینو باید از دیتابیس یا گریدت بگیری
                var currentSchedules = new List<CourseScheduleViewModel>();

                var suggestions = await aiService.SuggestSchedulesAsync(
                    currentSchedules,
                    "دکتر احمدی",         // TeacherName
                    "برنامه نویسی پیشرفته", // CourseTitle
                    1,                     // ClassGroup
                    3,                     // Count
                    "spread"               // یا "compact"
                );

                dgvSuggestedSchdules.DataSource = suggestions;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در دریافت پیشنهاد از AI: {ex.Message}");
            }
        }
    }
}
