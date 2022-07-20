
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingsMenuButton = new System.Windows.Forms.Button();
            this.libraryMenuButton = new System.Windows.Forms.Button();
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.expandButton = new System.Windows.Forms.Button();
            this.ExpandShrinkImageList = new System.Windows.Forms.ImageList(this.components);
            this.closeButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.videoCollectionLibraryPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.sideBarPanel.SuspendLayout();
            this.titleBarPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.sideBarPanel.Controls.Add(this.label2);
            this.sideBarPanel.Controls.Add(this.panel1);
            this.sideBarPanel.Controls.Add(this.settingsMenuButton);
            this.sideBarPanel.Controls.Add(this.libraryMenuButton);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(285, 887);
            this.sideBarPanel.TabIndex = 0;
            this.sideBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sideBarPanel_Paint);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(161)))), ((int)(((byte)(66)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(284, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 887);
            this.label2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(161)))), ((int)(((byte)(66)))));
            this.panel1.Location = new System.Drawing.Point(1, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 100);
            this.panel1.TabIndex = 2;
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
            this.settingsMenuButton.Location = new System.Drawing.Point(12, 453);
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
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(161)))), ((int)(((byte)(66)))));
            this.titleBarPanel.Controls.Add(this.minimizeButton);
            this.titleBarPanel.Controls.Add(this.expandButton);
            this.titleBarPanel.Controls.Add(this.closeButton);
            this.titleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarPanel.Location = new System.Drawing.Point(285, 0);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(1214, 22);
            this.titleBarPanel.TabIndex = 0;
            this.titleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBarPanel_MouseDown);
            this.titleBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBarPanel_MouseMove);
            this.titleBarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleBarPanel_MouseUp);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(161)))), ((int)(((byte)(66)))));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(161)))), ((int)(((byte)(66)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.minimizeButton.Location = new System.Drawing.Point(1095, -13);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(40, 38);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // expandButton
            // 
            this.expandButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(161)))), ((int)(((byte)(66)))));
            this.expandButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.expandButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(161)))), ((int)(((byte)(66)))));
            this.expandButton.FlatAppearance.BorderSize = 0;
            this.expandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expandButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.expandButton.ImageList = this.ExpandShrinkImageList;
            this.expandButton.Location = new System.Drawing.Point(1135, -13);
            this.expandButton.Name = "expandButton";
            this.expandButton.Size = new System.Drawing.Size(40, 38);
            this.expandButton.TabIndex = 1;
            this.expandButton.TabStop = false;
            this.expandButton.UseVisualStyleBackColor = false;
            this.expandButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.expandButton_MouseDown);
            // 
            // ExpandShrinkImageList
            // 
            this.ExpandShrinkImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ExpandShrinkImageList.ImageStream")));
            this.ExpandShrinkImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ExpandShrinkImageList.Images.SetKeyName(0, "expand.png");
            this.ExpandShrinkImageList.Images.SetKeyName(1, "shrink.png");
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(161)))), ((int)(((byte)(66)))));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(161)))), ((int)(((byte)(66)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(102)))), ((int)(((byte)(121)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.closeButton.Location = new System.Drawing.Point(1175, -13);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 38);
            this.closeButton.TabIndex = 0;
            this.closeButton.TabStop = false;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
            // videoCollectionLibraryPanel
            // 
            this.videoCollectionLibraryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoCollectionLibraryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.videoCollectionLibraryPanel.Location = new System.Drawing.Point(302, 217);
            this.videoCollectionLibraryPanel.Name = "videoCollectionLibraryPanel";
            this.videoCollectionLibraryPanel.Size = new System.Drawing.Size(1185, 658);
            this.videoCollectionLibraryPanel.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(1288, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 286);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Death Note (Fake)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(196, 269);
            this.panel5.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1499, 887);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.videoCollectionLibraryPanel);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.titleBarPanel);
            this.Controls.Add(this.sideBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.sideBarPanel.ResumeLayout(false);
            this.titleBarPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Panel titleBarPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button libraryMenuButton;
        private System.Windows.Forms.Button settingsMenuButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button expandButton;
        public System.Windows.Forms.ImageList ExpandShrinkImageList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel videoCollectionLibraryPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
    }
}

