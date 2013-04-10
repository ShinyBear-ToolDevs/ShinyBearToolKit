using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShinyBearToolkit.MenuEditor;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Drawing;
using ShinyBearToolKit.MenuEditor;

namespace ShinyBearToolkit.MenuEditor
{

    public class MenuEditorImage
    {
        //list with sprites.
        List<Image> image = new List<Image>();

        public void OpenImage()
        {

            Graphics graphics = new Graphics();

            OpenFileDialog i = new OpenFileDialog();
            i.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;) | *.png; *.jpg; *. jpeg; *.gif; *.bmp";

            if( i.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image.Add(Image.FromFile(i.FileName));

                for( int m = 0; m < image.Count; m++)
                {
                    graphics.DrawImage(image[m], new Point(100, 100));
               
                    //Check the file type
                    int dotIndex = i.FileName.LastIndexOf('.');
                    imageExtension = i.FileName.Substring(i.FileName.Length - dotIndex);

                }
            }
        }

        string imageExtension = "";
    }
}
