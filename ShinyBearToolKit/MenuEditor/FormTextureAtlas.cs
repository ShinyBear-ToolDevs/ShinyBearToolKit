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
        MenuEditorImage managerMenuImage = new MenuEditorImage();

        public static Graphics Graphics { get; private set; }

        public FormTextureAtlas()
        {
            InitializeComponent();
            Graphics = this.CreateGraphics();
        }

      
    }
}
