namespace ReactionTester
{
    partial class settings
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
            this.breturn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // breturn
            // 
            this.breturn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.breturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.breturn.Location = new System.Drawing.Point(12, 395);
            this.breturn.Name = "breturn";
            this.breturn.Size = new System.Drawing.Size(110, 43);
            this.breturn.TabIndex = 0;
            this.breturn.Text = "button1";
            this.breturn.UseVisualStyleBackColor = false;
            this.breturn.Click += new System.EventHandler(this.breturn_Click);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(190, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(54, 17);
            this.listBox1.TabIndex = 1;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.breturn);
            this.Name = "settings";
            this.Text = "settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button breturn;
        private System.Windows.Forms.ListBox listBox1;
    }
}