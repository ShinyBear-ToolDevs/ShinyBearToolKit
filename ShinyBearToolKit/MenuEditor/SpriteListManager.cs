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

        public void OpenImage(Image image)
        {

            OpenFileDialog i = new OpenFileDialog();
            i.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;) | *.png; *.jpg; *. jpeg; *.gif; *.bmp";

            if( i.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                this.image.Add(Image.FromFile(i.FileName));

                    //Check the file type
                    int dotIndex = i.FileName.LastIndexOf('.');
                    imageExtension = i.FileName.Substring(i.FileName.Length - dotIndex);

                
            }
        }

        string imageExtension = "";
    }
}
