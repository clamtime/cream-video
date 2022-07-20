using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CreamVideo
{
    class VideoCollectionLibraryItem
    {
        public Panel collectionPanel, coverPanel;
        public Label titleLabel;

        private string folderName;
        private Point location;

        public List<VideoItem> videoItemList = new List<VideoItem>();

        public VideoCollectionLibraryItem(string name, Point pos)
        {
            folderName = name;
            location = pos;
        }

        public void Init()
        {
            collectionPanel = new Panel();
            coverPanel = new Panel();
            titleLabel = new Label();


            // add controls to panel apply docking

            collectionPanel.Controls.Add(coverPanel);
            collectionPanel.Controls.Add(titleLabel);

            titleLabel.Dock = DockStyle.Bottom;
            coverPanel.Dock = DockStyle.Top;

            // set up controls

            collectionPanel.Location = location;
            collectionPanel.Size = Manager.videoCollectionLibraryItemSize;
            collectionPanel.Padding = new Padding(8);
            collectionPanel.BackColor = Manager.backgroundColor;
            collectionPanel.BorderStyle = BorderStyle.None;
            coverPanel.BorderStyle = BorderStyle.None;
            coverPanel.Size = Manager.videoCollecionLibraryItemCoverSize;
            coverPanel.Location = Point.Empty;
            titleLabel.Margin = coverPanel.Margin = collectionPanel.Margin;
            titleLabel.FlatStyle = FlatStyle.Flat;
            titleLabel.BringToFront();

            string coverArtFilePath = System.IO.Directory.GetCurrentDirectory();
            foreach (string fileType in Manager.acceptedImageFileTypes)
            {
                string tmpPath = Manager.libraryDirectoryPath + "\\" + folderName + "\\" + Manager.COVERART_FILE_NAME + fileType;
                if (System.IO.File.Exists(tmpPath))
                {
                    coverArtFilePath = tmpPath;
                    break;
                }
            }
            try {
                coverPanel.BackgroundImage = Image.FromFile(coverArtFilePath);
            } catch (System.IO.FileNotFoundException) {
                coverPanel.BackgroundImage = Manager.imageNotFoundImage;
            }

            coverPanel.BackgroundImageLayout = ImageLayout.Zoom;
            titleLabel.Font = Manager.seriesNameFont;
            titleLabel.Text = folderName;
            titleLabel.Font = Manager.seriesNameFont;
            titleLabel.ForeColor = Color.White;
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            }
    
        public void SetLocation(Point pos)
        {
            collectionPanel.Location = location = pos;
        }

        public void vcli_Click(object sender, EventArgs e)
        {
            Manager.videoCollectionLibrary.SetSelected(this);
        }
    }
}
