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
        SpriteListManager spriteListManager = new SpriteListManager();

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
            
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            spriteListManager.OpenImage();
        }

        public void ShowImage()
        {

            for (int m = 1; m < image; m++)
            {
                listView1.Items.AddRange(spriteListManager.OpenImage());

            }
        }

       
    }
}
