namespace Our_Hearts_game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameInstructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.warnings = new System.Windows.Forms.Label();
            this.logbtn = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.guest_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.registerbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.animation = new System.Windows.Forms.PictureBox();
            this.amsg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animation)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.instructionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameInstructionsToolStripMenuItem});
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            // 
            // gameInstructionsToolStripMenuItem
            // 
            this.gameInstructionsToolStripMenuItem.Name = "gameInstructionsToolStripMenuItem";
            this.gameInstructionsToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.gameInstructionsToolStripMenuItem.Text = "Game Instructions";
            this.gameInstructionsToolStripMenuItem.Click += new System.EventHandler(this.gameInstructionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheAuthorsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutTheAuthorsToolStripMenuItem
            // 
            this.aboutTheAuthorsToolStripMenuItem.Name = "aboutTheAuthorsToolStripMenuItem";
            this.aboutTheAuthorsToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.aboutTheAuthorsToolStripMenuItem.Text = "About the Authors";
            this.aboutTheAuthorsToolStripMenuItem.Click += new System.EventHandler(this.aboutTheAuthorsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "SIGN IN OR PLAY AS A GUEST";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(167, 177);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(57, 16);
            this.l.TabIndex = 2;
            this.l.Text = "Login Id:";
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Location = new System.Drawing.Point(170, 226);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(70, 16);
            this.p.TabIndex = 3;
            this.p.Text = "Password:";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(238, 177);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(242, 22);
            this.login.TabIndex = 4;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(238, 219);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(242, 22);
            this.password.TabIndex = 5;
            // 
            // warnings
            // 
            this.warnings.AutoSize = true;
            this.warnings.Location = new System.Drawing.Point(276, 132);
            this.warnings.Name = "warnings";
            this.warnings.Size = new System.Drawing.Size(0, 16);
            this.warnings.TabIndex = 6;
            // 
            // logbtn
            // 
            this.logbtn.Location = new System.Drawing.Point(185, 288);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(131, 40);
            this.logbtn.TabIndex = 7;
            this.logbtn.Text = "Login";
            this.logbtn.UseVisualStyleBackColor = true;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(349, 288);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(131, 40);
            this.reset.TabIndex = 8;
            this.reset.Text = "Clear";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // guest_btn
            // 
            this.guest_btn.Location = new System.Drawing.Point(173, 402);
            this.guest_btn.Name = "guest_btn";
            this.guest_btn.Size = new System.Drawing.Size(127, 47);
            this.guest_btn.TabIndex = 9;
            this.guest_btn.Text = "Play As Guest";
            this.guest_btn.UseVisualStyleBackColor = true;
            this.guest_btn.Click += new System.EventHandler(this.guest_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Does not have an account? Play as a Guest";
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(349, 402);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(131, 47);
            this.registerbtn.TabIndex = 11;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Or";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Register";
            // 
            // animation
            // 
            this.animation.InitialImage = ((System.Drawing.Image)(resources.GetObject("animation.InitialImage")));
            this.animation.Location = new System.Drawing.Point(0, 0);
            this.animation.Name = "animation";
            this.animation.Size = new System.Drawing.Size(800, 460);
            this.animation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.animation.TabIndex = 14;
            this.animation.TabStop = false;
            // 
            // amsg
            // 
            this.amsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amsg.AutoSize = true;
            this.amsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(190)))), ((int)(((byte)(135)))));
            this.amsg.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amsg.ForeColor = System.Drawing.Color.White;
            this.amsg.Location = new System.Drawing.Point(12, 425);
            this.amsg.Name = "amsg";
            this.amsg.Size = new System.Drawing.Size(312, 24);
            this.amsg.TabIndex = 15;
            this.amsg.Text = "Please Wait Until the Game Loads...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 8000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(190)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.amsg);
            this.Controls.Add(this.animation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guest_btn);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.logbtn);
            this.Controls.Add(this.warnings);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.p);
            this.Controls.Add(this.l);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hearts Card Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label warnings;
        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button guest_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem gameInstructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheAuthorsToolStripMenuItem;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox animation;
        private System.Windows.Forms.Label amsg;
        private System.Windows.Forms.Timer timer1;
    }
}

