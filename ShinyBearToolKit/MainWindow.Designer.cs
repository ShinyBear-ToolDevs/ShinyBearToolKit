namespace ShinyBearToolkit
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuEditor = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoadImage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addComponentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDebuggingStartDebugging = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDebuggingStoppDebugging = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowFullSize = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelGamePanel = new System.Windows.Forms.Panel();
            this.PanelToolbarComponents = new System.Windows.Forms.Panel();
            this.PanelToobarUnder = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ToolbarToolTabbs = new System.Windows.Forms.TabControl();
            this.ToolbarToolsTabbsPageCode = new System.Windows.Forms.TabPage();
            this.ToolbarToolsTabbPage2 = new System.Windows.Forms.TabPage();
            this.menuEditor.SuspendLayout();
            this.ToolbarToolTabbs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuEditor
            // 
            this.menuEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.buildToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuEditor.Location = new System.Drawing.Point(0, 0);
            this.menuEditor.Name = "menuEditor";
            this.menuEditor.Size = new System.Drawing.Size(1275, 24);
            this.menuEditor.TabIndex = 0;
            this.menuEditor.Text = "Editor";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.menuOpen,
            this.menuSave,
            this.menuSaveAs,
            this.menuSaveAll,
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewProject,
            this.menuNewFile});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // menuNewProject
            // 
            this.menuNewProject.Name = "menuNewProject";
            this.menuNewProject.Size = new System.Drawing.Size(111, 22);
            this.menuNewProject.Text = "Project";
            // 
            // menuNewFile
            // 
            this.menuNewFile.Name = "menuNewFile";
            this.menuNewFile.Size = new System.Drawing.Size(111, 22);
            this.menuNewFile.Text = "File";
            // 
            // menuOpen
            // 
            this.menuOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenProject,
            this.menuOpenFile,
            this.menuLoadImage});
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(115, 22);
            this.menuOpen.Text = "Open";
            // 
            // menuOpenProject
            // 
            this.menuOpenProject.Name = "menuOpenProject";
            this.menuOpenProject.Size = new System.Drawing.Size(136, 22);
            this.menuOpenProject.Text = "Project";
            // 
            // menuOpenFile
            // 
            this.menuOpenFile.Name = "menuOpenFile";
            this.menuOpenFile.Size = new System.Drawing.Size(136, 22);
            this.menuOpenFile.Text = "File";
            // 
            // menuLoadImage
            // 
            this.menuLoadImage.Name = "menuLoadImage";
            this.menuLoadImage.Size = new System.Drawing.Size(136, 22);
            this.menuLoadImage.Text = "Load Image";
            this.menuLoadImage.Click += new System.EventHandler(this.menuLoadImage_Click);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(115, 22);
            this.menuSave.Text = "Save";
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(115, 22);
            this.menuSaveAs.Text = "Save As";
            // 
            // menuSaveAll
            // 
            this.menuSaveAll.Name = "menuSaveAll";
            this.menuSaveAll.Size = new System.Drawing.Size(115, 22);
            this.menuSaveAll.Text = "Save All";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(115, 22);
            this.menuExit.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redoToolStripMenuItem,
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeToolStripMenuItem,
            this.designerToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.codeToolStripMenuItem.Text = "Code";
            // 
            // designerToolStripMenuItem
            // 
            this.designerToolStripMenuItem.Name = "designerToolStripMenuItem";
            this.designerToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.designerToolStripMenuItem.Text = "Designer";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addComponentToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // addComponentToolStripMenuItem
            // 
            this.addComponentToolStripMenuItem.Name = "addComponentToolStripMenuItem";
            this.addComponentToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addComponentToolStripMenuItem.Text = "Add component";
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.buildToolStripMenuItem.Text = "Layer";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDebuggingStartDebugging,
            this.menuDebuggingStoppDebugging});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // menuDebuggingStartDebugging
            // 
            this.menuDebuggingStartDebugging.Name = "menuDebuggingStartDebugging";
            this.menuDebuggingStartDebugging.Size = new System.Drawing.Size(167, 22);
            this.menuDebuggingStartDebugging.Text = "Start Debugging";
            // 
            // menuDebuggingStoppDebugging
            // 
            this.menuDebuggingStoppDebugging.Name = "menuDebuggingStoppDebugging";
            this.menuDebuggingStoppDebugging.Size = new System.Drawing.Size(167, 22);
            this.menuDebuggingStoppDebugging.Text = "Stopp Debugging";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolsOptions});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // menuToolsOptions
            // 
            this.menuToolsOptions.Name = "menuToolsOptions";
            this.menuToolsOptions.Size = new System.Drawing.Size(116, 22);
            this.menuToolsOptions.Text = "Options";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWindowFullSize});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // menuWindowFullSize
            // 
            this.menuWindowFullSize.Name = "menuWindowFullSize";
            this.menuWindowFullSize.Size = new System.Drawing.Size(116, 22);
            this.menuWindowFullSize.Text = "Full Size";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewHelp});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuViewHelp
            // 
            this.menuViewHelp.Name = "menuViewHelp";
            this.menuViewHelp.Size = new System.Drawing.Size(127, 22);
            this.menuViewHelp.Text = "View Help";
            // 
            // PanelGamePanel
            // 
            this.PanelGamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PanelGamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelGamePanel.Location = new System.Drawing.Point(337, 75);
            this.PanelGamePanel.MinimumSize = new System.Drawing.Size(600, 400);
            this.PanelGamePanel.Name = "PanelGamePanel";
            this.PanelGamePanel.Size = new System.Drawing.Size(600, 400);
            this.PanelGamePanel.TabIndex = 1;
            // 
            // PanelToolbarComponents
            // 
            this.PanelToolbarComponents.BackColor = System.Drawing.Color.Peru;
            this.PanelToolbarComponents.Location = new System.Drawing.Point(0, 27);
            this.PanelToolbarComponents.Name = "PanelToolbarComponents";
            this.PanelToolbarComponents.Size = new System.Drawing.Size(286, 510);
            this.PanelToolbarComponents.TabIndex = 3;
            // 
            // PanelToobarUnder
            // 
            this.PanelToobarUnder.BackColor = System.Drawing.Color.Tan;
            this.PanelToobarUnder.Location = new System.Drawing.Point(284, 479);
            this.PanelToobarUnder.Name = "PanelToobarUnder";
            this.PanelToobarUnder.Size = new System.Drawing.Size(704, 57);
            this.PanelToobarUnder.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ToolbarToolTabbs
            // 
            this.ToolbarToolTabbs.Controls.Add(this.ToolbarToolsTabbsPageCode);
            this.ToolbarToolTabbs.Controls.Add(this.ToolbarToolsTabbPage2);
            this.ToolbarToolTabbs.Location = new System.Drawing.Point(972, 27);
            this.ToolbarToolTabbs.Name = "ToolbarToolTabbs";
            this.ToolbarToolTabbs.SelectedIndex = 0;
            this.ToolbarToolTabbs.Size = new System.Drawing.Size(303, 510);
            this.ToolbarToolTabbs.TabIndex = 0;
            // 
            // ToolbarToolsTabbsPageCode
            // 
            this.ToolbarToolsTabbsPageCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToolbarToolsTabbsPageCode.Location = new System.Drawing.Point(4, 22);
            this.ToolbarToolsTabbsPageCode.Name = "ToolbarToolsTabbsPageCode";
            this.ToolbarToolsTabbsPageCode.Padding = new System.Windows.Forms.Padding(3);
            this.ToolbarToolsTabbsPageCode.Size = new System.Drawing.Size(295, 484);
            this.ToolbarToolsTabbsPageCode.TabIndex = 0;
            this.ToolbarToolsTabbsPageCode.Text = "Code";
            // 
            // ToolbarToolsTabbPage2
            // 
            this.ToolbarToolsTabbPage2.BackColor = System.Drawing.Color.Gray;
            this.ToolbarToolsTabbPage2.Location = new System.Drawing.Point(4, 22);
            this.ToolbarToolsTabbPage2.Name = "ToolbarToolsTabbPage2";
            this.ToolbarToolsTabbPage2.Padding = new System.Windows.Forms.Padding(3);
            this.ToolbarToolsTabbPage2.Size = new System.Drawing.Size(295, 484);
            this.ToolbarToolsTabbPage2.TabIndex = 1;
            this.ToolbarToolsTabbPage2.Text = "Design";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 542);
            this.Controls.Add(this.ToolbarToolTabbs);
            this.Controls.Add(this.PanelToobarUnder);
            this.Controls.Add(this.PanelToolbarComponents);
            this.Controls.Add(this.PanelGamePanel);
            this.Controls.Add(this.menuEditor);
            this.MainMenuStrip = this.menuEditor;
            this.Name = "MainWindow";
            this.Text = "Shiny-Bear";
            this.menuEditor.ResumeLayout(false);
            this.menuEditor.PerformLayout();
            this.ToolbarToolTabbs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuEditor;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel PanelGamePanel;
        private System.Windows.Forms.Panel PanelToolbarComponents;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNewProject;
        private System.Windows.Forms.ToolStripMenuItem menuNewFile;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuOpenProject;
        private System.Windows.Forms.ToolStripMenuItem menuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAll;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addComponentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDebuggingStartDebugging;
        private System.Windows.Forms.ToolStripMenuItem menuDebuggingStoppDebugging;
        private System.Windows.Forms.ToolStripMenuItem menuToolsOptions;
        private System.Windows.Forms.ToolStripMenuItem menuWindowFullSize;
        private System.Windows.Forms.ToolStripMenuItem menuViewHelp;
        private System.Windows.Forms.Panel PanelToobarUnder;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLoadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl ToolbarToolTabbs;
        private System.Windows.Forms.TabPage ToolbarToolsTabbsPageCode;
        private System.Windows.Forms.TabPage ToolbarToolsTabbPage2;
    }
}

