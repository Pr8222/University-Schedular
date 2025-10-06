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
using ValidationComponents;

namespace Schedular.App.Forms
{
    public partial class frmClassActions : Form
    {
        private readonly UnitService service;
        public frmClassActions()
        {
            InitializeComponent();
            service = new UnitService();
        }

        private void btnPrevFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            if (requiredAddUnitName.IsValid && requiredAddUnitCount.IsValid)
            {
                int unit = int.Parse(txtAddUnitCount.Text);
                if (service.AddUnit(txtAddUnitName.Text, unit))
                {
                    RtlMessageBox.Show("واحد با موفقیت اضافه شد✅");
                }
                else
                {
                    RtlMessageBox.Show("عملیات اضافه کردن واحد با خطا روبرو شد❎");
                }
            }
            
        }

        private void btnEditUnit_Click(object sender, EventArgs e)
        {
            if (requiredEditUnitId.IsValid && requiredEditUnitName.IsValid && requiredEditUnitCount.IsValid)
            {
                var editUnit = new CoursesViewModel
                {
                    Id = int.Parse(txtEditUnitID.Text),
                    CourseName = txtEditUnitName.Text,
                    Units = int.Parse(txtEditUnitCount.Text)
                };
                if (service.EditUnit(editUnit))
                {
                    RtlMessageBox.Show("واحد با موفقیت ویرایش یافت✅");
                }
                else
                {
                    RtlMessageBox.Show("عملیات ویرایش واحد با خطا روبرو شد❎");
                }
            }
        }

        private void btnDeleteUnit_Click(object sender, EventArgs e)
        {
            if (requiredDeleteUnitId.IsValid)
            {
                if (service.DeleteUnit(int.Parse(txtDeleteUnitID.Text)))
                {
                    RtlMessageBox.Show("واحد با موفقیت حذف شد✅");
                }
                else
                {
                    RtlMessageBox.Show("عملیات حذف واحد با خطا روبرو شد❎");
                }
            }
        }

        private void btnShowUnits_Click(object sender, EventArgs e)
        {
            frmCourseList courseList = new frmCourseList();
            courseList.Show();
        }
    }
}
