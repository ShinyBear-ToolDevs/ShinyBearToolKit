namespace ShinyBearToolKit.MenuEditor
{
    partial class SpriteAnimation
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
            this.button1 = new System.Windows.Forms.Button();
            this.loadedTextureList = new System.Windows.Forms.ListView();
            this.selectedTexturePanel = new System.Windows.Forms.Panel();
            this.TextureAtlasPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // loadedTextureList
            // 
            this.loadedTextureList.AllowDrop = true;
            this.loadedTextureList.Location = new System.Drawing.Point(12, 89);
            this.loadedTextureList.Name = "loadedTextureList";
            this.loadedTextureList.Size = new System.Drawing.Size(171, 452);
            this.loadedTextureList.TabIndex = 1;
            this.loadedTextureList.UseCompatibleStateImageBehavior = false;
            this.loadedTextureList.SelectedIndexChanged += new System.EventHandler(this.loadedTextureList_SelectedIndexChanged);
            this.loadedTextureList.DragDrop += new System.Windows.Forms.DragEventHandler(this.loadedTextureList_DragDrop);
            // 
            // selectedTexturePanel
            // 
            this.selectedTexturePanel.AllowDrop = true;
            this.selectedTexturePanel.Location = new System.Drawing.Point(189, 89);
            this.selectedTexturePanel.Name = "selectedTexturePanel";
            this.selectedTexturePanel.Size = new System.Drawing.Size(360, 452);
            this.selectedTexturePanel.TabIndex = 2;
            this.selectedTexturePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.selectedTexturePanel_MouseDown);
            // 
            // TextureAtlasPanel
            // 
            this.TextureAtlasPanel.AllowDrop = true;
            this.TextureAtlasPanel.Location = new System.Drawing.Point(555, 89);
            this.TextureAtlasPanel.Name = "TextureAtlasPanel";
            this.TextureAtlasPanel.Size = new System.Drawing.Size(574, 452);
            this.TextureAtlasPanel.TabIndex = 3;
            this.TextureAtlasPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextureAtlasPanel_DragDrop);
            this.TextureAtlasPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextureAtlasPanel_DragEnter);
            this.TextureAtlasPanel.DragLeave += new System.EventHandler(this.TextureAtlasPanel_DragLeave);
            // 
            // SpriteAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1141, 577);
            this.Controls.Add(this.TextureAtlasPanel);
            this.Controls.Add(this.selectedTexturePanel);
            this.Controls.Add(this.loadedTextureList);
            this.Controls.Add(this.button1);
            this.Name = "SpriteAnimation";
            this.Text = "SpriteAnimation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView loadedTextureList;
        private System.Windows.Forms.Panel selectedTexturePanel;
        private System.Windows.Forms.Panel TextureAtlasPanel;
    }
}