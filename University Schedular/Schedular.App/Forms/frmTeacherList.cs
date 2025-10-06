using Schedular.Business;
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
    public partial class frmTeacherList : Form
    {
        private readonly TeacherService service;
        public frmTeacherList()
        {
            InitializeComponent();
            service = new TeacherService();
            dgvTeacher.AutoGenerateColumns = false;
            BindGrid();
        }

        void BindGrid()
        {
            dgvTeacher.DataSource = service.GetAllTeachers();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvTeacher.DataSource = service.GetTeachersByFilter(txtSearch.Text);
        }
    }
}
