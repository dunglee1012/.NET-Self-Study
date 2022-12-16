namespace New_Project_Form_PRN211
{
    partial class TuitionFeePerCourse_Form
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
            this.dgv_TuitionFee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TuitionFee)).BeginInit();
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
            this.label1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(294, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tuition Fee Per Course";
            // 
            // dgv_TuitionFee
            // 
            this.dgv_TuitionFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TuitionFee.Location = new System.Drawing.Point(12, 87);
            this.dgv_TuitionFee.Name = "dgv_TuitionFee";
            this.dgv_TuitionFee.RowTemplate.Height = 25;
            this.dgv_TuitionFee.Size = new System.Drawing.Size(776, 351);
            this.dgv_TuitionFee.TabIndex = 2;
            // 
            // TuitionFeePerCourse_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_TuitionFee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackToHome);
            this.Name = "TuitionFeePerCourse_Form";
            this.Text = "TuitionFeePerCourse_Form";
            this.Load += new System.EventHandler(this.TuitionFeePerCourse_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TuitionFee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel BackToHome;
        private Label label1;
        private DataGridView dgv_TuitionFee;
    }
}