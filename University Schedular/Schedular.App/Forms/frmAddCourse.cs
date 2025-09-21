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
                        foreach (var s in suggestions)
                        {
                            s.Term = txtTerm.Text;
                            s.Units = int.Parse(txtUnits.Text);
                            s.Capacity = int.Parse(txtCapacity.Text);
                        }

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

        private void btnSaveSuggestions_Click(object sender, EventArgs e)
        {
            try
            {
                CourseService service = new CourseService();
                foreach (DataGridViewRow row in dgvSuggestedSchdules.Rows)
                {
                    if (row.IsNewRow) continue;

                    var schedule = new AddCourseViewModel
                    {
                        CourseTitle = txtCourseTitle.Text,
                        Term = txtTerm.Text,
                        TeacherName = txtTeacherName.Text,
                        ClassGroup = int.Parse(txtClassGroup.Text),
                        Units = int.Parse(txtUnits.Text),
                        Capacity = int.Parse(txtCapacity.Text),
                        DayOfWeek = row.Cells["DayOfWeek"].Value.ToString(),
                        StartTime = TimeSpan.Parse(row.Cells["StartTime"].Value.ToString()),
                        EndTime = TimeSpan.Parse(row.Cells["EndTime"].Value.ToString())
                    };
                    service.AddSchedule(schedule);
                }
                RtlMessageBox.Show("کلاس‌های پیشنهادی با موفقیت ذخیره شدند ✅");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                RtlMessageBox.Show($"خطا در ذخیره پیشنهادها: {ex.Message}");
            }
        }
    }
}
