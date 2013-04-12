using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShinyBearToolKit.MenuEditor
{
    class TextureAtlasManager
    {
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
    }
}
