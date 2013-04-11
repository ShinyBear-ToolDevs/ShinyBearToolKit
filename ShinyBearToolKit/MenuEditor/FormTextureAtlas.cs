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
        private const int EDGE_HEIGHT_SIZE_OFFSET = 50;
        private const int EDGE_WIDTH_SIZE_OFFSET = 28;
        private Color panelBackground = Color.LawnGreen;
        private const int ANIMATION_MS_INTERVAL = 25;

        private bool mouseOverAtlas = false;
        SpriteListManager spriteListManager = new SpriteListManager();
        Timer animationTimer;
        
        public static Graphics Graphics { get; private set; }


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
            CreateDragDrop();
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
                        //DrawItems(g);
                        //DrawMoreItems(g);
                        panelGraphics.DrawImageUnscaled(bufl, 0, 0);
                        GC.Collect();
                    }
                }
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

        /// <summary>
        /// Drag and dropEventhandlers to put the imga inside the panel
        /// </summary>
        private void CreateDragDrop()
        {
           
            this.AllowDrop = true;
            this.DragDrop += new DragEventHandler(FormTextureAtlas_DragDrop);
            this.DragEnter += new DragEventHandler(FormTextureAtlas_DragEnter);
        }

        private void FormTextureAtlas_DragDrop(object sender, DragEventArgs e)
        {   
            // Handle file drop data.
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Assign the file names to a string array in case the user has selected multiple files.
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                try
                {
                    // assign the first image.
                    this.image = Image.FromFile(files[0]);

                    // set the image position equal to the drop point.
                    this.defaultPosition = this.PointToClient(new Point(e.X, e.Y));
                }
                catch (Exception message)
                {
                    MessageBox.Show(message.Message);
                    return;
                }

            }
            // handle the bitmap data
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                try
                {
                    // Create an Image and assign it to the image.
                    this.image = (Image)e.Data.GetData(DataFormats.Bitmap);
                    // set the image position equal to  the drop point.
                    this.defaultPosition = this.PointToClient(new Point(e.X, e.Y));
                }
                catch (Exception message)
                {
                    MessageBox.Show(message.Message);
                    return;
                }
            }
            // force the form to be redraw with the image.
            this.Invalidate();
        }

        private void FormTextureAtlas_DragEnter(object sender, DragEventArgs e)
        {
            // if the data is a file or a bitmap
            if (e.Data.GetDataPresent(DataFormats.Bitmap) ||
                e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
            
        }

        private void ImageOnPanel(PaintEventArgs e)
        {
            if (defaultPosition != null && defaultPosition != Point.Empty)
            {
                e.Graphics.DrawImage(image, defaultPosition);
            }

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            
                MessageBox.Show("hej");
            
        }

        
    }
}
