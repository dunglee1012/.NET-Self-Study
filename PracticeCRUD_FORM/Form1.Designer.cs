namespace PracticeCRUD_FORM
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
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTeachingDate = new System.Windows.Forms.DateTimePicker();
            this.cbRoomCode = new System.Windows.Forms.ComboBox();
            this.cbCourseCode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSlot = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbTeachingScheduleID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnREFRESH = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOutput
            // 
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Location = new System.Drawing.Point(12, 26);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.RowTemplate.Height = 25;
            this.dgvOutput.Size = new System.Drawing.Size(407, 322);
            this.dgvOutput.TabIndex = 0;
            this.dgvOutput.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTeachingDate);
            this.groupBox1.Controls.Add(this.cbRoomCode);
            this.groupBox1.Controls.Add(this.cbCourseCode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbSlot);
            this.groupBox1.Controls.Add(this.tbDescription);
            this.groupBox1.Controls.Add(this.tbTeachingScheduleID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEDIT);
            this.groupBox1.Controls.Add(this.btnREFRESH);
            this.groupBox1.Controls.Add(this.btnDELETE);
            this.groupBox1.Controls.Add(this.btnADD);
            this.groupBox1.Location = new System.Drawing.Point(444, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 322);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Info";
            // 
            // dtpTeachingDate
            // 
            this.dtpTeachingDate.Location = new System.Drawing.Point(139, 149);
            this.dtpTeachingDate.Name = "dtpTeachingDate";
            this.dtpTeachingDate.Size = new System.Drawing.Size(200, 23);
            this.dtpTeachingDate.TabIndex = 4;
            // 
            // cbRoomCode
            // 
            this.cbRoomCode.FormattingEnabled = true;
            this.cbRoomCode.Location = new System.Drawing.Point(139, 113);
            this.cbRoomCode.Name = "cbRoomCode";
            this.cbRoomCode.Size = new System.Drawing.Size(121, 23);
            this.cbRoomCode.TabIndex = 3;
            // 
            // cbCourseCode
            // 
            this.cbCourseCode.FormattingEnabled = true;
            this.cbCourseCode.Location = new System.Drawing.Point(139, 75);
            this.cbCourseCode.Name = "cbCourseCode";
            this.cbCourseCode.Size = new System.Drawing.Size(121, 23);
            this.cbCourseCode.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Slot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "TeachingDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Room Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Code";
            // 
            // tbSlot
            // 
            this.tbSlot.Location = new System.Drawing.Point(139, 217);
            this.tbSlot.Name = "tbSlot";
            this.tbSlot.Size = new System.Drawing.Size(100, 23);
            this.tbSlot.TabIndex = 2;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(139, 188);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(100, 23);
            this.tbDescription.TabIndex = 2;
            // 
            // tbTeachingScheduleID
            // 
            this.tbTeachingScheduleID.Location = new System.Drawing.Point(139, 37);
            this.tbTeachingScheduleID.Name = "tbTeachingScheduleID";
            this.tbTeachingScheduleID.Size = new System.Drawing.Size(100, 23);
            this.tbTeachingScheduleID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "TeachingScheduleId";
            // 
            // btnEDIT
            // 
            this.btnEDIT.Location = new System.Drawing.Point(256, 261);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(64, 23);
            this.btnEDIT.TabIndex = 0;
            this.btnEDIT.Text = "EDIT";
            this.btnEDIT.UseVisualStyleBackColor = true;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // btnREFRESH
            // 
            this.btnREFRESH.Location = new System.Drawing.Point(175, 261);
            this.btnREFRESH.Name = "btnREFRESH";
            this.btnREFRESH.Size = new System.Drawing.Size(64, 23);
            this.btnREFRESH.TabIndex = 0;
            this.btnREFRESH.Text = "REFRESH";
            this.btnREFRESH.UseVisualStyleBackColor = true;
            this.btnREFRESH.Click += new System.EventHandler(this.btnREFRESH_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(94, 261);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(64, 23);
            this.btnDELETE.TabIndex = 0;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(13, 261);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(64, 23);
            this.btnADD.TabIndex = 0;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvOutput;
        private GroupBox groupBox1;
        private Button btnEDIT;
        private Button btnREFRESH;
        private Button btnDELETE;
        private Button btnADD;
        private ComboBox cbCourseCode;
        private Label label5;
        private Label label2;
        private TextBox tbTeachingScheduleID;
        private Label label1;
        private ComboBox cbRoomCode;
        private Label label4;
        private Label label3;
        private TextBox tbDescription;
        private DateTimePicker dtpTeachingDate;
        private Label label6;
        private TextBox tbSlot;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}