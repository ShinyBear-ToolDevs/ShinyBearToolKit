using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ShinyBearToolkit;
using ShinyBearToolKit.MenuEditor;
using System;

namespace ShinyBearToolkit.MenuEditor
{
    public class ManagerMenuEditor
    {
        SpriteListManager managerMenuEditorImage = new SpriteListManager();
        FormTextureAtlas formTextureAtlas;

        public void HandleExit(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit?", "EXIT!",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void HandleSave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void HandleSaveAll(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void HandleSaveAs(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void HandleOpenProject(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void HandleOpenFile(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void HandleNewProject(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void HandleNewFile(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void HandlerStoppDebbugging(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void HandlerDebbuging(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void HandlerFullSize(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void HandlerToolsOptions(object sender, EventArgs e)
        {
            //MenuEditorOptions options = new MenuEditorOptions();
            //options.Show();
        }

        public void HandlerViewHelp(object sender, EventArgs e)
        {
            //MenuEditorHelp help = new MenuEditorHelp();
            //help.Show();
        }

        public void HandlerLoadFile()
        {
            // Call and show the FormTextureAtlas.
            formTextureAtlas = new FormTextureAtlas();
            formTextureAtlas.Show();

        }
    }
}
