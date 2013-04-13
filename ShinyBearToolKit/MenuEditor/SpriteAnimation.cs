using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShinyBearToolkit.MenuEditor;

namespace ShinyBearToolKit.MenuEditor
{
    public partial class SpriteAnimation : Form
    {
        TextureListManager textureListManager;
        public SpriteAnimation()
        {
            InitializeComponent();
            initLocalComponents();
        }
        private void initLocalComponents()
        {
            textureListManager = new TextureListManager();
        }
        private void addTextureButton_Click(object sender, EventArgs e)
        {
            textureListManager.OpenImage();
            LoadImages();
        }
        /// <summary>
        /// Loads the images from textureListManager's List, and imputs them into the listview
        /// </summary>
        public void LoadImages()
        {
            //Clears the list of old data
            loadedTextureList.Items.Clear();
            loadedImages.Images.Clear();

            for (int m = 0; m < textureListManager.NrOfImages; m++)
            {
                //Adds the image from the textureListManager at the specific index to the imageList
                loadedImages.Images.Add(textureListManager.getImageAtIndex(m));
                //Creates a temporary ListViewItem to hold the image index
                ListViewItem item = new ListViewItem();
                //Sets the image index
                item.ImageIndex = m;
                //Adds the image at the image index to the listview
                loadedTextureList.Items.Add(item);
            }
            //Updates
            loadedTextureList.Update();
        }
        private void loadedTextureList_DragDrop(object sender, DragEventArgs e)
        {
            //Funktioner för att kunna dragga in bilder utifrån
        }
        private void loadedTextureList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //När användaren markerar en bild i listan, ska denne visas upp i selectedTexturePanel
        }
        private void selectedTexturePanel_MouseDown(object sender, MouseEventArgs e)
        {
            //Här initieras markering, man ska kunna hålla ner musen och rita en rektangel för att markera en yta
            //Här initieras dragndrop, om en markering har gjorts.
            //Här initieras animering när användaren drar/markerar
        }
        private void TextureAtlasPanel_DragDrop(object sender, DragEventArgs e)
        {
            //Denna hämtar dragndrop från selectedTexturePanel
        }

        private void TextureAtlasPanel_DragEnter(object sender, DragEventArgs e)
        {
            //Här initieras animeringen när användaren draggar in en bild från selectedTexturePanel
        }

        private void TextureAtlasPanel_DragLeave(object sender, EventArgs e)
        {
            //Här avslutas animeringen, eftersom användaren inte draggar något i den
        }       
    }
}
