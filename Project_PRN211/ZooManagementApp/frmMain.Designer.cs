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
            contextMenuStrip1=new ContextMenuStrip(components);
            panel=new Panel();
            panel2=new Panel();
            panel3=new Panel();
            btnLogOut=new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            menuStrip3.SuspendLayout();
            menuStrip4.SuspendLayout();
            menuStrip5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor=SystemColors.Control;
            pictureBox1.Image=Properties.Resources.logone;
            pictureBox1.Location=new Point(4, 0);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(124, 110);
            pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=SystemColors.Control;
            label1.Font=new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(607, 5);
            label1.Name="label1";
            label1.Size=new Size(107, 27);
            label1.TabIndex=1;
            label1.Text="Welcome ";
            label1.TextAlign=ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            btnExit.BackColor=SystemColors.Control;
            btnExit.Font=new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location=new Point(18, 674);
            btnExit.Name="btnExit";
            btnExit.Size=new Size(94, 41);
            btnExit.TabIndex=2;
            btnExit.Text="Log Out";
            btnExit.UseVisualStyleBackColor=false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor=SystemColors.Control;
            menuStrip1.Dock=DockStyle.None;
            menuStrip1.Font=new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize=new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuAnimals });
            menuStrip1.Location=new Point(18, 216);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new Size(100, 33);
            menuStrip1.TabIndex=3;
            menuStrip1.Text="menuStrip1";
            // 
            // mnuAnimals
            // 
            mnuAnimals.BackColor=SystemColors.Control;
            mnuAnimals.Name="mnuAnimals";
            mnuAnimals.Size=new Size(92, 29);
            mnuAnimals.Text="Animals";
            mnuAnimals.Click+=mnuAnimals_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor=SystemColors.Control;
            menuStrip2.Dock=DockStyle.None;
            menuStrip2.ImageScalingSize=new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { mnuFood });
            menuStrip2.Location=new Point(18, 303);
            menuStrip2.Name="menuStrip2";
            menuStrip2.Size=new Size(76, 33);
            menuStrip2.TabIndex=4;
            menuStrip2.Text="menuStrip2";
            // 
            // mnuFood
            // 
            mnuFood.BackColor=SystemColors.Control;
            mnuFood.Font=new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            mnuFood.Name="mnuFood";
            mnuFood.Size=new Size(68, 29);
            mnuFood.Text="Food";
            mnuFood.Click+=mnuFood_Click;
            // 
            // menuStrip3
            // 
            menuStrip3.BackColor=SystemColors.Control;
            menuStrip3.Dock=DockStyle.None;
            menuStrip3.ImageScalingSize=new Size(20, 20);
            menuStrip3.Items.AddRange(new ToolStripItem[] { mnuCage });
            menuStrip3.Location=new Point(18, 395);
            menuStrip3.Name="menuStrip3";
            menuStrip3.Size=new Size(75, 33);
            menuStrip3.TabIndex=5;
            menuStrip3.Text="menuStrip3";
            // 
            // mnuCage
            // 
            mnuCage.BackColor=SystemColors.Control;
            mnuCage.Font=new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            mnuCage.Name="mnuCage";
            mnuCage.Size=new Size(67, 29);
            mnuCage.Text="Cage";
            mnuCage.Click+=mnuCage_Click;
            // 
            // menuStrip4
            // 
            menuStrip4.BackColor=SystemColors.Control;
            menuStrip4.Dock=DockStyle.None;
            menuStrip4.ImageScalingSize=new Size(20, 20);
            menuStrip4.Items.AddRange(new ToolStripItem[] { mnuUser });
            menuStrip4.Location=new Point(18, 132);
            menuStrip4.Name="menuStrip4";
            menuStrip4.Size=new Size(72, 33);
            menuStrip4.TabIndex=6;
            menuStrip4.Text="menuStrip4";
            // 
            // mnuUser
            // 
            mnuUser.BackColor=SystemColors.Control;
            mnuUser.Font=new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            mnuUser.Name="mnuUser";
            mnuUser.Size=new Size(64, 29);
            mnuUser.Text="User";
            mnuUser.Click+=mnuUser_Click;
            // 
            // menuStrip5
            // 
            menuStrip5.BackColor=SystemColors.Control;
            menuStrip5.Dock=DockStyle.None;
            menuStrip5.Font=new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip5.ImageScalingSize=new Size(20, 20);
            menuStrip5.Items.AddRange(new ToolStripItem[] { mnuSchedule });
            menuStrip5.Location=new Point(18, 482);
            menuStrip5.Name="menuStrip5";
            menuStrip5.Size=new Size(109, 33);
            menuStrip5.TabIndex=7;
            menuStrip5.Text="menuStrip5";
            // 
            // mnuSchedule
            // 
            mnuSchedule.BackColor=SystemColors.Control;
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
            Role.Location=new Point(714, 4);
            Role.Name="Role";
            Role.Size=new Size(0, 28);
            Role.TabIndex=8;
            Role.TextAlign=ContentAlignment.TopCenter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize=new Size(20, 20);
            contextMenuStrip1.Name="contextMenuStrip1";
            contextMenuStrip1.Size=new Size(61, 4);
            // 
            // panel
            // 
            panel.BackColor=Color.White;
            panel.BorderStyle=BorderStyle.FixedSingle;
            panel.Enabled=false;
            panel.Location=new Point(134, 35);
            panel.MaximumSize=new Size(1214, 636);
            panel.Name="panel";
            panel.Size=new Size(1214, 636);
            panel.TabIndex=11;
            panel.TabStop=true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Role);
            panel2.Dock=DockStyle.Top;
            panel2.Location=new Point(0, 0);
            panel2.Name="panel2";
            panel2.Size=new Size(1350, 35);
            panel2.TabIndex=0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLogOut);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(menuStrip5);
            panel3.Controls.Add(menuStrip2);
            panel3.Controls.Add(menuStrip3);
            panel3.Controls.Add(menuStrip4);
            panel3.Controls.Add(menuStrip1);
            panel3.Controls.Add(btnExit);
            panel3.Dock=DockStyle.Left;
            panel3.Location=new Point(0, 35);
            panel3.Name="panel3";
            panel3.Size=new Size(137, 638);
            panel3.TabIndex=0;
            // 
            // btnLogOut
            // 
            btnLogOut.Font=new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.Location=new Point(12, 597);
            btnLogOut.Name="btnLogOut";
            btnLogOut.Size=new Size(115, 29);
            btnLogOut.TabIndex=0;
            btnLogOut.Text="Log Out";
            btnLogOut.UseVisualStyleBackColor=true;
            btnLogOut.Click+=btnLogOut_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1350, 673);
            Controls.Add(panel3);
            Controls.Add(panel);
            Controls.Add(panel2);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            IsMdiContainer=true;
            MainMenuStrip=menuStrip1;
            MaximumSize=new Size(1368, 720);
            Name="frmMain";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Menu";
            TransparencyKey=Color.White;
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
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
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel;
        private Panel panel2;
        private Panel panel3;
        private Button btnLogOut;
    }
}