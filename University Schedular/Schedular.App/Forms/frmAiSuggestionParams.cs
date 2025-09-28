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
    public partial class frmAiSuggestionParams : Form
    {
        public string distributionType { get; private set; }
        public int classCount { get; private set; }
        public frmAiSuggestionParams()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                this.distributionType = cbDistributionType.Text == "در یک روز" ? "compact" : "spread";
                this.classCount = int.Parse(txtClassCount.Text);

                DialogResult = DialogResult.OK;
            }
        }
    }
}
