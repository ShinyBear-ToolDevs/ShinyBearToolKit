using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShinyBearToolkit.MenuEditor;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Drawing;

namespace ShinyBearToolkit.MenuEditor
{

    public class MenuEditorImage
    {
        Image image = null;



        public MenuEditorImage()
        {

        }

        public void OpenImage()
        {
            Graphics graphics = MainWindow.Graphics;

            OpenFileDialog i = new OpenFileDialog();
            i.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;) | *.png; *.jpg; *. jpeg; *.gif; *.bmp";

            if (i.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image = Image.FromFile(i.FileName);
                graphics.DrawImage(image, new Point(100, 100));
                //Check the file type
                int dotIndex = i.FileName.LastIndexOf('.');
                imageExtension = i.FileName.Substring(i.FileName.Length - dotIndex);
            }
        }

        string imageExtension = "";
    }
}
