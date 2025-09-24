using Schedular.Business;
using Schedular.Utilities;
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
            if(service.AddTeacher(txtAddTeacher.Text))
            {
                RtlMessageBox.Show("استاد با موفقیت به لیست اضافه شد✅");
            }
            else
            {
                RtlMessageBox.Show("عملیات اضافه کردن استاد جدید با خطا روبرو شد❎");
            }
        }
    }
}
