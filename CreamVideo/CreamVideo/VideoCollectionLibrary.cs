using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CreamVideo
{
    class VideoCollectionLibrary
    {
        public List<VideoCollectionLibraryItem> videoCollectionLibraryItemList = new List<VideoCollectionLibraryItem>();
        public Panel videoCollectionLibraryPanel;
        private VideoCollectionLibraryItem selected = null;

        public void Init()
        {
            if (videoCollectionLibraryPanel != null)
            {
                foreach (string dir in Directory.GetDirectories(Manager.libraryDirectoryPath))
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(dir);
                    VideoCollectionLibraryItem vcli = new VideoCollectionLibraryItem(dirInfo.Name, new System.Drawing.Point(47 + (videoCollectionLibraryItemList.Count * 212), 40));
                    vcli.Init();
                    videoCollectionLibraryItemList.Add(vcli);
                }
                
                foreach (VideoCollectionLibraryItem vcli in videoCollectionLibraryItemList)
                {
                    videoCollectionLibraryPanel.Controls.Add(vcli.collectionPanel);
                }
            }
        }

        public void AutoRearrangeVCLIs()
        {
            int amtInCurrRow = 0, rowNumber = 0;
            foreach (VideoCollectionLibraryItem vcli in videoCollectionLibraryItemList)
            {             
                vcli.SetLocation(new System.Drawing.Point(
                    amtInCurrRow * (Manager.videoCollectionLibraryItemOffset.Width  / 2  + Manager.videoCollectionLibraryItemSize.Width) + Manager.videoCollectionLibraryItemOffset.Width  / 2,
                    rowNumber    * (Manager.videoCollectionLibraryItemOffset.Height / 2 + Manager.videoCollectionLibraryItemSize.Height) + Manager.videoCollectionLibraryItemOffset.Height / 2
                    ));

                amtInCurrRow++;

                if (amtInCurrRow == Manager.maxVideoCollectionLibraryItemsPerRow)
                {
                    amtInCurrRow = 0;
                    rowNumber++;
                }
            }
        }

        public void Update()
        {
            foreach (VideoCollectionLibraryItem vcli in videoCollectionLibraryItemList)
            {
                vcli.collectionPanel.Click += new System.EventHandler(vcli.vcli_Click);
                vcli.coverPanel.Click += new System.EventHandler(vcli.vcli_Click);
                vcli.titleLabel.Click += new System.EventHandler(vcli.vcli_Click);
            }
        }

        public void SetSelected(VideoCollectionLibraryItem vcli)
        {
            if (selected != vcli)
                selected = vcli;
            vcli.collectionPanel.BackColor = Manager.accentColor;
            foreach (VideoCollectionLibraryItem vci in videoCollectionLibraryItemList)
            {
                if (vci != vcli) 
                    vci.collectionPanel.BackColor = Manager.backgroundColor;
            }
        }
    }
}
