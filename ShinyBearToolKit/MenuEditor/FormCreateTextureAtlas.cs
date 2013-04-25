using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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

        // make it possible to change the texture in the panel.
        private Graphics PanelGraphics;

        private bool dragRec = false;
        private bool mouseDrawRec = false;
        int recPositionX;
        int recPositionY;

        
        private Bitmap currentDraggedImage;
        private Bitmap currentSelectedImage;
        private Bitmap cutImage;
        private Rectangle cutRectangle;
        private const int FORM_PADDING = 5;

        public FormCreateTextureAtlas()
        {
            InitializeComponent();
            initLocalComponents();
        }
        private void initLocalComponents()
        {
            //PanelGraphics = selectedPictureBox.CreateGraphics();
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
                currentSelectedImage = (Bitmap)selectedPictureBox.Image;
                //g.Clear(Color.White);
                //g.DrawImageUnscaled(textureListManager.getImageAtIndex(index), 0, 0);
                
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
            //Denna hämtar dragndrop från selectedPictureBox
            textureListManager.DragDropRectangle(sender, e);
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

        private void loadedTextureList_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.DoDragDrop(e.Item, DragDropEffects.Copy);
                
            }
        }

        /// <summary>
        /// Enables scrolling with the mouse wheel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectedPictureBox_MouseEnter(object sender, EventArgs e)
        {
            selectedTexturePanel.Focus();
        }

        private void selectedPIctureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (cutRectangle != null && selectedPictureBox.Image != null)
            {
                if (e.X >= recPositionX && e.X <= (recPositionX + cutRectangle.Width) && e.Y >= recPositionY && e.Y <= (recPositionY + cutRectangle.Height))
                {
                    dragRec = true;
                    DoDragDrop(cutImage, DragDropEffects.Copy);
                }
                else
                {
                    mouseDrawRec = true;
                    recPositionX = e.X;
                    recPositionY = e.Y;
                    Update();
                }
            }
        }

        private void selectedPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            drawRectangle(e, "selectedPictureBox");
        }
        private void drawRectangle(MouseEventArgs e, string pictureBox)
        {
            if (e.Button == MouseButtons.Left && mouseDrawRec == true)
            {
                Image picture = null;
                if (pictureBox == "selectedPictureBox")
                    picture = selectedPictureBox.Image;
                else if (pictureBox == "textureAtlasPictureBox")
                {
                    //picture = textureAtlasPictureBox.Image;
                }

                if (picture != null)
                {
                    this.Refresh();
                    Pen pen = new Pen(Color.Black, 2);
                    int width = e.X - recPositionX;
                    int height = e.Y - recPositionY;

                    cutRectangle = new Rectangle(recPositionX,
                                    recPositionY,
                                    Math.Abs(width - recPositionX),
                                    Math.Abs(height - recPositionY));

                    PanelGraphics = selectedPictureBox.CreateGraphics();
                    PanelGraphics.DrawRectangle(pen, cutRectangle);
                }
            }
        }
        private void selectedPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDrawRec = false;
            if (cutRectangle != null && currentSelectedImage != null)
            {
                cutImage = null;
                cutImage = currentSelectedImage.Clone(cutRectangle, PixelFormat.Format32bppArgb);
            }
        } 
    }
}
