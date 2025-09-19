using System;
using System.Windows.Forms;
using Schedular.Business;
using Schedular.Utilities;

namespace Schedular.App.Forms
{
    public partial class frmRemoveSameTermCourse : Form
    {
        public frmRemoveSameTermCourse()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtTerm.Text != "")
            {
                if(RtlMessageBox.Show($"آیا از حذف دروس ترم {txtTerm.Text} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    CourseService service = new CourseService();
                    service.RemoveSameTermCourses(txtTerm.Text);
                    DialogResult = DialogResult.OK;
                }               
            }
            else
            {
                RtlMessageBox.Show("لطفا فیلد ترم را به درستی وارد کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
