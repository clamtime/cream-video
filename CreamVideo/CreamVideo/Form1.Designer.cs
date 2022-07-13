
namespace CreamVideo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.settingsMenuButton = new System.Windows.Forms.Button();
            this.libraryMenuButton = new System.Windows.Forms.Button();
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.sideBarPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.sideBarPanel.Controls.Add(this.settingsMenuButton);
            this.sideBarPanel.Controls.Add(this.libraryMenuButton);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(285, 887);
            this.sideBarPanel.TabIndex = 0;
            // 
            // settingsMenuButton
            // 
            this.settingsMenuButton.FlatAppearance.BorderSize = 0;
            this.settingsMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.settingsMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.settingsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsMenuButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.settingsMenuButton.ForeColor = System.Drawing.Color.White;
            this.settingsMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsMenuButton.Image")));
            this.settingsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsMenuButton.Location = new System.Drawing.Point(12, 449);
            this.settingsMenuButton.Name = "settingsMenuButton";
            this.settingsMenuButton.Size = new System.Drawing.Size(273, 269);
            this.settingsMenuButton.TabIndex = 3;
            this.settingsMenuButton.Text = "Settings";
            this.settingsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsMenuButton.UseVisualStyleBackColor = true;
            // 
            // libraryMenuButton
            // 
            this.libraryMenuButton.FlatAppearance.BorderSize = 0;
            this.libraryMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.libraryMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.libraryMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.libraryMenuButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.libraryMenuButton.ForeColor = System.Drawing.Color.White;
            this.libraryMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("libraryMenuButton.Image")));
            this.libraryMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.libraryMenuButton.Location = new System.Drawing.Point(12, 173);
            this.libraryMenuButton.Name = "libraryMenuButton";
            this.libraryMenuButton.Size = new System.Drawing.Size(273, 269);
            this.libraryMenuButton.TabIndex = 2;
            this.libraryMenuButton.Text = "Library";
            this.libraryMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.libraryMenuButton.UseVisualStyleBackColor = true;
            // 
            // topBarPanel
            // 
            this.topBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(161)))), ((int)(((byte)(66)))));
            this.topBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarPanel.Location = new System.Drawing.Point(285, 0);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(1214, 22);
            this.topBarPanel.TabIndex = 0;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(161)))), ((int)(((byte)(66)))));
            this.logoPanel.Controls.Add(this.logoLabel);
            this.logoPanel.Controls.Add(this.logoPictureBox);
            this.logoPanel.Location = new System.Drawing.Point(394, 1);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(173, 199);
            this.logoPanel.TabIndex = 1;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.White;
            this.logoLabel.Location = new System.Drawing.Point(22, 158);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(129, 23);
            this.logoLabel.TabIndex = 3;
            this.logoLabel.Text = "CreamVideo";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(22, 27);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(128, 128);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 2;
            this.logoPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1499, 887);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.topBarPanel);
            this.Controls.Add(this.sideBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sideBarPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Panel topBarPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button libraryMenuButton;
        private System.Windows.Forms.Button settingsMenuButton;
    }
}

