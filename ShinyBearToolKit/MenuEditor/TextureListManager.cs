using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShinyBearToolkit.MenuEditor;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using ShinyBearToolKit.MenuEditor;


namespace ShinyBearToolkit.MenuEditor
{

    public class TextureListManager
    {
        TextureListManager textureListManager = new TextureListManager();
        FormCreateTextureAtlas formCreateTextureAtlas = new FormCreateTextureAtlas();

        // DragDrop
        private bool draggingOverAtlas = false;
        private Image currentDraggedImage;

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

        
        public void GenericDragEnter(object sender, DragEventArgs e)
        {
            draggingOverAtlas = true;
            //if the data is a file or a bitmap
            if (e.Data.GetDataPresent(typeof(ListViewItem)) ||
                e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        public void DragDropDesktop(object sender, DragEventArgs e)
        {
            
        // which fil formats that are allowed to be used
        string[] ALLOWED_IMAGE_EXTENSIONS = { ".jpg", ".jpeg", ".png", ".bmp" };

            string[] handles = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string s in handles)
            {
                if (File.Exists(s))
                {

                    foreach (string q in ALLOWED_IMAGE_EXTENSIONS)
                    {
                        if (string.Compare(Path.GetExtension(s), q, true) == 0)
                        {

                            AddFileToListView(s);
                        }
                        else
                        {
                            MessageBox.Show("Wrong file format (png, jpg, jpeg, bmp)");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("File not found");
                }
               
            }
        }

        private void AddFileToListView(string fullFilePath)
        {
            Image image = Image.FromFile(fullFilePath);
            textureListManager.AddImage(image);

           
            formCreateTextureAtlas.LoadImages();
        }
    }
}

//kunna lägga upp mappar i listviewn och då ska alla bilderna visas. (directory)
// rensa upp i syntaxen.
 

