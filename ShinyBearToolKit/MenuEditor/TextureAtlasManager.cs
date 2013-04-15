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
    public class TextureAtlasManager
    {
        TextureListManager textureListManager = new TextureListManager();

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
    }
}

