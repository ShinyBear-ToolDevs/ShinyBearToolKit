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
    public partial class FormTextureAtlas : Form
    {
        private const int ANIMATION_MS_INTERVAL = 25;
        SpriteListManager spriteListManager = new SpriteListManager();
        Timer animationTimer;
        public static Graphics Graphics { get; private set; }

        private Image image;

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

        public FormTextureAtlas()
        {
            InitializeComponent();
            Graphics = this.CreateGraphics();
            animationTimer = new Timer();
            animationTimer.Interval = ANIMATION_MS_INTERVAL;            
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            spriteListManager.OpenImage();
            LoadImages();
        }

        //public void ShowImage()
        //{

        //    for (int m = 1; m < image; m++)
        //    {
        //        listView1.Items.AddRange(spriteListManager.OpenImage());

        //    }
        //}
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
        public void paintBackground(Color color)
        {
            Brush brush = new SolidBrush(color);
            Bitmap bufl = new Bitmap(PanelTextureAtlas.Width, PanelTextureAtlas.Height);
            using (Graphics g = Graphics.FromImage(bufl))
            {
                g.FillRectangle(brush, new Rectangle(PanelTextureAtlas.Location.X, PanelTextureAtlas.Location.Y, PanelTextureAtlas.Width, PanelTextureAtlas.Height));
                //DrawItems(g);
                //DrawMoreItems(g);
                PanelTextureAtlas.CreateGraphics().DrawImageUnscaled(bufl, 0, 0);
            }
        }
       
    }
}
