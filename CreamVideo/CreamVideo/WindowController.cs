using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CreamVideo
{
    static class WindowController
    {
        static bool maximized = false;
        static Point oldPos, defaultPos;
        static Size oldSize, defaultSize;

        public static void setInitial(Form form)
        {
            oldPos = defaultPos = form.Location;
            oldSize = defaultSize = form.Size;
        }

        public static void maximize(Form form, Button button)
        {
            if (!maximized)
            {
                oldPos = form.Location;
                oldSize = form.Size;
                maximized = true;
                int x = SystemInformation.WorkingArea.X;
                int y = SystemInformation.WorkingArea.Y;
                form.WindowState = FormWindowState.Maximized; form.Location = Point.Empty;
                form.Size = new Size(x, y);
            }
            else
            {
                form.WindowState = FormWindowState.Normal;
                form.Location = oldPos;
                form.Size = oldSize;
                maximized = false;
            }
            //button.Image = button.ImageList.Images[maximized ? 1 : 0];
        }

        public static void minimize(Form form)
        {
            if (form.WindowState == FormWindowState.Normal || form.WindowState == FormWindowState.Maximized)
                form.WindowState = FormWindowState.Minimized;
            else if (form.WindowState == FormWindowState.Minimized)
                form.WindowState = FormWindowState.Normal;

        }

        public static void exit()
        {
            Application.Exit();
        }
    }
}
