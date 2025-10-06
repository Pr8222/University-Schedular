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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassActions));
            this.gbAddUnit = new System.Windows.Forms.GroupBox();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.txtAddUnitCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddUnitName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowUnits = new System.Windows.Forms.Button();
            this.btnEditUnit = new System.Windows.Forms.Button();
            this.btnDeleteUnit = new System.Windows.Forms.Button();
            this.btnPrevFrm = new System.Windows.Forms.Button();
            this.gbEditUnit = new System.Windows.Forms.GroupBox();
            this.txtEditUnitName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditUnitCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditUnitID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDeleteUnit = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeleteUnitID = new System.Windows.Forms.TextBox();
            this.requiredAddUnitName = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredEditUnitId = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredEditUnitName = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredDeleteUnitId = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredAddUnitCount = new ValidationComponents.RangeValidator(this.components);
            this.requiredEditUnitCount = new ValidationComponents.RangeValidator(this.components);
            this.gbAddUnit.SuspendLayout();
            this.gbEditUnit.SuspendLayout();
            this.gbDeleteUnit.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddUnit
            // 
            this.gbAddUnit.Controls.Add(this.btnAddUnit);
            this.gbAddUnit.Controls.Add(this.txtAddUnitCount);
            this.gbAddUnit.Controls.Add(this.label2);
            this.gbAddUnit.Controls.Add(this.txtAddUnitName);
            this.gbAddUnit.Controls.Add(this.label1);
            this.gbAddUnit.Location = new System.Drawing.Point(12, 12);
            this.gbAddUnit.Name = "gbAddUnit";
            this.gbAddUnit.Size = new System.Drawing.Size(776, 100);
            this.gbAddUnit.TabIndex = 0;
            this.gbAddUnit.TabStop = false;
            this.gbAddUnit.Text = "اضافه کردن واحد";
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Location = new System.Drawing.Point(26, 46);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(140, 30);
            this.btnAddUnit.TabIndex = 9;
            this.btnAddUnit.Text = "اضافه کردن واحد";
            this.btnAddUnit.UseVisualStyleBackColor = true;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // txtAddUnitCount
            // 
            this.txtAddUnitCount.Location = new System.Drawing.Point(223, 50);
            this.txtAddUnitCount.Name = "txtAddUnitCount";
            this.txtAddUnitCount.Size = new System.Drawing.Size(156, 24);
            this.txtAddUnitCount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "تعداد واحد:";
            // 
            // txtAddUnitName
            // 
            this.txtAddUnitName.Location = new System.Drawing.Point(516, 50);
            this.txtAddUnitName.Name = "txtAddUnitName";
            this.txtAddUnitName.Size = new System.Drawing.Size(156, 24);
            this.txtAddUnitName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام درس:";
            // 
            // btnShowUnits
            // 
            this.btnShowUnits.Location = new System.Drawing.Point(38, 395);
            this.btnShowUnits.Name = "btnShowUnits";
            this.btnShowUnits.Size = new System.Drawing.Size(140, 30);
            this.btnShowUnits.TabIndex = 10;
            this.btnShowUnits.Text = "نمایش لیست واحدها";
            this.btnShowUnits.UseVisualStyleBackColor = true;
            this.btnShowUnits.Click += new System.EventHandler(this.btnShowUnits_Click);
            // 
            // btnEditUnit
            // 
            this.btnEditUnit.Location = new System.Drawing.Point(26, 75);
            this.btnEditUnit.Name = "btnEditUnit";
            this.btnEditUnit.Size = new System.Drawing.Size(140, 30);
            this.btnEditUnit.TabIndex = 8;
            this.btnEditUnit.Text = "ویرایش واحد";
            this.btnEditUnit.UseVisualStyleBackColor = true;
            this.btnEditUnit.Click += new System.EventHandler(this.btnEditUnit_Click);
            // 
            // btnDeleteUnit
            // 
            this.btnDeleteUnit.Location = new System.Drawing.Point(26, 46);
            this.btnDeleteUnit.Name = "btnDeleteUnit";
            this.btnDeleteUnit.Size = new System.Drawing.Size(140, 30);
            this.btnDeleteUnit.TabIndex = 7;
            this.btnDeleteUnit.Text = "حذف واحد";
            this.btnDeleteUnit.UseVisualStyleBackColor = true;
            this.btnDeleteUnit.Click += new System.EventHandler(this.btnDeleteUnit_Click);
            // 
            // btnPrevFrm
            // 
            this.btnPrevFrm.Location = new System.Drawing.Point(547, 395);
            this.btnPrevFrm.Name = "btnPrevFrm";
            this.btnPrevFrm.Size = new System.Drawing.Size(170, 30);
            this.btnPrevFrm.TabIndex = 2;
            this.btnPrevFrm.Text = "بازگشت به صفحه قبل";
            this.btnPrevFrm.UseVisualStyleBackColor = true;
            this.btnPrevFrm.Click += new System.EventHandler(this.btnPrevFrm_Click);
            // 
            // gbEditUnit
            // 
            this.gbEditUnit.Controls.Add(this.txtEditUnitName);
            this.gbEditUnit.Controls.Add(this.label7);
            this.gbEditUnit.Controls.Add(this.txtEditUnitCount);
            this.gbEditUnit.Controls.Add(this.label3);
            this.gbEditUnit.Controls.Add(this.txtEditUnitID);
            this.gbEditUnit.Controls.Add(this.btnEditUnit);
            this.gbEditUnit.Controls.Add(this.label4);
            this.gbEditUnit.Location = new System.Drawing.Point(12, 129);
            this.gbEditUnit.Name = "gbEditUnit";
            this.gbEditUnit.Size = new System.Drawing.Size(776, 154);
            this.gbEditUnit.TabIndex = 10;
            this.gbEditUnit.TabStop = false;
            this.gbEditUnit.Text = "ویرایش واحد";
            // 
            // txtEditUnitName
            // 
            this.txtEditUnitName.Location = new System.Drawing.Point(516, 102);
            this.txtEditUnitName.Name = "txtEditUnitName";
            this.txtEditUnitName.Size = new System.Drawing.Size(156, 24);
            this.txtEditUnitName.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(678, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "نام درس:";
            // 
            // txtEditUnitCount
            // 
            this.txtEditUnitCount.Location = new System.Drawing.Point(223, 50);
            this.txtEditUnitCount.Name = "txtEditUnitCount";
            this.txtEditUnitCount.Size = new System.Drawing.Size(156, 24);
            this.txtEditUnitCount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "تعداد واحد:";
            // 
            // txtEditUnitID
            // 
            this.txtEditUnitID.Location = new System.Drawing.Point(516, 50);
            this.txtEditUnitID.Name = "txtEditUnitID";
            this.txtEditUnitID.Size = new System.Drawing.Size(156, 24);
            this.txtEditUnitID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(682, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "شناسه واحد:";
            // 
            // gbDeleteUnit
            // 
            this.gbDeleteUnit.Controls.Add(this.label5);
            this.gbDeleteUnit.Controls.Add(this.btnDeleteUnit);
            this.gbDeleteUnit.Controls.Add(this.txtDeleteUnitID);
            this.gbDeleteUnit.Location = new System.Drawing.Point(12, 289);
            this.gbDeleteUnit.Name = "gbDeleteUnit";
            this.gbDeleteUnit.Size = new System.Drawing.Size(776, 100);
            this.gbDeleteUnit.TabIndex = 11;
            this.gbDeleteUnit.TabStop = false;
            this.gbDeleteUnit.Text = "حذف واحد";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(682, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "شناسه واحد:";
            // 
            // txtDeleteUnitID
            // 
            this.txtDeleteUnitID.Location = new System.Drawing.Point(516, 50);
            this.txtDeleteUnitID.Name = "txtDeleteUnitID";
            this.txtDeleteUnitID.Size = new System.Drawing.Size(156, 24);
            this.txtDeleteUnitID.TabIndex = 1;
            // 
            // requiredAddUnitName
            // 
            this.requiredAddUnitName.CancelFocusChangeWhenInvalid = false;
            this.requiredAddUnitName.ControlToValidate = this.txtAddUnitName;
            this.requiredAddUnitName.ErrorMessage = "لطفا نام واحد را وارد کنید.";
            this.requiredAddUnitName.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredAddUnitName.Icon")));
            // 
            // requiredEditUnitId
            // 
            this.requiredEditUnitId.CancelFocusChangeWhenInvalid = false;
            this.requiredEditUnitId.ControlToValidate = this.txtEditUnitID;
            this.requiredEditUnitId.ErrorMessage = "شناسه واحد را وارد کنید.";
            this.requiredEditUnitId.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredEditUnitId.Icon")));
            // 
            // requiredEditUnitName
            // 
            this.requiredEditUnitName.CancelFocusChangeWhenInvalid = false;
            this.requiredEditUnitName.ControlToValidate = this.txtEditUnitName;
            this.requiredEditUnitName.ErrorMessage = "لطفا نام واحد را وارد نمایید";
            this.requiredEditUnitName.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredEditUnitName.Icon")));
            // 
            // requiredDeleteUnitId
            // 
            this.requiredDeleteUnitId.CancelFocusChangeWhenInvalid = false;
            this.requiredDeleteUnitId.ControlToValidate = this.txtDeleteUnitID;
            this.requiredDeleteUnitId.ErrorMessage = "لطفا شناسه واحد را وارد نمایید.";
            this.requiredDeleteUnitId.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredDeleteUnitId.Icon")));
            // 
            // requiredAddUnitCount
            // 
            this.requiredAddUnitCount.CancelFocusChangeWhenInvalid = false;
            this.requiredAddUnitCount.ControlToValidate = this.txtAddUnitCount;
            this.requiredAddUnitCount.ErrorMessage = "لطفا تعداد واحد را وارد کنید.";
            this.requiredAddUnitCount.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredAddUnitCount.Icon")));
            this.requiredAddUnitCount.MaximumValue = "3";
            this.requiredAddUnitCount.MinimumValue = "1";
            this.requiredAddUnitCount.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // requiredEditUnitCount
            // 
            this.requiredEditUnitCount.CancelFocusChangeWhenInvalid = false;
            this.requiredEditUnitCount.ControlToValidate = this.txtEditUnitCount;
            this.requiredEditUnitCount.ErrorMessage = "لطفا تعداد واحد را وارد کنید.";
            this.requiredEditUnitCount.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredEditUnitCount.Icon")));
            this.requiredEditUnitCount.MaximumValue = "3";
            this.requiredEditUnitCount.MinimumValue = "1";
            this.requiredEditUnitCount.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // frmClassActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.gbDeleteUnit);
            this.Controls.Add(this.gbEditUnit);
            this.Controls.Add(this.btnShowUnits);
            this.Controls.Add(this.btnPrevFrm);
            this.Controls.Add(this.gbAddUnit);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClassActions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "عملیات مربوط به واحد";
            this.gbAddUnit.ResumeLayout(false);
            this.gbAddUnit.PerformLayout();
            this.gbEditUnit.ResumeLayout(false);
            this.gbEditUnit.PerformLayout();
            this.gbDeleteUnit.ResumeLayout(false);
            this.gbDeleteUnit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddUnit;
        private System.Windows.Forms.TextBox txtAddUnitName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddUnitCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteUnit;
        private System.Windows.Forms.Button btnPrevFrm;
        private System.Windows.Forms.Button btnAddUnit;
        private System.Windows.Forms.Button btnEditUnit;
        private System.Windows.Forms.Button btnShowUnits;
        private System.Windows.Forms.GroupBox gbEditUnit;
        private System.Windows.Forms.TextBox txtEditUnitCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditUnitID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEditUnitName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbDeleteUnit;
        private System.Windows.Forms.TextBox txtDeleteUnitID;
        private System.Windows.Forms.Label label5;
        private ValidationComponents.RequiredFieldValidator requiredAddUnitName;
        private ValidationComponents.RequiredFieldValidator requiredEditUnitId;
        private ValidationComponents.RequiredFieldValidator requiredEditUnitName;
        private ValidationComponents.RequiredFieldValidator requiredDeleteUnitId;
        private ValidationComponents.RangeValidator requiredAddUnitCount;
        private ValidationComponents.RangeValidator requiredEditUnitCount;
    }
}