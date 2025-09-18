namespace Schedular.App.Forms
{
    partial class frmEditCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCourse));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDayOfWeek = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClassGroup = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCourseTiltle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lableID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtStartTime = new System.Windows.Forms.MaskedTextBox();
            this.txtEndTime = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEndTime);
            this.groupBox1.Controls.Add(this.txtStartTime);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtCapacity);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDayOfWeek);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtClassGroup);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTerm);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTeacherName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtUnits);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCourseTiltle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lableID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات کلاس";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(60, 414);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 30);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(253, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(6, 184);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(124, 24);
            this.txtCapacity.TabIndex = 19;
            this.txtCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "ظرفیت:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(163, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "زمان پایان:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "زمان شروع:";
            // 
            // txtDayOfWeek
            // 
            this.txtDayOfWeek.Location = new System.Drawing.Point(236, 336);
            this.txtDayOfWeek.Name = "txtDayOfWeek";
            this.txtDayOfWeek.Size = new System.Drawing.Size(121, 24);
            this.txtDayOfWeek.TabIndex = 13;
            this.txtDayOfWeek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "روز هفته:";
            // 
            // txtClassGroup
            // 
            this.txtClassGroup.Location = new System.Drawing.Point(236, 284);
            this.txtClassGroup.Name = "txtClassGroup";
            this.txtClassGroup.Size = new System.Drawing.Size(121, 24);
            this.txtClassGroup.TabIndex = 11;
            this.txtClassGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "گروه:";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(236, 235);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(121, 24);
            this.txtTerm.TabIndex = 9;
            this.txtTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "ترم:";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(236, 184);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(121, 24);
            this.txtTeacherName.TabIndex = 7;
            this.txtTeacherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "نام استاد:";
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(236, 131);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(121, 24);
            this.txtUnits.TabIndex = 5;
            this.txtUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "واحد:";
            // 
            // txtCourseTiltle
            // 
            this.txtCourseTiltle.Location = new System.Drawing.Point(236, 79);
            this.txtCourseTiltle.Name = "txtCourseTiltle";
            this.txtCourseTiltle.Size = new System.Drawing.Size(121, 24);
            this.txtCourseTiltle.TabIndex = 3;
            this.txtCourseTiltle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام درس:";
            // 
            // lableID
            // 
            this.lableID.AutoSize = true;
            this.lableID.Location = new System.Drawing.Point(342, 42);
            this.lableID.Name = "lableID";
            this.lableID.Size = new System.Drawing.Size(0, 17);
            this.lableID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "شناسه کلاس:";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(6, 79);
            this.txtStartTime.Mask = "90:00";
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(124, 24);
            this.txtStartTime.TabIndex = 23;
            this.txtStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStartTime.ValidatingType = typeof(System.DateTime);
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(6, 131);
            this.txtEndTime.Mask = "90:00";
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(124, 24);
            this.txtEndTime.TabIndex = 24;
            this.txtEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEndTime.ValidatingType = typeof(System.DateTime);
            // 
            // frmEditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 481);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditCourse";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ویرایش کلاس";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lableID;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCourseTiltle;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDayOfWeek;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClassGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MaskedTextBox txtEndTime;
        private System.Windows.Forms.MaskedTextBox txtStartTime;
    }
}