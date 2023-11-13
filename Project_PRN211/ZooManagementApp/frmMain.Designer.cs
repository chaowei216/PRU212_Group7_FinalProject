namespace ZooManagementApp
{
    partial class frmMain
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
            components=new System.ComponentModel.Container();
            pictureBox1=new PictureBox();
            label1=new Label();
            btnExit=new Button();
            menuStrip1=new MenuStrip();
            mnuAnimals=new ToolStripMenuItem();
            menuStrip2=new MenuStrip();
            mnuFood=new ToolStripMenuItem();
            menuStrip3=new MenuStrip();
            mnuCage=new ToolStripMenuItem();
            menuStrip4=new MenuStrip();
            mnuUser=new ToolStripMenuItem();
            menuStrip5=new MenuStrip();
            mnuSchedule=new ToolStripMenuItem();
            Role=new Label();
            panel1=new Panel();
            contextMenuStrip1=new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            menuStrip3.SuspendLayout();
            menuStrip4.SuspendLayout();
            menuStrip5.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image=Properties.Resources.logone;
            pictureBox1.Location=new Point(7, 0);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(120, 89);
            pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(123, 0);
            label1.Name="label1";
            label1.Size=new Size(107, 27);
            label1.TabIndex=1;
            label1.Text="Welcome ";
            // 
            // btnExit
            // 
            btnExit.BackColor=SystemColors.ActiveBorder;
            btnExit.Font=new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location=new Point(12, 394);
            btnExit.Name="btnExit";
            btnExit.Size=new Size(94, 41);
            btnExit.TabIndex=2;
            btnExit.Text="Exit";
            btnExit.UseVisualStyleBackColor=false;
            btnExit.Click+=btnExit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor=SystemColors.ActiveBorder;
            menuStrip1.Dock=DockStyle.None;
            menuStrip1.Font=new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize=new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuAnimals });
            menuStrip1.Location=new Point(11, 157);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new Size(100, 33);
            menuStrip1.TabIndex=3;
            menuStrip1.Text="menuStrip1";
            // 
            // mnuAnimals
            // 
            mnuAnimals.BackColor=SystemColors.ActiveBorder;
            mnuAnimals.Name="mnuAnimals";
            mnuAnimals.Size=new Size(92, 29);
            mnuAnimals.Text="Animals";
            mnuAnimals.Click+=mnuAnimals_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor=SystemColors.ActiveBorder;
            menuStrip2.Dock=DockStyle.None;
            menuStrip2.ImageScalingSize=new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { mnuFood });
            menuStrip2.Location=new Point(11, 198);
            menuStrip2.Name="menuStrip2";
            menuStrip2.Size=new Size(76, 33);
            menuStrip2.TabIndex=4;
            menuStrip2.Text="menuStrip2";
            // 
            // mnuFood
            // 
            mnuFood.BackColor=SystemColors.ActiveBorder;
            mnuFood.Font=new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            mnuFood.Name="mnuFood";
            mnuFood.Size=new Size(68, 29);
            mnuFood.Text="Food";
            mnuFood.Click+=mnuFood_Click;
            // 
            // menuStrip3
            // 
            menuStrip3.BackColor=SystemColors.ActiveBorder;
            menuStrip3.Dock=DockStyle.None;
            menuStrip3.ImageScalingSize=new Size(20, 20);
            menuStrip3.Items.AddRange(new ToolStripItem[] { mnuCage });
            menuStrip3.Location=new Point(11, 243);
            menuStrip3.Name="menuStrip3";
            menuStrip3.Size=new Size(75, 33);
            menuStrip3.TabIndex=5;
            menuStrip3.Text="menuStrip3";
            // 
            // mnuCage
            // 
            mnuCage.BackColor=SystemColors.ActiveBorder;
            mnuCage.Font=new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            mnuCage.Name="mnuCage";
            mnuCage.Size=new Size(67, 29);
            mnuCage.Text="Cage";
            mnuCage.Click+=mnuCage_Click;
            // 
            // menuStrip4
            // 
            menuStrip4.BackColor=SystemColors.ActiveBorder;
            menuStrip4.Dock=DockStyle.None;
            menuStrip4.ImageScalingSize=new Size(20, 20);
            menuStrip4.Items.AddRange(new ToolStripItem[] { mnuUser });
            menuStrip4.Location=new Point(11, 116);
            menuStrip4.Name="menuStrip4";
            menuStrip4.Size=new Size(72, 33);
            menuStrip4.TabIndex=6;
            menuStrip4.Text="menuStrip4";
            // 
            // mnuUser
            // 
            mnuUser.BackColor=SystemColors.ActiveBorder;
            mnuUser.Font=new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            mnuUser.Name="mnuUser";
            mnuUser.Size=new Size(64, 29);
            mnuUser.Text="User";
            mnuUser.Click+=mnuUser_Click;
            // 
            // menuStrip5
            // 
            menuStrip5.BackColor=SystemColors.ActiveBorder;
            menuStrip5.Dock=DockStyle.None;
            menuStrip5.Font=new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip5.ImageScalingSize=new Size(20, 20);
            menuStrip5.Items.AddRange(new ToolStripItem[] { mnuSchedule });
            menuStrip5.Location=new Point(11, 292);
            menuStrip5.Name="menuStrip5";
            menuStrip5.Size=new Size(109, 33);
            menuStrip5.TabIndex=7;
            menuStrip5.Text="menuStrip5";
            // 
            // mnuSchedule
            // 
            mnuSchedule.BackColor=SystemColors.ActiveBorder;
            mnuSchedule.Name="mnuSchedule";
            mnuSchedule.Size=new Size(101, 29);
            mnuSchedule.Text="Schedule";
            mnuSchedule.Click+=mnuSchedule_Click;
            // 
            // Role
            // 
            Role.AutoSize=true;
            Role.BackColor=SystemColors.Control;
            Role.Font=new Font("Segoe UI Semibold", 12F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            Role.ForeColor=Color.Red;
            Role.Location=new Point(133, 27);
            Role.Name="Role";
            Role.Size=new Size(0, 28);
            Role.TabIndex=8;
            // 
            // panel1
            // 
            panel1.BackColor=SystemColors.ButtonShadow;
            panel1.Location=new Point(123, 81);
            panel1.Name="panel1";
            panel1.Size=new Size(10, 373);
            panel1.TabIndex=9;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize=new Size(20, 20);
            contextMenuStrip1.Name="contextMenuStrip1";
            contextMenuStrip1.Size=new Size(61, 4);
            // 
            // frmMain
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1001, 447);
            Controls.Add(panel1);
            Controls.Add(Role);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip3);
            Controls.Add(menuStrip4);
            Controls.Add(menuStrip5);
            MainMenuStrip=menuStrip1;
            Name="frmMain";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Menu";
            Load+=frmMain_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            menuStrip4.ResumeLayout(false);
            menuStrip4.PerformLayout();
            menuStrip5.ResumeLayout(false);
            menuStrip5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnExit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuAnimals;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem mnuFood;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem mnuCage;
        private MenuStrip menuStrip4;
        private ToolStripMenuItem mnuUser;
        private MenuStrip menuStrip5;
        private ToolStripMenuItem mnuSchedule;
        private Label Role;
        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
    }
}