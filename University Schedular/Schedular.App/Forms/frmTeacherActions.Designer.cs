namespace Schedular.App.Forms
{
    partial class frmTeacherActions
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
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.txtAddTeacher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEditTeacherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditTeacherID = new System.Windows.Forms.TextBox();
            this.btnEditTeacher = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.txtDeleteTeacherID = new System.Windows.Forms.TextBox();
            this.btnShowTeacher = new System.Windows.Forms.Button();
            this.btnPrevFrm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddTeacher);
            this.groupBox1.Controls.Add(this.txtAddTeacher);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "استاد جدید";
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(26, 46);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(140, 30);
            this.btnAddTeacher.TabIndex = 9;
            this.btnAddTeacher.Text = "اضافه کردن واحد";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            // 
            // txtAddTeacher
            // 
            this.txtAddTeacher.Location = new System.Drawing.Point(516, 50);
            this.txtAddTeacher.Name = "txtAddTeacher";
            this.txtAddTeacher.Size = new System.Drawing.Size(156, 24);
            this.txtAddTeacher.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(704, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام استاد:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEditTeacherName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtEditTeacherID);
            this.groupBox2.Controls.Add(this.btnEditTeacher);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ویرایش استاد";
            // 
            // txtEditTeacherName
            // 
            this.txtEditTeacherName.Location = new System.Drawing.Point(223, 50);
            this.txtEditTeacherName.Name = "txtEditTeacherName";
            this.txtEditTeacherName.Size = new System.Drawing.Size(156, 24);
            this.txtEditTeacherName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام استاد:";
            // 
            // txtEditTeacherID
            // 
            this.txtEditTeacherID.Location = new System.Drawing.Point(516, 50);
            this.txtEditTeacherID.Name = "txtEditTeacherID";
            this.txtEditTeacherID.Size = new System.Drawing.Size(156, 24);
            this.txtEditTeacherID.TabIndex = 1;
            // 
            // btnEditTeacher
            // 
            this.btnEditTeacher.Location = new System.Drawing.Point(26, 43);
            this.btnEditTeacher.Name = "btnEditTeacher";
            this.btnEditTeacher.Size = new System.Drawing.Size(140, 30);
            this.btnEditTeacher.TabIndex = 8;
            this.btnEditTeacher.Text = "ویرایش واحد";
            this.btnEditTeacher.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(682, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "شناسه استاد:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnDeleteTeacher);
            this.groupBox3.Controls.Add(this.txtDeleteTeacherID);
            this.groupBox3.Location = new System.Drawing.Point(12, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "حذف استاد";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(682, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "شناسه استاد:";
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.Location = new System.Drawing.Point(26, 46);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(140, 30);
            this.btnDeleteTeacher.TabIndex = 7;
            this.btnDeleteTeacher.Text = "حذف واحد";
            this.btnDeleteTeacher.UseVisualStyleBackColor = true;
            // 
            // txtDeleteTeacherID
            // 
            this.txtDeleteTeacherID.Location = new System.Drawing.Point(516, 50);
            this.txtDeleteTeacherID.Name = "txtDeleteTeacherID";
            this.txtDeleteTeacherID.Size = new System.Drawing.Size(156, 24);
            this.txtDeleteTeacherID.TabIndex = 1;
            // 
            // btnShowTeacher
            // 
            this.btnShowTeacher.Location = new System.Drawing.Point(37, 330);
            this.btnShowTeacher.Name = "btnShowTeacher";
            this.btnShowTeacher.Size = new System.Drawing.Size(140, 30);
            this.btnShowTeacher.TabIndex = 14;
            this.btnShowTeacher.Text = "نمایش لیست اساتید";
            this.btnShowTeacher.UseVisualStyleBackColor = true;
            this.btnShowTeacher.Click += new System.EventHandler(this.btnShowTeacher_Click);
            // 
            // btnPrevFrm
            // 
            this.btnPrevFrm.Location = new System.Drawing.Point(546, 330);
            this.btnPrevFrm.Name = "btnPrevFrm";
            this.btnPrevFrm.Size = new System.Drawing.Size(170, 30);
            this.btnPrevFrm.TabIndex = 13;
            this.btnPrevFrm.Text = "بازگشت به صفحه قبل";
            this.btnPrevFrm.UseVisualStyleBackColor = true;
            this.btnPrevFrm.Click += new System.EventHandler(this.btnPrevFrm_Click);
            // 
            // frmTeacherActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.btnShowTeacher);
            this.Controls.Add(this.btnPrevFrm);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTeacherActions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "عملیات مربوط به اساتید";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.TextBox txtAddTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEditTeacherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditTeacherID;
        private System.Windows.Forms.Button btnEditTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.TextBox txtDeleteTeacherID;
        private System.Windows.Forms.Button btnShowTeacher;
        private System.Windows.Forms.Button btnPrevFrm;
    }
}