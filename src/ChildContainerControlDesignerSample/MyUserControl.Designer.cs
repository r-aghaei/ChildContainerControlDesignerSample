namespace ChildContainerControlDesignerSample
{
    partial class MyUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contentsPanel = new System.Windows.Forms.Panel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentsPanel
            // 
            this.contentsPanel.BackColor = System.Drawing.SystemColors.Window;
            this.contentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentsPanel.Location = new System.Drawing.Point(0, 30);
            this.contentsPanel.Name = "contentsPanel";
            this.contentsPanel.Size = new System.Drawing.Size(148, 118);
            this.contentsPanel.TabIndex = 0;
            // 
            // titlePanel
            // 
            this.titlePanel.AutoSize = true;
            this.titlePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(148, 30);
            this.titlePanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(5);
            this.titleLabel.Size = new System.Drawing.Size(48, 30);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.contentsPanel);
            this.Controls.Add(this.titlePanel);
            this.Name = "MyUserControl";
            this.Size = new System.Drawing.Size(148, 148);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel contentsPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
    }
}
