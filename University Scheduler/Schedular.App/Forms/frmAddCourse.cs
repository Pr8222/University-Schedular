using Schedular.Business;
using Schedular.Utilities;
using Schedular.ViewModels;
using System;
using System.Configuration;
using System.Windows.Forms;
using ValidationComponents;

namespace Schedular.App.Forms
{
    public partial class frmAddCourse : Form
    {
        private readonly CourseService service;
        private readonly UnitService unitService;
        private readonly TeacherService teacherService;
        public frmAddCourse()
        {
            InitializeComponent();
            service = new CourseService();
            unitService = new UnitService();
            teacherService = new TeacherService();
            txtCourseTitle.DataSource = unitService.GetAllUnits();
            txtCourseTitle.DisplayMember = "CourseName";
            txtTeacherName.DataSource = teacherService.GetAllTeachers();
            txtTeacherName.DisplayMember = "TeacherName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                try
                {
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
                    RtlMessageBox.Show("برنامه کلاسی با موفقیت به لیست اضافه شد✅");
                    DialogResult = DialogResult.OK;
                }
                catch
                {
                    RtlMessageBox.Show("مشکلی در هنگام اضافه کردن برنامه کلاسی به لیست بوجود آمد❎");
                }
            }
        }

        private async void btnSuggestWithAi_Click(object sender, EventArgs e)
        {

            try
            {
                string apiKey = ConfigurationManager.AppSettings["APIKey"];
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
            if (BaseValidator.IsFormValid(this.components))
            {
                try
                {
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

        private void txtCourseTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCourseTitle.SelectedItem is CoursesViewModel selectedCourse)
            {
                txtUnits.Text = selectedCourse.Units.ToString();
            }
        }
    }
}
