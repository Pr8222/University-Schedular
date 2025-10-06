using Schedular.Business;
using Schedular.Utilities;
using Schedular.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedular.App.Forms
{
    public partial class frmTeacherActions : Form
    {
        private readonly TeacherService service;
        public frmTeacherActions()
        {
            InitializeComponent();
            service = new TeacherService();
        }

        private void btnPrevFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowTeacher_Click(object sender, EventArgs e)
        {
            frmTeacherList frmTeacherList = new frmTeacherList();
            frmTeacherList.Show();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            if(requiredAddTeacher.IsValid)
            {
                if (service.AddTeacher(txtAddTeacher.Text))
                {
                    RtlMessageBox.Show("استاد با موفقیت به لیست اضافه شد✅");
                }
                else
                {
                    RtlMessageBox.Show("عملیات اضافه کردن استاد جدید با خطا روبرو شد❎");
                }
            }
        }

        private void btnEditTeacher_Click(object sender, EventArgs e)
        {
            if (requiredEditTeacherId.IsValid && requiredEditTeacherName.IsValid)
            {
                var teacher = new TeachersViewModel
                {
                    TeacherID = int.Parse(txtEditTeacherID.Text),
                    TeacherName = txtEditTeacherName.Text,
                };
                if (service.EditTeacher(teacher))
                {
                    RtlMessageBox.Show("استاد با موفقیت ویرایش شد✅");
                }
                else
                {
                    RtlMessageBox.Show("در هنگام ویرایش استاد مشکلی پیش آمد❎");
                }
            }
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            if(requiredDeleteTeacherID.IsValid)
            {
                int id = int.Parse(txtDeleteTeacherID.Text);
                var teacher = service.GetTeacherById(id);
                if (RtlMessageBox.Show($"آیا از حذف {teacher.TeacherName} با شناسه {teacher.TeacherID} اطمنیان دارید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (service.DeleteTeacher(id))
                    {
                        RtlMessageBox.Show("استاد با موفقیت از لیست حذف شد✅");
                    }
                    else
                    {
                        RtlMessageBox.Show("در هنگام حذف استاد مشکلی پیش آمد❎");
                    }
                }
            }
        }
    }
}
