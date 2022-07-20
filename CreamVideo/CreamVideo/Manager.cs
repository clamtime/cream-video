using System;
using System.Collections.Generic;
using System.Drawing;

namespace CreamVideo
{
    static class Manager
    {
        // PATHS
        public static string imageDirectoryPath = "M:\\Projects\\Programming\\CreamVideo\\img\\";
        public static string libraryDirectoryPath = "M:\\TV & Movies\\TV";

        // COLORS + FONTS
        public static Color backgroundColor = Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
        public static Color accentColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(161)))), ((int)(((byte)(66)))));
        public static Font seriesNameFont = new Font("Century Gothic", 13F);


        public static Image imageNotFoundImage = Image.FromFile(imageDirectoryPath+"CoverNotFound.png");
        public static VideoCollectionLibrary videoCollectionLibrary = new VideoCollectionLibrary();
        public static Size videoCollectionLibraryItemOffset = new Size(32, 32);
        public static Size videoCollectionLibraryItemSize = new Size(196, 286);
        public static Size videoCollecionLibraryItemCoverSize = new Size(196, 269);

        public static readonly string COVERART_FILE_NAME = "cover";
        public static List<string> acceptedImageFileTypes = new List<string> { ".png", ".jpg", ".jpeg" };

        public static int maxVideoCollectionLibraryItemsPerRow = 1;

        public static void CalculateMaxVideoCollectionLibraryItemsPerRow()
        {
            if (videoCollectionLibrary != null)
            {
                Size currSize = videoCollectionLibrary.videoCollectionLibraryPanel.Size;
                float xdiv = videoCollectionLibraryItemSize.Width + (videoCollectionLibraryItemOffset.Width); // vcli_offset * 2 because we want offset on both sides

                maxVideoCollectionLibraryItemsPerRow = (int)Math.Floor(currSize.Width / xdiv);
                Console.WriteLine(maxVideoCollectionLibraryItemsPerRow);
            }
        }
    }
}
