using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShinyBearToolKit.MenuEditor
{
    public partial class SpriteAnimation : Form
    {
        public SpriteAnimation()
        {
            InitializeComponent();
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
