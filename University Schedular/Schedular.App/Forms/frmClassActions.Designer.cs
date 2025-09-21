namespace Schedular.App.Forms
{
    partial class frmClassActions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddUnitName = new System.Windows.Forms.TextBox();
            this.txtAddUnitCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteUnit = new System.Windows.Forms.Button();
            this.btnPrevFrm = new System.Windows.Forms.Button();
            this.btnEditUnit = new System.Windows.Forms.Button();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowUnits = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAddUnitCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAddUnitName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات واحد";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowUnits);
            this.groupBox2.Controls.Add(this.btnAddUnit);
            this.groupBox2.Controls.Add(this.btnEditUnit);
            this.groupBox2.Controls.Add(this.btnDeleteUnit);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عملیات واحد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام واحد:";
            // 
            // txtAddUnitName
            // 
            this.txtAddUnitName.Location = new System.Drawing.Point(549, 50);
            this.txtAddUnitName.Name = "txtAddUnitName";
            this.txtAddUnitName.Size = new System.Drawing.Size(156, 24);
            this.txtAddUnitName.TabIndex = 1;
            // 
            // txtAddUnitCount
            // 
            this.txtAddUnitCount.Location = new System.Drawing.Point(9, 50);
            this.txtAddUnitCount.Name = "txtAddUnitCount";
            this.txtAddUnitCount.Size = new System.Drawing.Size(156, 24);
            this.txtAddUnitCount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "تعداد واحد:";
            // 
            // btnDeleteUnit
            // 
            this.btnDeleteUnit.Location = new System.Drawing.Point(205, 43);
            this.btnDeleteUnit.Name = "btnDeleteUnit";
            this.btnDeleteUnit.Size = new System.Drawing.Size(140, 30);
            this.btnDeleteUnit.TabIndex = 7;
            this.btnDeleteUnit.Text = "حذف واحد";
            this.btnDeleteUnit.UseVisualStyleBackColor = true;
            // 
            // btnPrevFrm
            // 
            this.btnPrevFrm.Location = new System.Drawing.Point(322, 265);
            this.btnPrevFrm.Name = "btnPrevFrm";
            this.btnPrevFrm.Size = new System.Drawing.Size(170, 30);
            this.btnPrevFrm.TabIndex = 2;
            this.btnPrevFrm.Text = "بازگشت به صفحه قبل";
            this.btnPrevFrm.UseVisualStyleBackColor = true;
            this.btnPrevFrm.Click += new System.EventHandler(this.btnPrevFrm_Click);
            // 
            // btnEditUnit
            // 
            this.btnEditUnit.Location = new System.Drawing.Point(413, 43);
            this.btnEditUnit.Name = "btnEditUnit";
            this.btnEditUnit.Size = new System.Drawing.Size(140, 30);
            this.btnEditUnit.TabIndex = 8;
            this.btnEditUnit.Text = "ویرایش واحد";
            this.btnEditUnit.UseVisualStyleBackColor = true;
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Location = new System.Drawing.Point(608, 43);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(140, 30);
            this.btnAddUnit.TabIndex = 9;
            this.btnAddUnit.Text = "اضافه کردن واحد";
            this.btnAddUnit.UseVisualStyleBackColor = true;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 24);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "نام واحد جدید:";
            // 
            // btnShowUnits
            // 
            this.btnShowUnits.Location = new System.Drawing.Point(25, 43);
            this.btnShowUnits.Name = "btnShowUnits";
            this.btnShowUnits.Size = new System.Drawing.Size(140, 30);
            this.btnShowUnits.TabIndex = 10;
            this.btnShowUnits.Text = "نمایش لیست واحدها";
            this.btnShowUnits.UseVisualStyleBackColor = true;
            this.btnShowUnits.Click += new System.EventHandler(this.btnShowUnits_Click);
            // 
            // frmClassActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 322);
            this.Controls.Add(this.btnPrevFrm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmClassActions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "عملیات مربوط به واحد";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAddUnitName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddUnitCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteUnit;
        private System.Windows.Forms.Button btnPrevFrm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddUnit;
        private System.Windows.Forms.Button btnEditUnit;
        private System.Windows.Forms.Button btnShowUnits;
    }
}