namespace New_Project_Form_PRN211
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel_ExamSchedule = new System.Windows.Forms.LinkLabel();
            this.linkLabel_AttendReport = new System.Windows.Forms.LinkLabel();
            this.linkLabel_TuitionPerCourse = new System.Windows.Forms.LinkLabel();
            this.linkLabel_ClassTimetable = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "FPT University Academic Portal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.linkLabel_ExamSchedule);
            this.groupBox1.Controls.Add(this.linkLabel_AttendReport);
            this.groupBox1.Controls.Add(this.linkLabel_TuitionPerCourse);
            this.groupBox1.Controls.Add(this.linkLabel_ClassTimetable);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(65, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1059, 422);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Academic Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(789, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "Báo Cáo Điểm Danh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(292, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Xem Lịch Thi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(309, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 30);
            this.label8.TabIndex = 2;
            this.label8.Text = "Biểu Học Phí";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(246, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời Khóa Biểu Một Lớp";
            // 
            // linkLabel_ExamSchedule
            // 
            this.linkLabel_ExamSchedule.AutoSize = true;
            this.linkLabel_ExamSchedule.Location = new System.Drawing.Point(83, 317);
            this.linkLabel_ExamSchedule.Name = "linkLabel_ExamSchedule";
            this.linkLabel_ExamSchedule.Size = new System.Drawing.Size(203, 30);
            this.linkLabel_ExamSchedule.TabIndex = 1;
            this.linkLabel_ExamSchedule.TabStop = true;
            this.linkLabel_ExamSchedule.Text = "View Exam Schedule";
            this.linkLabel_ExamSchedule.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ExamSchedule_LinkClicked);
            // 
            // linkLabel_AttendReport
            // 
            this.linkLabel_AttendReport.AutoSize = true;
            this.linkLabel_AttendReport.Location = new System.Drawing.Point(590, 114);
            this.linkLabel_AttendReport.Name = "linkLabel_AttendReport";
            this.linkLabel_AttendReport.Size = new System.Drawing.Size(187, 30);
            this.linkLabel_AttendReport.TabIndex = 1;
            this.linkLabel_AttendReport.TabStop = true;
            this.linkLabel_AttendReport.Text = "Attendance Report";
            this.linkLabel_AttendReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_AttendReport_LinkClicked);
            // 
            // linkLabel_TuitionPerCourse
            // 
            this.linkLabel_TuitionPerCourse.AutoSize = true;
            this.linkLabel_TuitionPerCourse.Location = new System.Drawing.Point(83, 213);
            this.linkLabel_TuitionPerCourse.Name = "linkLabel_TuitionPerCourse";
            this.linkLabel_TuitionPerCourse.Size = new System.Drawing.Size(220, 30);
            this.linkLabel_TuitionPerCourse.TabIndex = 1;
            this.linkLabel_TuitionPerCourse.TabStop = true;
            this.linkLabel_TuitionPerCourse.Text = "Tuition Fee Per Course";
            this.linkLabel_TuitionPerCourse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_TuitionPerCourse_LinkClicked);
            // 
            // linkLabel_ClassTimetable
            // 
            this.linkLabel_ClassTimetable.AutoSize = true;
            this.linkLabel_ClassTimetable.Location = new System.Drawing.Point(83, 114);
            this.linkLabel_ClassTimetable.Name = "linkLabel_ClassTimetable";
            this.linkLabel_ClassTimetable.Size = new System.Drawing.Size(157, 30);
            this.linkLabel_ClassTimetable.TabIndex = 1;
            this.linkLabel_ClassTimetable.TabStop = true;
            this.linkLabel_ClassTimetable.Text = "Class Timetable";
            this.linkLabel_ClassTimetable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ClassTimetable_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Report (Báo Cáo)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Information Access (Tra Cứu Thông Tin)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 533);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private LinkLabel linkLabel_ExamSchedule;
        private LinkLabel linkLabel_AttendReport;
        private LinkLabel linkLabel_TuitionPerCourse;
        private LinkLabel linkLabel_ClassTimetable;
        private Label label6;
        private Label label4;
        private Label label8;
        private Label label3;
        private Label label5;
    }
}