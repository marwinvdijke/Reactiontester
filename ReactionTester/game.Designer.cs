namespace ReactionTester
{
    partial class game
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
            this.bstart = new System.Windows.Forms.Button();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.timeleftlabel = new System.Windows.Forms.Label();
            this.scorelabel = new System.Windows.Forms.Label();
            this.bstop = new System.Windows.Forms.Button();
            this.countdownlabel = new System.Windows.Forms.Label();
            this.countdown = new System.Windows.Forms.Timer(this.components);
            this.target = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.target)).BeginInit();
            this.SuspendLayout();
            // 
            // bstart
            // 
            this.bstart.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bstart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.bstart.Location = new System.Drawing.Point(392, 327);
            this.bstart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bstart.Name = "bstart";
            this.bstart.Size = new System.Drawing.Size(810, 167);
            this.bstart.TabIndex = 0;
            this.bstart.Text = "Start game";
            this.bstart.UseVisualStyleBackColor = false;
            this.bstart.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gametimer
            // 
            this.gametimer.Interval = 1000;
            this.gametimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeleftlabel
            // 
            this.timeleftlabel.AutoSize = true;
            this.timeleftlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.timeleftlabel.Location = new System.Drawing.Point(24, 819);
            this.timeleftlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.timeleftlabel.Name = "timeleftlabel";
            this.timeleftlabel.Size = new System.Drawing.Size(157, 31);
            this.timeleftlabel.TabIndex = 3;
            this.timeleftlabel.Text = "60 Seconds";
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.scorelabel.Location = new System.Drawing.Point(20, 17);
            this.scorelabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(170, 46);
            this.scorelabel.TabIndex = 5;
            this.scorelabel.Text = "Score: 0";
            this.scorelabel.Click += new System.EventHandler(this.scorelabel_Click);
            // 
            // bstop
            // 
            this.bstop.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bstop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bstop.Location = new System.Drawing.Point(1424, 806);
            this.bstop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bstop.Name = "bstop";
            this.bstop.Size = new System.Drawing.Size(152, 52);
            this.bstop.TabIndex = 6;
            this.bstop.Text = "Stop";
            this.bstop.UseVisualStyleBackColor = false;
            this.bstop.Click += new System.EventHandler(this.bstop_Click);
            // 
            // countdownlabel
            // 
            this.countdownlabel.AutoSize = true;
            this.countdownlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.countdownlabel.Location = new System.Drawing.Point(696, 348);
            this.countdownlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.countdownlabel.Name = "countdownlabel";
            this.countdownlabel.Size = new System.Drawing.Size(140, 153);
            this.countdownlabel.TabIndex = 7;
            this.countdownlabel.Text = "3";
            this.countdownlabel.Click += new System.EventHandler(this.countdownlabel_Click);
            // 
            // countdown
            // 
            this.countdown.Interval = 1500;
            this.countdown.Tick += new System.EventHandler(this.countdown_Tick_1);
            // 
            // target
            // 
            this.target.BackgroundImage = global::ReactionTester.Properties.Resources.iconfinder_Hunting1_23159941;
            this.target.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.target.Location = new System.Drawing.Point(316, 106);
            this.target.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(200, 192);
            this.target.TabIndex = 4;
            this.target.TabStop = false;
            this.target.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.countdownlabel);
            this.Controls.Add(this.bstop);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.target);
            this.Controls.Add(this.timeleftlabel);
            this.Controls.Add(this.bstart);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "game";
            this.Text = "game";
            this.Load += new System.EventHandler(this.game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.target)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bstart;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label timeleftlabel;
        private System.Windows.Forms.PictureBox target;
        public System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Button bstop;
        private System.Windows.Forms.Label countdownlabel;
        private System.Windows.Forms.Timer countdown;
    }
}