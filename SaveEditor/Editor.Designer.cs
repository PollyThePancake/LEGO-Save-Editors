
namespace SaveEditor
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.toolStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checksumBox = new System.Windows.Forms.TextBox();
            this.checksumButton = new System.Windows.Forms.Button();
            this.unlockCharsButton = new System.Windows.Forms.Button();
            this.checksumLabel = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(273, 24);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // checksumBox
            // 
            this.checksumBox.Location = new System.Drawing.Point(84, 27);
            this.checksumBox.Name = "checksumBox";
            this.checksumBox.Size = new System.Drawing.Size(81, 23);
            this.checksumBox.TabIndex = 1;
            // 
            // checksumButton
            // 
            this.checksumButton.Enabled = false;
            this.checksumButton.Location = new System.Drawing.Point(171, 27);
            this.checksumButton.Name = "checksumButton";
            this.checksumButton.Size = new System.Drawing.Size(75, 23);
            this.checksumButton.TabIndex = 3;
            this.checksumButton.Text = "Regenerate";
            this.checksumButton.UseVisualStyleBackColor = true;
            this.checksumButton.Click += new System.EventHandler(this.checksumButton_Click);
            // 
            // unlockCharsButton
            // 
            this.unlockCharsButton.Enabled = false;
            this.unlockCharsButton.Location = new System.Drawing.Point(12, 56);
            this.unlockCharsButton.Name = "unlockCharsButton";
            this.unlockCharsButton.Size = new System.Drawing.Size(130, 23);
            this.unlockCharsButton.TabIndex = 4;
            this.unlockCharsButton.Text = "Unlock all characters?";
            this.unlockCharsButton.UseVisualStyleBackColor = true;
            this.unlockCharsButton.Click += new System.EventHandler(this.unlockCharsButton_Click);
            // 
            // checksumLabel
            // 
            this.checksumLabel.AutoSize = true;
            this.checksumLabel.Location = new System.Drawing.Point(12, 31);
            this.checksumLabel.Name = "checksumLabel";
            this.checksumLabel.Size = new System.Drawing.Size(66, 15);
            this.checksumLabel.TabIndex = 5;
            this.checksumLabel.Text = "Checksum:";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(273, 94);
            this.Controls.Add(this.checksumLabel);
            this.Controls.Add(this.unlockCharsButton);
            this.Controls.Add(this.checksumButton);
            this.Controls.Add(this.checksumBox);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.toolStrip;
            this.Name = "Editor";
            this.Text = "LEGO Star Wars Save Editor";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TextBox checksumBox;
        private System.Windows.Forms.Button checksumButton;
        private System.Windows.Forms.Button unlockCharsButton;
        private System.Windows.Forms.Label checksumLabel;
    }
}

