using Schedular.Business;
using Schedular.ViewModels;
using Schedular.Utilities;
using System;
using System.Configuration;
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
                Units = int.Parse(txtUnits.Text),
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
                var service = new CourseService();
                IAiService aiService = new AiService(apiKey);

                // فرم پارامترها رو نشون بده
                using (var paramForm = new frmAiSuggestionParams())
                {
                    if (paramForm.ShowDialog() == DialogResult.OK)
                    {
                        var currentSchedules = service.GetAllCourseSchedules();

                        var suggestions = await aiService.SuggestSchedulesAsync(
                            currentSchedules,
                            txtTeacherName.Text,         
                            txtCourseTitle.Text,         
                            int.Parse(txtClassGroup.Text), 
                            paramForm.classCount,        
                            paramForm.distributionType   
                        );

                        dgvSuggestedSchdules.AutoGenerateColumns = true;
                        dgvSuggestedSchdules.DataSource = null;
                        dgvSuggestedSchdules.DataSource = suggestions;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در دریافت پیشنهاد از AI: {ex.Message}");
            }
        }
    }
}
