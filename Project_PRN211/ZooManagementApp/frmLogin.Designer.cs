namespace ZooManagementApp
{
    partial class frmLogin
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
            pictureBox1=new PictureBox();
            pictureBox2=new PictureBox();
            pictureBox3=new PictureBox();
            pictureBox4=new PictureBox();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            txtEmail=new TextBox();
            txtPassword=new TextBox();
            btnLogin=new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image=Properties.Resources.logone;
            pictureBox1.Location=new Point(39, 12);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(320, 350);
            pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex=1;
            pictureBox1.TabStop=false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor=SystemColors.ControlLightLight;
            pictureBox2.Image=Properties.Resources.icons8_email_30;
            pictureBox2.Location=new Point(417, 118);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(30, 38);
            pictureBox2.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex=2;
            pictureBox2.TabStop=false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image=Properties.Resources.icons8_manager_32;
            pictureBox3.Location=new Point(497, 12);
            pictureBox3.Name="pictureBox3";
            pictureBox3.Size=new Size(68, 58);
            pictureBox3.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex=3;
            pictureBox3.TabStop=false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image=Properties.Resources.icons8_password_30;
            pictureBox4.Location=new Point(417, 189);
            pictureBox4.Name="pictureBox4";
            pictureBox4.Size=new Size(30, 30);
            pictureBox4.SizeMode=PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex=4;
            pictureBox4.TabStop=false;
            // 
            // label1
            // 
            label1.BackColor=SystemColors.ActiveCaptionText;
            label1.Location=new Point(495, 73);
            label1.Name="label1";
            label1.Size=new Size(70, 2);
            label1.TabIndex=5;
            label1.Text="label1";
            // 
            // label2
            // 
            label2.BackColor=SystemColors.ActiveCaptionText;
            label2.Location=new Point(447, 154);
            label2.Name="label2";
            label2.Size=new Size(200, 2);
            label2.TabIndex=6;
            label2.Text="label2";
            // 
            // label3
            // 
            label3.BackColor=SystemColors.ActiveCaptionText;
            label3.Location=new Point(453, 217);
            label3.Name="label3";
            label3.Size=new Size(200, 2);
            label3.TabIndex=7;
            label3.Text="label3";
            // 
            // txtEmail
            // 
            txtEmail.BackColor=Color.White;
            txtEmail.BorderStyle=BorderStyle.None;
            txtEmail.Font=new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location=new Point(450, 126);
            txtEmail.Name="txtEmail";
            txtEmail.Size=new Size(200, 25);
            txtEmail.TabIndex=8;
            // 
            // txtPassword
            // 
            txtPassword.BackColor=Color.White;
            txtPassword.BorderStyle=BorderStyle.None;
            txtPassword.Font=new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location=new Point(447, 187);
            txtPassword.Name="txtPassword";
            txtPassword.PasswordChar='*';
            txtPassword.Size=new Size(197, 27);
            txtPassword.TabIndex=9;
            // 
            // btnLogin
            // 
            btnLogin.AutoEllipsis=true;
            btnLogin.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location=new Point(495, 257);
            btnLogin.Name="btnLogin";
            btnLogin.Size=new Size(104, 35);
            btnLogin.TabIndex=10;
            btnLogin.Text="Login";
            btnLogin.UseVisualStyleBackColor=true;
            btnLogin.Click+=btnLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.ButtonHighlight;
            ClientSize=new Size(731, 387);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name="frmLogin";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Login";
            Load+=Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}