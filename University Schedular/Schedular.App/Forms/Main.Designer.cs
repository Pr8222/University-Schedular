namespace Schedular.App.Forms
{
    partial class frmMainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPage));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddCourse = new System.Windows.Forms.ToolStripButton();
            this.btnEditCourse = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveClass = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveSameTerms = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.dgvSchedules = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCourse,
            this.btnEditCourse,
            this.btnRemoveClass,
            this.btnRemoveSameTerms,
            this.btnRefresh,
            this.toolStripLabel1,
            this.txtSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(806, 77);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Image = global::Schedular.App.Properties.Resources.add_course;
            this.btnAddCourse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(123, 74);
            this.btnAddCourse.Text = "اضافه کردن کلاس";
            this.btnAddCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCourse.Image = global::Schedular.App.Properties.Resources.edit_course;
            this.btnEditCourse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(96, 74);
            this.btnEditCourse.Text = "ویرایش کلاس";
            this.btnEditCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditCourse.ToolTipText = "نمایش کلاس‌ها";
            this.btnEditCourse.Click += new System.EventHandler(this.btnEditCourse_Click);
            // 
            // btnRemoveClass
            // 
            this.btnRemoveClass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveClass.Image = global::Schedular.App.Properties.Resources.remove_course;
            this.btnRemoveClass.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRemoveClass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveClass.Name = "btnRemoveClass";
            this.btnRemoveClass.Size = new System.Drawing.Size(84, 74);
            this.btnRemoveClass.Text = "حذف کلاس";
            this.btnRemoveClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemoveClass.Click += new System.EventHandler(this.btnRemoveClass_Click);
            // 
            // btnRemoveSameTerms
            // 
            this.btnRemoveSameTerms.Image = global::Schedular.App.Properties.Resources.delete_same_term_courses;
            this.btnRemoveSameTerms.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRemoveSameTerms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveSameTerms.Name = "btnRemoveSameTerms";
            this.btnRemoveSameTerms.Size = new System.Drawing.Size(187, 74);
            this.btnRemoveSameTerms.Text = "حذف کلاس‌های ترم مشخص";
            this.btnRemoveSameTerms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnRefresh.Image = global::Schedular.App.Properties.Resources.refresh_shedule;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 74);
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 74);
            this.toolStripLabel1.Text = "جستجو";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 77);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvSchedules
            // 
            this.dgvSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedules.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column10,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvSchedules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchedules.Location = new System.Drawing.Point(0, 77);
            this.dgvSchedules.Name = "dgvSchedules";
            this.dgvSchedules.RowHeadersWidth = 51;
            this.dgvSchedules.RowTemplate.Height = 24;
            this.dgvSchedules.Size = new System.Drawing.Size(806, 401);
            this.dgvSchedules.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "شناسه";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CourseTitle";
            this.Column2.HeaderText = "نام درس";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Units";
            this.Column10.HeaderText = "واحد";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TeacherName";
            this.Column3.HeaderText = "نام استاد";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Term";
            this.Column4.HeaderText = "ترم";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ClassGroup";
            this.Column5.HeaderText = "گروه";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DayOfWeek";
            this.Column6.HeaderText = "روز هفته";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "StartTime";
            this.Column7.HeaderText = "زمان شروع";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "EndTime";
            this.Column8.HeaderText = "زمان پایان";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Capacity";
            this.Column9.HeaderText = "ظرفیت";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 478);
            this.Controls.Add(this.dgvSchedules);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "برنامه‌ریزی انتخاب واحد";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddCourse;
        private System.Windows.Forms.ToolStripButton btnRemoveClass;
        private System.Windows.Forms.ToolStripButton btnEditCourse;
        private System.Windows.Forms.DataGridView dgvSchedules;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnRemoveSameTerms;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
    }
}