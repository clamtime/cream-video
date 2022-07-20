using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CreamVideo
{
    public partial class MainForm : Form
    {
        private LoadManager loadManager = new LoadManager();

        // window controls
        private bool dragging = false;
        private Point dragCursorPoint = Point.Empty;
        private Point dragFormPoint = Point.Empty;

        public MainForm()
        {
            InitializeComponent();
            Manager.videoCollectionLibrary.videoCollectionLibraryPanel = this.videoCollectionLibraryPanel;
            Manager.videoCollectionLibrary.Init();

            loadManager.LoadTheme(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\themes\\" + "default.crtheme");

            // bg color
            //this.BackColor  = loadManager.themeColors[(int)LoadManager.ThemeColorType.BackgroundColor];
        
            // accent colors
            titleBarPanel.BackColor = loadManager.themeColors[(int)LoadManager.ThemeColorType.AccentColor];
            logoPanel.BackColor = loadManager.themeColors[(int)LoadManager.ThemeColorType.AccentColor];

            // sidebar color
            sideBarPanel.BackColor = loadManager.themeColors[(int)LoadManager.ThemeColorType.SidebarColor];

            // button colors
            libraryMenuButton.FlatAppearance.MouseOverBackColor = loadManager.themeColors[(int)LoadManager.ThemeColorType.ButtonMouseOverColor];
            libraryMenuButton.FlatAppearance.MouseDownBackColor = loadManager.themeColors[(int)LoadManager.ThemeColorType.ButtonClickColor];

            settingsMenuButton.FlatAppearance.MouseOverBackColor = loadManager.themeColors[(int)LoadManager.ThemeColorType.ButtonMouseOverColor];
            settingsMenuButton.FlatAppearance.MouseDownBackColor = loadManager.themeColors[(int)LoadManager.ThemeColorType.ButtonClickColor];
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            expandButton.ImageList = ExpandShrinkImageList;
            expandButton.Image = expandButton.ImageList.Images[0];
        }

        private void MainForm_Resize(object sender, System.EventArgs e)
        {
            Manager.CalculateMaxVideoCollectionLibraryItemsPerRow();
            Manager.videoCollectionLibrary.AutoRearrangeVCLIs();
        }

        private void titleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void titleBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dist = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dist));
            }
        }

        private void titleBarPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            WindowController.exit();
        }

        private void expandButton_MouseDown(object sender, EventArgs e)
        {
            WindowController.maximize(this, expandButton);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowController.minimize(this);
        }

        private void sideBarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
