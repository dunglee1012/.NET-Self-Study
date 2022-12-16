namespace New_Project_Form_PRN211
{
    partial class Timetable_Form
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
            this.BackToHome = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCampus = new System.Windows.Forms.ListBox();
            this.lbTerm = new System.Windows.Forms.ListBox();
            this.lbGroup = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // BackToHome
            // 
            this.BackToHome.AutoSize = true;
            this.BackToHome.Location = new System.Drawing.Point(12, 9);
            this.BackToHome.Name = "BackToHome";
            this.BackToHome.Size = new System.Drawing.Size(83, 15);
            this.BackToHome.TabIndex = 0;
            this.BackToHome.TabStop = true;
            this.BackToHome.Text = "Back To Home";
            this.BackToHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackToHome_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Name for groups";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Campus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Term";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Group";
            // 
            // lbCampus
            // 
            this.lbCampus.FormattingEnabled = true;
            this.lbCampus.ItemHeight = 15;
            this.lbCampus.Location = new System.Drawing.Point(12, 79);
            this.lbCampus.Name = "lbCampus";
            this.lbCampus.Size = new System.Drawing.Size(131, 64);
            this.lbCampus.TabIndex = 3;
            this.lbCampus.SelectedValueChanged += new System.EventHandler(this.lbCampus_SelectedValueChanged);
            // 
            // lbTerm
            // 
            this.lbTerm.FormattingEnabled = true;
            this.lbTerm.ItemHeight = 15;
            this.lbTerm.Location = new System.Drawing.Point(162, 79);
            this.lbTerm.Name = "lbTerm";
            this.lbTerm.Size = new System.Drawing.Size(131, 64);
            this.lbTerm.TabIndex = 3;
            this.lbTerm.SelectedValueChanged += new System.EventHandler(this.lbTerm_SelectedValueChanged);
            // 
            // lbGroup
            // 
            this.lbGroup.FormattingEnabled = true;
            this.lbGroup.ItemHeight = 15;
            this.lbGroup.Location = new System.Drawing.Point(316, 79);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(131, 64);
            this.lbGroup.TabIndex = 3;
            this.lbGroup.SelectedValueChanged += new System.EventHandler(this.lbGroup_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(227, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Time Table";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 149);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(908, 457);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Timetable_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 618);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbGroup);
            this.Controls.Add(this.lbTerm);
            this.Controls.Add(this.lbCampus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackToHome);
            this.Name = "Timetable_Form";
            this.Text = "Thời Khóa Biểu";
            this.Load += new System.EventHandler(this.ClassTimeTable_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel BackToHome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox lbCampus;
        private ListBox lbTerm;
        private ListBox lbGroup;
        private Label label7;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}