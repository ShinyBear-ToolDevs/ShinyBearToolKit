﻿using System;
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
    public partial class FormTextureAtlas : Form
    {
        private const int EDGE_HEIGHT_SIZE_OFFSET = 50;
        private const int EDGE_WIDTH_SIZE_OFFSET = 28;
        
        private const int ANIMATION_MS_INTERVAL = 25;

        
        
        SpriteListManager spriteListManager = new SpriteListManager();
        
        
        public static Graphics Graphics { get; private set; }

        //TextureAtlas
        private bool mouseOverAtlas = false;
        private Color panelBackground = Color.LawnGreen;
        Timer animationTimer;
        TextureAtlasManager textureAtlasManager = new TextureAtlasManager();
        // DragDrop
        private int indexOfItemUnderMouseToDrag;
        private int indexOfItemUnderMouseToDrop;
        private bool draggingOverAtlas = false;
        private Image currentDraggedImage;
        private Point defaultPosition;

        private Graphics panelGraphics { get; set; }

        private Image image;

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

        public FormTextureAtlas()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            Graphics = this.CreateGraphics();
            panelGraphics = PanelTextureAtlas.CreateGraphics();
            animationTimer = new Timer();
            animationTimer.Interval = ANIMATION_MS_INTERVAL;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            animationTimer.Start();

        }

   

        private void btnImage_Click(object sender, EventArgs e)
        {
            spriteListManager.OpenImage();
            LoadImages();
            //CreateDragDrop();
        }

       
        /// <summary>
        /// Loads the images from SpriteListManager's List, and imputs them into the listview
        /// </summary>
        public void LoadImages()
        {
            //Clears the list of old data
            listView1.Items.Clear();
            imageList1.Images.Clear();
            
            for (int m = 0; m < spriteListManager.NrOfImages; m++)
            {
                //Adds the image from the spriteListManager at the specific index to the imageList
                imageList1.Images.Add(spriteListManager.getImageAtIndex(m));
                //Creates a temporary ListViewItem to hold the image index
                ListViewItem item = new ListViewItem();
                //Sets the image index
                item.ImageIndex = m;
                //Adds the image at the image index to the listview
                listView1.Items.Add(item);
            }
            //Updates
            listView1.Update();
        }
        public void paintPanel(Color color)
        {
            using (Brush brush = new SolidBrush(color))
            {
                Bitmap bufl = new Bitmap(PanelTextureAtlas.Width, PanelTextureAtlas.Height);
                using (panelGraphics = PanelTextureAtlas.CreateGraphics())
                {
                    using (Graphics g = Graphics.FromImage(bufl))
                    {
                        g.FillRectangle(brush, new Rectangle(0, 0, PanelTextureAtlas.Width, PanelTextureAtlas.Height));
                        drawRecOnMouse(g);
                        drawSprites(g);
                        //DrawMoreItems(g);
                        panelGraphics.DrawImageUnscaled(bufl, 0, 0);
                        GC.Collect();
                    }
                }
            }
        }
        public void drawSprites(Graphics g)
        {
            Sprite tempSprite;
            for(int i = 0; i < textureAtlasManager.NrOfSprites; i++)
            {
                tempSprite = textureAtlasManager.getSpriteAtIndex(i);
                g.DrawImageUnscaled(tempSprite.Texture, new Point(tempSprite.X, tempSprite.Y));
            }
        }
        public void drawRecOnMouse(Graphics g)
        {
            if (mouseOverAtlas)
            {
                Point lMousePosition = this.PointToClient(new Point(MousePosition.X, MousePosition.Y));
                g.DrawRectangle(new Pen(Color.Black, 5), lMousePosition.X - (this.Width - PanelTextureAtlas.Width) + EDGE_WIDTH_SIZE_OFFSET, lMousePosition.Y - (this.Height - PanelTextureAtlas.Height) + EDGE_HEIGHT_SIZE_OFFSET, 10, 10);
                
                
            }
        }
        private void PanelTextureAtlas_MouseEnter(object sender, EventArgs e)
        {
            mouseOverAtlas = true;
        }

        private void PanelTextureAtlas_MouseLeave(object sender, EventArgs e)
        {
            mouseOverAtlas = false;
        }
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            paintPanel(panelBackground);
        }
        /// <summary>
        /// Stopping the timer from ticking in the background if the FormTextureAtlas isn't active
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTextureAtlas_FormClosing(object sender, FormClosingEventArgs e)
        {
            animationTimer.Stop();
        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.DoDragDrop(e.Item, DragDropEffects.Copy);
                //currentDraggedImage = (Image)e.Item;
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void PanelTextureAtlas_DragEnter(object sender, DragEventArgs e)
        {
            draggingOverAtlas = true;
            // if the data is a file or a bitmap
            //if (e.Data.GetDataPresent(typeof(Image)) ||
            //    e.Data.GetDataPresent(DataFormats.FileDrop))
            //{
            //    e.Effect = DragDropEffects.Copy;
            //}
            //else
            //{
            //    e.Effect = DragDropEffects.None;
            //}
        }

        private void PanelTextureAtlas_DragLeave(object sender, EventArgs e)
        {
            draggingOverAtlas = false;
        }

        private void PanelTextureAtlas_DragDrop(object sender, DragEventArgs e)
        {
            Point lMousePosition = this.PointToClient(new Point(MousePosition.X, MousePosition.Y));
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                Sprite newSprite = new Sprite((Image)e.Data.GetData(DataFormats.Bitmap), 
                    lMousePosition.X - (this.Width - PanelTextureAtlas.Width) + EDGE_WIDTH_SIZE_OFFSET,
                    lMousePosition.Y - (this.Height - PanelTextureAtlas.Height) + EDGE_HEIGHT_SIZE_OFFSET, 
                    currentDraggedImage.Size.Width, 
                    currentDraggedImage.Size.Height, 
                    new Point(currentDraggedImage.Size.Width / 2, currentDraggedImage.Size.Height / 2));
                textureAtlasManager.addSprite(newSprite);
            }
            currentDraggedImage = null;
        }

    }
}
