namespace ReactionTester
{
    partial class endscreen
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
            this.endscore = new System.Windows.Forms.Label();
            this.persecond = new System.Windows.Forms.Label();
            this.bmainmenu = new System.Windows.Forms.Button();
            this.bplayagain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // endscore
            // 
            this.endscore.AutoSize = true;
            this.endscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.endscore.Location = new System.Drawing.Point(202, 19);
            this.endscore.Name = "endscore";
            this.endscore.Size = new System.Drawing.Size(347, 76);
            this.endscore.TabIndex = 0;
            this.endscore.Text = "Score: null";
            // 
            // persecond
            // 
            this.persecond.AutoSize = true;
            this.persecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.persecond.Location = new System.Drawing.Point(284, 95);
            this.persecond.Name = "persecond";
            this.persecond.Size = new System.Drawing.Size(208, 25);
            this.persecond.TabIndex = 1;
            this.persecond.Text = "null targets per second";
            this.persecond.Click += new System.EventHandler(this.highscore_Click);
            // 
            // bmainmenu
            // 
            this.bmainmenu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bmainmenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bmainmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bmainmenu.Location = new System.Drawing.Point(289, 358);
            this.bmainmenu.Name = "bmainmenu";
            this.bmainmenu.Size = new System.Drawing.Size(214, 61);
            this.bmainmenu.TabIndex = 2;
            this.bmainmenu.Text = "Return to main menu";
            this.bmainmenu.UseVisualStyleBackColor = false;
            this.bmainmenu.Click += new System.EventHandler(this.bmainmenu_Click);
            // 
            // bplayagain
            // 
            this.bplayagain.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bplayagain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bplayagain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bplayagain.Location = new System.Drawing.Point(289, 291);
            this.bplayagain.Name = "bplayagain";
            this.bplayagain.Size = new System.Drawing.Size(214, 61);
            this.bplayagain.TabIndex = 3;
            this.bplayagain.Text = "Play again";
            this.bplayagain.UseVisualStyleBackColor = false;
            this.bplayagain.Click += new System.EventHandler(this.bplayagain_Click);
            // 
            // endscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 452);
            this.Controls.Add(this.bplayagain);
            this.Controls.Add(this.bmainmenu);
            this.Controls.Add(this.persecond);
            this.Controls.Add(this.endscore);
            this.Name = "endscreen";
            this.Text = "endscreen";
            this.Load += new System.EventHandler(this.endscreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label endscore;
        private System.Windows.Forms.Label persecond;
        private System.Windows.Forms.Button bmainmenu;
        private System.Windows.Forms.Button bplayagain;
    }
}