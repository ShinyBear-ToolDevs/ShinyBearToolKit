using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShinyBearToolkit.MenuEditor;
using System.IO;

namespace ShinyBearToolKit.MenuEditor
{
    public partial class FormCreateTextureAtlas : Form
    {
        TextureListManager textureListManager;

        //private Point defaultPosition = new Point(100, 100);

        // make it possible to change the texture in the pabel.
        private Graphics PanelGraphics { get; set; }

        private Point clickedPointOne;

        private Image currentDraggedImage;

        private const int FORM_PADDING = 5;

        public FormCreateTextureAtlas()
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

        private void loadedTextureList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //När användaren markerar en bild i listan, ska denne visas upp i selectedTexturePanel
            int selectedImageIndex = loadedTextureList.SelectedItems[0].ImageIndex;
            drawSelectedTexture(selectedImageIndex);

        }
        private void drawSelectedTexture(int index)
        {
            using (Graphics g = selectedTexturePanel.CreateGraphics())
            {
                selectedPictureBox.Image = textureListManager.getImageAtIndex(index);
                //g.Clear(Color.White);
                //g.DrawImageUnscaled(textureListManager.getImageAtIndex(index), 0, 0);
            }

        }

        private void selectedPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
               

            }
        }

        /// <summary>
        ///  Paint the bitmap on the panel if the currentDraggedImage contains a Image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextureAtlasPanel_Paint(object sender, PaintEventArgs e)
        {
            if (currentDraggedImage != null)
            {
                Bitmap bmp = new Bitmap(currentDraggedImage.Width, currentDraggedImage.Height);
                PanelGraphics = Graphics.FromImage(bmp);
                PanelGraphics.FillRectangle(new SolidBrush(TextureAtlasPanel.BackColor), new Rectangle(new Point(0, 0), currentDraggedImage.Size));

                PanelGraphics = Graphics.FromImage(bmp);
                PanelGraphics.DrawImage(bmp, clickedPointOne);
            }
        }

        private void TextureAtlasPanel_MouseDown(object sender, MouseEventArgs e)
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
            textureListManager.GenericDragEnter(sender, e);
        }

        private void TextureAtlasPanel_DragLeave(object sender, DragEventArgs e)
        {
            //Här avslutas animeringen, eftersom användaren inte draggar något i den
            textureListManager.DragDropLeave(sender, e);
        }

        private void loadedTextureList_DragEnter(object sender, DragEventArgs e)
        {
            textureListManager.GenericDragEnter(sender, e);
        }

        private void loadedTextureList_DragDrop(object sender, DragEventArgs e)
        {
            textureListManager.DragDropDesktop(sender, e);
            LoadImages();
        }

        //private void loadedTextureList_MouseDoubbleClick(object sender, MouseEventArgs e)
        //{
        //    ListViewItem tempItems = loadedTextureList.SelectedItems[0];
        //    Image tempImages = tempItems.ImageList.Images[0];

        //    Sprite newSprite = new Sprite(tempImages,
        //        defaultPosition.X,
        //        defaultPosition.Y,
        //        tempImages.Width,
        //        tempImages.Height,
        //        new Point(tempImages.Height / 2,
        //            tempImages.Width / 2),
        //            new Rectangle(new Point(defaultPosition.X,
        //                defaultPosition.Y),
        //                new Size(tempImages.Width,
        //                    tempImages.Height)));

        //    textureAtlasManager.addSprite(newSprite);
        //}

        private void loadedTextureList_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.DoDragDrop(e.Item, DragDropEffects.Copy);
                
            }
        }

        private void selectedPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void selectedPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            
        }

       

       

        
    }
}
