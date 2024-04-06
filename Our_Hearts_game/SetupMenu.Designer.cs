namespace Our_Hearts_game
{
    partial class SetupMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupMenu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reset1 = new System.Windows.Forms.Button();
            this.MaxScore = new System.Windows.Forms.NumericUpDown();
            this.NoOfPlayers = new System.Windows.Forms.NumericUpDown();
            this.start_game4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.card_back_theme = new System.Windows.Forms.PictureBox();
            this.theme_pic_box = new System.Windows.Forms.PictureBox();
            this.theme_default = new System.Windows.Forms.RadioButton();
            this.theme_1 = new System.Windows.Forms.RadioButton();
            this.theme_day = new System.Windows.Forms.RadioButton();
            this.theme_night = new System.Windows.Forms.RadioButton();
            this.welcome_msg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfPlayers)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card_back_theme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theme_pic_box)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.reset1);
            this.groupBox1.Controls.Add(this.MaxScore);
            this.groupBox1.Controls.Add(this.NoOfPlayers);
            this.groupBox1.Controls.Add(this.start_game4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.welcome_msg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 501);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "LUCK!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "OF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "BEST ";
            // 
            // reset1
            // 
            this.reset1.Location = new System.Drawing.Point(273, 441);
            this.reset1.Name = "reset1";
            this.reset1.Size = new System.Drawing.Size(156, 44);
            this.reset1.TabIndex = 7;
            this.reset1.Text = "Reset";
            this.reset1.UseVisualStyleBackColor = true;
            this.reset1.Click += new System.EventHandler(this.reset1_Click);
            // 
            // MaxScore
            // 
            this.MaxScore.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxScore.Location = new System.Drawing.Point(240, 157);
            this.MaxScore.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxScore.Name = "MaxScore";
            this.MaxScore.Size = new System.Drawing.Size(88, 22);
            this.MaxScore.TabIndex = 6;
            this.MaxScore.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // NoOfPlayers
            // 
            this.NoOfPlayers.Location = new System.Drawing.Point(240, 101);
            this.NoOfPlayers.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NoOfPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NoOfPlayers.Name = "NoOfPlayers";
            this.NoOfPlayers.Size = new System.Drawing.Size(88, 22);
            this.NoOfPlayers.TabIndex = 5;
            this.NoOfPlayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // start_game4
            // 
            this.start_game4.Location = new System.Drawing.Point(47, 441);
            this.start_game4.Name = "start_game4";
            this.start_game4.Size = new System.Drawing.Size(168, 44);
            this.start_game4.TabIndex = 4;
            this.start_game4.Text = "Start Game";
            this.start_game4.UseVisualStyleBackColor = true;
            this.start_game4.Click += new System.EventHandler(this.start_game4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.card_back_theme);
            this.groupBox2.Controls.Add(this.theme_pic_box);
            this.groupBox2.Controls.Add(this.theme_default);
            this.groupBox2.Controls.Add(this.theme_1);
            this.groupBox2.Controls.Add(this.theme_day);
            this.groupBox2.Controls.Add(this.theme_night);
            this.groupBox2.Location = new System.Drawing.Point(10, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 206);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Themes";
            // 
            // card_back_theme
            // 
            this.card_back_theme.InitialImage = ((System.Drawing.Image)(resources.GetObject("card_back_theme.InitialImage")));
            this.card_back_theme.Location = new System.Drawing.Point(490, 21);
            this.card_back_theme.Name = "card_back_theme";
            this.card_back_theme.Size = new System.Drawing.Size(123, 161);
            this.card_back_theme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card_back_theme.TabIndex = 5;
            this.card_back_theme.TabStop = false;
            // 
            // theme_pic_box
            // 
            this.theme_pic_box.InitialImage = ((System.Drawing.Image)(resources.GetObject("theme_pic_box.InitialImage")));
            this.theme_pic_box.Location = new System.Drawing.Point(338, 21);
            this.theme_pic_box.Name = "theme_pic_box";
            this.theme_pic_box.Size = new System.Drawing.Size(123, 161);
            this.theme_pic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.theme_pic_box.TabIndex = 4;
            this.theme_pic_box.TabStop = false;
            // 
            // theme_default
            // 
            this.theme_default.Appearance = System.Windows.Forms.Appearance.Button;
            this.theme_default.AutoSize = true;
            this.theme_default.Checked = true;
            this.theme_default.Location = new System.Drawing.Point(6, 45);
            this.theme_default.Name = "theme_default";
            this.theme_default.Size = new System.Drawing.Size(110, 26);
            this.theme_default.TabIndex = 3;
            this.theme_default.TabStop = true;
            this.theme_default.Text = " Default (White) ";
            this.theme_default.UseVisualStyleBackColor = true;
            this.theme_default.CheckedChanged += new System.EventHandler(this.theme_night_CheckedChanged);
            // 
            // theme_1
            // 
            this.theme_1.Appearance = System.Windows.Forms.Appearance.Button;
            this.theme_1.AutoSize = true;
            this.theme_1.Location = new System.Drawing.Point(174, 123);
            this.theme_1.Name = "theme_1";
            this.theme_1.Size = new System.Drawing.Size(118, 26);
            this.theme_1.TabIndex = 2;
            this.theme_1.Text = "Custom Theme 1";
            this.theme_1.UseVisualStyleBackColor = true;
            this.theme_1.CheckedChanged += new System.EventHandler(this.theme_night_CheckedChanged);
            // 
            // theme_day
            // 
            this.theme_day.Appearance = System.Windows.Forms.Appearance.Button;
            this.theme_day.AutoSize = true;
            this.theme_day.Location = new System.Drawing.Point(6, 123);
            this.theme_day.Name = "theme_day";
            this.theme_day.Size = new System.Drawing.Size(112, 26);
            this.theme_day.TabIndex = 1;
            this.theme_day.Text = "    Day Theme    ";
            this.theme_day.UseVisualStyleBackColor = true;
            this.theme_day.CheckedChanged += new System.EventHandler(this.theme_night_CheckedChanged);
            // 
            // theme_night
            // 
            this.theme_night.Appearance = System.Windows.Forms.Appearance.Button;
            this.theme_night.AutoSize = true;
            this.theme_night.Location = new System.Drawing.Point(174, 45);
            this.theme_night.Name = "theme_night";
            this.theme_night.Size = new System.Drawing.Size(118, 26);
            this.theme_night.TabIndex = 0;
            this.theme_night.Text = "    Night Theme    ";
            this.theme_night.UseVisualStyleBackColor = true;
            this.theme_night.CheckedChanged += new System.EventHandler(this.theme_night_CheckedChanged);
            // 
            // welcome_msg
            // 
            this.welcome_msg.AutoSize = true;
            this.welcome_msg.Location = new System.Drawing.Point(167, 29);
            this.welcome_msg.Name = "welcome_msg";
            this.welcome_msg.Size = new System.Drawing.Size(65, 16);
            this.welcome_msg.TabIndex = 2;
            this.welcome_msg.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max Score:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Human Players:";
            // 
            // SetupMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 568);
            this.Controls.Add(this.groupBox1);
            this.Name = "SetupMenu";
            this.Text = "SetupMenu";
            this.Load += new System.EventHandler(this.SetupMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfPlayers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card_back_theme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theme_pic_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label welcome_msg;
        private System.Windows.Forms.Button start_game4;
        private System.Windows.Forms.RadioButton theme_default;
        private System.Windows.Forms.RadioButton theme_1;
        private System.Windows.Forms.RadioButton theme_day;
        private System.Windows.Forms.RadioButton theme_night;
        private System.Windows.Forms.NumericUpDown NoOfPlayers;
        private System.Windows.Forms.NumericUpDown MaxScore;
        private System.Windows.Forms.Button reset1;
        private System.Windows.Forms.PictureBox theme_pic_box;
        private System.Windows.Forms.PictureBox card_back_theme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}