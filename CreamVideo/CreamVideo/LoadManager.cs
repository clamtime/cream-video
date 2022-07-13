using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace CreamVideo
{
    class LoadManager
    {
        public enum ThemeColorType
        {
            FontColor, 
            AccentColor, 
            BackgroundColor, 
            SidebarColor, 
            ButtonMouseOverColor, 
            ButtonClickColor
        }

        public Color[] themeColors = new Color[6];

        public void LoadTheme(string themeFilePathAndName)
        {
            int counter = 0;
            try
            {
                if (!File.Exists(themeFilePathAndName))
                    throw new FileNotFoundException();
                else
                {
                    foreach (string line in System.IO.File.ReadLines(themeFilePathAndName))
                    {
                        if (line.Length > 0 && line[0] != '#') // comment char
                        {
                            string hex = line.Split('=')[1]; // sep char, hex code comes after equals sign
                            hex = hex.Insert(0, "#"); // ColorTranslator needs hex codes in html format
                            Color c = HexToColor(hex);

                            // ensure valid color & limit color quantity to what theme accepts
                            if (c != null && counter < Enum.GetNames(typeof(ThemeColorType)).Length)
                            {
                                themeColors[counter] = c;
                                counter++;
                            }
                            else
                            {
                                // TODO: throw invalid color error
                            }
                        }
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                // TODO: handle file not found error
                Console.WriteLine("File {0} not found!", themeFilePathAndName);
            }
        }

        public Color HexToColor(string hex)
        {
            return ColorTranslator.FromHtml(hex);
        }
    }
}
