using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Schedular.Business;
using Schedular.ViewModels;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
            dgvSchedules.DataSource = null;
            dgvSchedules.DataSource = schedules;
        }
        //Opening the add form to add a schedule for the course
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            frmAddCourse frmAdd = new frmAddCourse();
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }
        //Opening the edit form to update a schedule
        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            CourseScheduleViewModel selectedModel = new CourseScheduleViewModel()
            {
                Id = int.Parse(dgvSchedules.CurrentRow.Cells[0].Value.ToString()),
                CourseTitle = dgvSchedules.CurrentRow.Cells[1].Value.ToString(),
                Units = int.Parse(dgvSchedules.CurrentRow.Cells[2].Value.ToString()),
                TeacherName = dgvSchedules.CurrentRow.Cells[3].Value.ToString(),
                Term = dgvSchedules.CurrentRow.Cells[4].Value.ToString(),
                ClassGroup = dgvSchedules.CurrentRow.Cells[5].Value.ToString(),
                DayOfWeek = dgvSchedules.CurrentRow.Cells[6].Value.ToString(),
                StartTime = dgvSchedules.CurrentRow.Cells[7].Value.ToString(),
                EndTime = dgvSchedules.CurrentRow.Cells[8].Value.ToString(),
                Capacity = int.Parse(dgvSchedules.CurrentRow.Cells[9].Value.ToString()),
            };
            frmEditCourse frmEdit = new frmEditCourse(selectedModel);
            if (frmEdit.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
                dgvSchedules.Refresh();
            }
        }
        //Removes a schedule
        private void btnRemoveClass_Click(object sender, EventArgs e)
        {
            if (dgvSchedules.CurrentRow != null)
            {
                var course = new
                {

                    Title = dgvSchedules.CurrentRow.Cells[1].Value.ToString(),
                    TeacherName = dgvSchedules.CurrentRow.Cells[3].Value.ToString(),
                };
                if (MessageBox.Show($"آیا از حذف درس {course.Title} با استاد {course.TeacherName} اطمینان دارید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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

        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "PDF file (*.pdf)|*.pdf|CSV file (*.csv)|*.csv";
            saveFile.Title = "ذخیره برنامه‌ریزی";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(saveFile.FileName).ToLower();

                if (ext == ".csv")
                {
                    SaveAsCsv(saveFile.FileName);
                }

                else
                {
                    SaveAsPdf(saveFile.FileName);
                }
            }
        }
        // Save the schedule as csv
        private void SaveAsCsv(string path)
        {
            StringBuilder sb = new StringBuilder();

            // ستون‌ها
            for (int i = 0; i < dgvSchedules.Columns.Count; i++)
            {
                sb.Append(dgvSchedules.Columns[i].HeaderText);
                if (i < dgvSchedules.Columns.Count - 1)
                    sb.Append(",");
            }
            sb.AppendLine();

            // ردیف‌ها
            foreach (DataGridViewRow row in dgvSchedules.Rows)
            {
                if (!row.IsNewRow)
                {
                    for (int i = 0; i < dgvSchedules.Columns.Count; i++)
                    {
                        sb.Append(row.Cells[i].Value?.ToString());
                        if (i < dgvSchedules.Columns.Count - 1)
                            sb.Append(",");
                    }
                    sb.AppendLine();
                }
            }
        }
        // Save the schedule as pdf
        private void SaveAsPdf(string path)
        {

            Document doc = new Document(PageSize.A4, 10, 10, 10, 10);
            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
            doc.Open();

            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 10);

            PdfPTable table = new PdfPTable(dgvSchedules.Columns.Count);

            foreach (DataGridViewColumn column in dgvSchedules.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
            }

            foreach (DataGridViewRow row in dgvSchedules.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(new Phrase(cell.Value?.ToString() ?? "", font));
                    }
                }
            }

            doc.Add(table);

            doc.Close();
            MessageBox.Show("فایل PDF با موفقیت ذخیره شد ✅");
        }
    }
}
