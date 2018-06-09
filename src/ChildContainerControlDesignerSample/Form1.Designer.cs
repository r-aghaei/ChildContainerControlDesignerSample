namespace ChildContainerControlDesignerSample
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
            this.myUserControl1 = new ChildContainerControlDesignerSample.MyUserControl();
            this.myUserControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myUserControl1
            // 
            this.myUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // myUserControl1.ContentsPanel
            // 
            this.myUserControl1.ContentsPanel.BackColor = System.Drawing.SystemColors.Window;
            this.myUserControl1.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myUserControl1.ContentsPanel.Enabled = true;
            this.myUserControl1.ContentsPanel.Location = new System.Drawing.Point(0, 30);
            this.myUserControl1.ContentsPanel.Name = "ContentsPanel";
            this.myUserControl1.ContentsPanel.Size = new System.Drawing.Size(146, 116);
            this.myUserControl1.ContentsPanel.TabIndex = 0;
            this.myUserControl1.ContentsPanel.Visible = true;
            this.myUserControl1.Location = new System.Drawing.Point(12, 12);
            this.myUserControl1.Name = "myUserControl1";
            this.myUserControl1.Size = new System.Drawing.Size(148, 148);
            this.myUserControl1.TabIndex = 0;
            this.myUserControl1.Title = "Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 184);
            this.Controls.Add(this.myUserControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.myUserControl1.ResumeLayout(false);
            this.myUserControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MyUserControl myUserControl1;
    }
}

