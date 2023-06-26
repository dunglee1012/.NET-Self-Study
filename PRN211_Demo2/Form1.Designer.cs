namespace PRN211_Demo2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.rd_Female = new System.Windows.Forms.RadioButton();
            this.rd_Male = new System.Windows.Forms.RadioButton();
            this.rdMale_Female = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPosition);
            this.groupBox1.Controls.Add(this.rd_Female);
            this.groupBox1.Controls.Add(this.rd_Male);
            this.groupBox1.Controls.Add(this.rdMale_Female);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Location = new System.Drawing.Point(35, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(88, 119);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(149, 23);
            this.cbPosition.TabIndex = 3;
            this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.cbPosition_SelectedIndexChanged);
            // 
            // rd_Female
            // 
            this.rd_Female.AutoSize = true;
            this.rd_Female.Location = new System.Drawing.Point(189, 82);
            this.rd_Female.Name = "rd_Female";
            this.rd_Female.Size = new System.Drawing.Size(63, 19);
            this.rd_Female.TabIndex = 2;
            this.rd_Female.TabStop = true;
            this.rd_Female.Text = "Female";
            this.rd_Female.UseVisualStyleBackColor = true;
            this.rd_Female.CheckedChanged += new System.EventHandler(this.rd_Female_CheckedChanged);
            // 
            // rd_Male
            // 
            this.rd_Male.AutoSize = true;
            this.rd_Male.Location = new System.Drawing.Point(132, 82);
            this.rd_Male.Name = "rd_Male";
            this.rd_Male.Size = new System.Drawing.Size(51, 19);
            this.rd_Male.TabIndex = 2;
            this.rd_Male.TabStop = true;
            this.rd_Male.Text = "Male";
            this.rd_Male.UseVisualStyleBackColor = true;
            this.rd_Male.CheckedChanged += new System.EventHandler(this.rd_Male_CheckedChanged);
            // 
            // rdMale_Female
            // 
            this.rdMale_Female.AutoSize = true;
            this.rdMale_Female.Location = new System.Drawing.Point(32, 82);
            this.rdMale_Female.Name = "rdMale_Female";
            this.rdMale_Female.Size = new System.Drawing.Size(94, 19);
            this.rdMale_Female.TabIndex = 2;
            this.rdMale_Female.TabStop = true;
            this.rdMale_Female.Text = "Male/Female";
            this.rdMale_Female.UseVisualStyleBackColor = true;
            this.rdMale_Female.CheckedChanged += new System.EventHandler(this.rdMale_Female_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Position";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(88, 47);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(149, 23);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // dgvOutput
            // 
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Location = new System.Drawing.Point(342, 61);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.RowTemplate.Height = 25;
            this.dgvOutput.Size = new System.Drawing.Size(657, 359);
            this.dgvOutput.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.dgvOutput);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbPosition;
        private RadioButton rd_Female;
        private RadioButton rd_Male;
        private RadioButton rdMale_Female;
        private Label label2;
        private Label label1;
        private TextBox tbName;
        private DataGridView dgvOutput;
    }
}