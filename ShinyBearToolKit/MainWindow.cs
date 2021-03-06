﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ShinyBearToolkit.Gamepanel;
using ShinyBearToolkit.MenuEditor;
using ShinyBearToolKit.MenuEditor;
//using ShinyBearToolkit.ToolbarComponents;
//using ShinyBearToolkit.ToolbarTools;
//using ShinyBearToolkit.ToolbarUnder;



namespace ShinyBearToolkit
{
    public partial class MainWindow : Form
    {

        ManagerMenuEditor managerMenuEditor = new ManagerMenuEditor();
        
        public MainWindow()
        {
            InitializeComponent();
            SetUpMenuHandlers();

        }

        public void SetUpMenuHandlers()
        {
            // Close the application
            menuExit.Click += managerMenuEditor.HandleExit;

            // Save
            menuSave.Click += managerMenuEditor.HandleSave;
            menuSaveAll.Click += managerMenuEditor.HandleSaveAll;
            menuSaveAs.Click += managerMenuEditor.HandleSaveAs;

            // Open
            menuOpenFile.Click += managerMenuEditor.HandleOpenFile;
            menuOpenProject.Click += managerMenuEditor.HandleOpenProject;
            //menuLoadImage.Click += managerMenuEditor.HandlerLoadFile;

            // New
            menuNewFile.Click += managerMenuEditor.HandleNewFile;
            menuNewProject.Click += managerMenuEditor.HandleNewProject;

            //debugging
            menuDebuggingStartDebugging.Click += managerMenuEditor.HandlerDebbuging;
            menuDebuggingStoppDebugging.Click += managerMenuEditor.HandlerStoppDebbugging;

            // window full size
            menuWindowFullSize.Click += managerMenuEditor.HandlerFullSize;

            // Options
            menuToolsOptions.Click += managerMenuEditor.HandlerToolsOptions;

            // Help document
            menuViewHelp.Click += managerMenuEditor.HandlerViewHelp;
        }

        private void spriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managerMenuEditor.HandlerLoadFile();
        }

        private void textureAtlasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managerMenuEditor.HandlerTextureAtlas();
        }


    }
}
