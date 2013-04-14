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

    public class TextureListManager
    {
        //list with sprites.
        List<Image> image = new List<Image>();
        /// <summary>
        /// Gets or sets the images stored for the thumbnail list.
        /// </summary>
        public List<Image> Images
        {
            get { return this.image; }
            set { this.image = value; }
        }
        /// <summary>
        /// Gets the number of stored images stored for the thumbnail list.
        /// </summary>
        public int NrOfImages
        {
            get { return image.Count; }
        }
        public void OpenImage()
        {

            OpenFileDialog i = new OpenFileDialog();
            //Enables multiselect
            i.Multiselect = true;
            i.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png;) | *.png; *.jpg; *. jpeg; *.bmp";

            if (i.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Checks the number of images "i" contains
                for (int m = 0; m < i.FileNames.Length; m++)
                {
                    //Adds each file to the image list
                    this.image.Add(Image.FromFile(i.FileNames[m]));
                }

                //Check the file type
                int dotIndex = i.FileName.LastIndexOf('.');
                imageExtension = i.FileName.Substring(i.FileName.Length - dotIndex);

            }
        }

        
        /// <summary>
        /// Gets the image at the specified index
        /// </summary>
        /// <param name="index">specified index</param>
        /// <returns>The image at the index</returns>
        public Image getImageAtIndex(int index)
        {
            return image[index];
        }
        string imageExtension = "";


        public void AddImage(Image imageInput)
        {
            this.image.Add(imageInput);
        }


       
    }
}

