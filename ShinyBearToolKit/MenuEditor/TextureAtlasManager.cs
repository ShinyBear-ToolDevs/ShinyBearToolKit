using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using ShinyBearToolkit.MenuEditor;

namespace ShinyBearToolKit.MenuEditor
{
    class TextureAtlasManager
    {
        FormCreateTextureAtlas formCreateTextureAtlas = new FormCreateTextureAtlas();
        TextureListManager textureListManager = new TextureListManager();


        // which fil formats that are allowed to be used
        private string[] ALLOWED_IMAGE_EXTENSIONS = { ".jpg", ".jpeg", ".png", ".bmp" };

        // DragDrop
        private bool draggingOverAtlas = false;
        private Image currentDraggedImage;

        private List<Sprite> sprites;

        public List<Sprite> Sprites { get { return this.sprites; } set { this.sprites = value; } }
        public int NrOfSprites { get { return sprites.Count; } }
        public TextureAtlasManager()
        {
            sprites = new List<Sprite>();
        }
        public void addSprite(Sprite input)
        {
            sprites.Add(input);
        }
        public void removeSprite(int index)
        {
            sprites.RemoveAt(index);
        }
        public Sprite getSpriteAtIndex(int index)
        {
            return sprites[index];
        }
        /// <summary>
        /// Checks collision with the mouse on any of the sprites on the panel, and returns the index of the image, else -1
        /// </summary>
        /// <param name="mouseCoordinates">Current mouse coordinates</param>
        /// <returns>index of the image clicked on, else -1</returns>
        public int checkCollision(Point mouseCoordinates)
        {
            int output = -1;
            for (int i = 0; i < NrOfSprites; i++)
            {
                if (sprites[i].PictureEdge.Contains(mouseCoordinates))
                {
                    output = i;
                    break;
                }
            }
            return output;
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
// ändra storlek på ikonerna
// rensa upp i syntaxen.
