using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ShinyBearToolKit.MenuEditor;
using System.Runtime.Serialization;


namespace ShinyBearToolkit.MenuEditor
{

    public class TextureListManager
    {
        // uses to checks witch formats that is ok
        private readonly string[] ALLOWED_IMAGE_EXTENSIONS = { ".jpg", ".jpeg", ".png", ".bmp" };

        // DragDrop
        private bool draggingOverAtlas = false;
      

       

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

        /// <summary>
        /// Open files and validate the format through the openFileDialog class. This method is used by "Add buttons".
        /// </summary>
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

        /// <summary>
        /// Adds an image object to the list<Image>image
        /// </summary>
        /// <param name="imageInput"></param>
        public void AddImage(Image imageInput)
        {
            this.image.Add(imageInput);
        }

        /// <summary>
        /// Enter the drag and drop function and copy the object. Validate if the object is a file or a bitmap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        ///  Leave the DragDrop events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DragDropLeave(object sender, DragEventArgs e)
        {
            draggingOverAtlas = false;
        }

        public void DragDropPicturePices(object sender, DragEventArgs e)
        {
           
        }

        /// <summary>
        ///  Check to se if a object has been chosen. If ok add image to panel via AddFile and AddImage.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DragDropRectangle(object sender, DragEventArgs e)
        {
            string[] handles = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (handles != null)
            {
                foreach (string s in handles)
                {
                    AddFile(s);
                }
            }
        }

        /// <summary>
        ///  Check to se if the choosen object exist and uses the method IsFileCorrectType to verify that the format is ok.
        ///  If ok add image to listView via  AddFile and AddImage.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DragDropDesktop(object sender, DragEventArgs e)
        {
            string[] handles = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (handles != null)
            {
                foreach (string s in handles)
                {

                    if (File.Exists(s))
                    {

                        if (IsFileCorrectType(s, ALLOWED_IMAGE_EXTENSIONS))
                        {
                            AddFile(s);
                        }
                        else
                        {
                            MessageBox.Show("The system only support the formats .jpg .jpeg .png .bmp");
                        }

                    }
                    else
                    {
                        MessageBox.Show("File not found");
                    }
                }
            }
        }

        /// <summary>
        /// Determines if the files in the folder has one of the accepted extensions
        /// </summary>
        /// <param name="dirPath"></param>
        /// <param name="validExtension"></param>
        /// <returns></returns>
        //private bool IsFilesInDirectoryCorrectType(string dirPath, string[] validExtension)
        //{
        //    var hej = Directory.EnumerateFiles(dirPath).Select(p => Path.GetFileName(p));

        //    var folders = hej.Where(file => Path.GetExtension(file) == ".jpg").Select(
        //        file => Path.GetFileNameWithoutExtension(file));
        //}

        /// <summary>
        /// Determines if the file has one of the accepted extensions.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="validExtensions"></param>
        /// <returns></returns>
        private bool IsFileCorrectType(string filePath, string[] validExtensions)
        {
            bool isCorrect = false;
            foreach (string extension in validExtensions)
            {
                if (string.Compare(Path.GetExtension(filePath), extension, true) == 0)
                {
                    isCorrect = true;
                    break;
                }
            }

            return isCorrect;
        }

        /// <summary>
        /// Adds the files to the list<Image>image in TextureListManager
        /// </summary>
        /// <param name="fullFilePath"></param>
        private void AddFile(string fullFilePath)
        {
            Image picture = Image.FromFile(fullFilePath);
            AddImage(picture);
        }

    }
}





