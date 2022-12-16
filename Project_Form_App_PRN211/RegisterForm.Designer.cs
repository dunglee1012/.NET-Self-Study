namespace Project_Form_App_PRN211
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTermCondition = new System.Windows.Forms.CheckBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.tbRegisterRePassword = new System.Windows.Forms.TextBox();
            this.tbRegisterPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRegisterUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to FAP beta 1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTermCondition);
            this.panel1.Controls.Add(this.btnCreateAccount);
            this.panel1.Controls.Add(this.tbRegisterRePassword);
            this.panel1.Controls.Add(this.tbRegisterPassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbRegisterUsername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(158, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 206);
            this.panel1.TabIndex = 3;
            // 
            // cbTermCondition
            // 
            this.cbTermCondition.AutoSize = true;
            this.cbTermCondition.Location = new System.Drawing.Point(51, 137);
            this.cbTermCondition.Name = "cbTermCondition";
            this.cbTermCondition.Size = new System.Drawing.Size(192, 19);
            this.cbTermCondition.TabIndex = 3;
            this.cbTermCondition.Text = "I agree with term and condition";
            this.cbTermCondition.UseVisualStyleBackColor = true;
            this.cbTermCondition.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Enabled = false;
            this.btnCreateAccount.Location = new System.Drawing.Point(211, 161);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(144, 22);
            this.btnCreateAccount.TabIndex = 2;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // tbRegisterRePassword
            // 
            this.tbRegisterRePassword.Location = new System.Drawing.Point(211, 90);
            this.tbRegisterRePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRegisterRePassword.Name = "tbRegisterRePassword";
            this.tbRegisterRePassword.Size = new System.Drawing.Size(144, 23);
            this.tbRegisterRePassword.TabIndex = 1;
            // 
            // tbRegisterPassword
            // 
            this.tbRegisterPassword.Location = new System.Drawing.Point(211, 58);
            this.tbRegisterPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRegisterPassword.Name = "tbRegisterPassword";
            this.tbRegisterPassword.Size = new System.Drawing.Size(144, 23);
            this.tbRegisterPassword.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Confirm Password";
            // 
            // tbRegisterUsername
            // 
            this.tbRegisterUsername.Location = new System.Drawing.Point(211, 24);
            this.tbRegisterUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRegisterUsername.Name = "tbRegisterUsername";
            this.tbRegisterUsername.Size = new System.Drawing.Size(144, 23);
            this.tbRegisterUsername.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Already Have Account?";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(387, 295);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(103, 22);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(158, 283);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(410, 44);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterForm";
            this.Text = "Register Account";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnCreateAccount;
        private TextBox tbRegisterRePassword;
        private TextBox tbRegisterPassword;
        private Label label4;
        private TextBox tbRegisterUsername;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button btnLogin;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox cbTermCondition;
    }
}