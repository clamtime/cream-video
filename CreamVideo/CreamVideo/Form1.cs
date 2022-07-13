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
        LoadManager loadManager = new LoadManager();

        public MainForm()
        {
            InitializeComponent();
            loadManager.LoadTheme(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\themes\\" + "default.crtheme");

            // bg color
            this.BackColor  = loadManager.themeColors[(int)LoadManager.ThemeColorType.BackgroundColor];
        
            // accent colors
            topBarPanel.BackColor = loadManager.themeColors[(int)LoadManager.ThemeColorType.AccentColor];
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
            
        }
    }
}
