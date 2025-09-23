using Schedular.Business;
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
    public partial class frmCourseList : Form
    {
        private readonly UnitService service;
        public frmCourseList()
        {
            InitializeComponent();
            service = new UnitService();
            BindGrid();
        }
        //Get The data from the service
        void BindGrid()
        {
            var units = service.GetAllUnits();
            dgvCourse.DataSource = null;
            dgvCourse.DataSource = units;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCourse.DataSource = service.GetUnitsByFilter(txtSearch.Text);
        }
    }
}
