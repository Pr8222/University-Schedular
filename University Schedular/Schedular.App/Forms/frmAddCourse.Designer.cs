namespace Schedular.App.Forms
{
    partial class frmAddCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCourse));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextEndTime = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxDayOfWeek = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClassGroup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveSuggestions = new System.Windows.Forms.Button();
            this.btnSuggestWithAi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvSuggestedSchdules = new System.Windows.Forms.DataGridView();
            this.maskedTextStartTime = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuggestedSchdules)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextEndTime);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBoxDayOfWeek);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCapacity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtUnits);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtClassGroup);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTeacherName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTerm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCourseTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات درس";
            // 
            // maskedTextEndTime
            // 
            this.maskedTextEndTime.Location = new System.Drawing.Point(66, 60);
            this.maskedTextEndTime.Mask = "00:00";
            this.maskedTextEndTime.Name = "maskedTextEndTime";
            this.maskedTextEndTime.Size = new System.Drawing.Size(43, 24);
            this.maskedTextEndTime.TabIndex = 18;
            this.maskedTextEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextEndTime.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "زمان پایان کلاس: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "زمان شروع کلاس: ";
            // 
            // comboBoxDayOfWeek
            // 
            this.comboBoxDayOfWeek.FormattingEnabled = true;
            this.comboBoxDayOfWeek.Items.AddRange(new object[] {
            "شنبه",
            "یکشنبه",
            "دوشنبه",
            "سه‌شنبه",
            "چهارشنبه",
            "پنجشنبه",
            "جمعه"});
            this.comboBoxDayOfWeek.Location = new System.Drawing.Point(410, 60);
            this.comboBoxDayOfWeek.Name = "comboBoxDayOfWeek";
            this.comboBoxDayOfWeek.Size = new System.Drawing.Size(121, 25);
            this.comboBoxDayOfWeek.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(537, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "روز هفته: ";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(625, 60);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(43, 24);
            this.txtCapacity.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(674, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "ظرفیت: ";
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(755, 60);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(27, 24);
            this.txtUnits.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(788, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "واحد:";
            // 
            // txtClassGroup
            // 
            this.txtClassGroup.Location = new System.Drawing.Point(6, 30);
            this.txtClassGroup.Name = "txtClassGroup";
            this.txtClassGroup.Size = new System.Drawing.Size(86, 24);
            this.txtClassGroup.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "گروه درسی: ";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(181, 30);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(200, 24);
            this.txtTeacherName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "نام استاد: ";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(468, 30);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(63, 24);
            this.txtTerm.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ترم: ";
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.Location = new System.Drawing.Point(582, 30);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.Size = new System.Drawing.Size(200, 24);
            this.txtCourseTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(788, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام درس: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveSuggestions);
            this.groupBox2.Controls.Add(this.btnSuggestWithAi);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عملیات";
            // 
            // btnSaveSuggestions
            // 
            this.btnSaveSuggestions.Location = new System.Drawing.Point(48, 14);
            this.btnSaveSuggestions.Name = "btnSaveSuggestions";
            this.btnSaveSuggestions.Size = new System.Drawing.Size(120, 30);
            this.btnSaveSuggestions.TabIndex = 3;
            this.btnSaveSuggestions.Text = "ذخیره پیشنهادات";
            this.btnSaveSuggestions.UseVisualStyleBackColor = true;
            // 
            // btnSuggestWithAi
            // 
            this.btnSuggestWithAi.Location = new System.Drawing.Point(253, 14);
            this.btnSuggestWithAi.Name = "btnSuggestWithAi";
            this.btnSuggestWithAi.Size = new System.Drawing.Size(120, 30);
            this.btnSuggestWithAi.TabIndex = 2;
            this.btnSuggestWithAi.Text = "پیشنهاد AI";
            this.btnSuggestWithAi.UseVisualStyleBackColor = true;
            this.btnSuggestWithAi.Click += new System.EventHandler(this.btnSuggestWithAi_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "ذخیره درس";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "انصراف";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvSuggestedSchdules
            // 
            this.dgvSuggestedSchdules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuggestedSchdules.Location = new System.Drawing.Point(12, 175);
            this.dgvSuggestedSchdules.Name = "dgvSuggestedSchdules";
            this.dgvSuggestedSchdules.RowHeadersWidth = 51;
            this.dgvSuggestedSchdules.RowTemplate.Height = 24;
            this.dgvSuggestedSchdules.Size = new System.Drawing.Size(860, 300);
            this.dgvSuggestedSchdules.TabIndex = 0;
            // 
            // maskedTextStartTime
            // 
            this.maskedTextStartTime.Location = new System.Drawing.Point(249, 73);
            this.maskedTextStartTime.Mask = "00:00";
            this.maskedTextStartTime.Name = "maskedTextStartTime";
            this.maskedTextStartTime.Size = new System.Drawing.Size(43, 24);
            this.maskedTextStartTime.TabIndex = 16;
            this.maskedTextStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextStartTime.ValidatingType = typeof(System.DateTime);
            // 
            // frmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 483);
            this.Controls.Add(this.dgvSuggestedSchdules);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.maskedTextStartTime);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddCourse";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اضافه کردن کلاس";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuggestedSchdules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSuggestedSchdules;
        private System.Windows.Forms.TextBox txtCourseTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDayOfWeek;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextEndTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextStartTime;
        private System.Windows.Forms.Button btnSaveSuggestions;
        private System.Windows.Forms.Button btnSuggestWithAi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}