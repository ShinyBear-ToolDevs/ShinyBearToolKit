namespace ShinyBearToolKit.MenuEditor
{
    partial class FormCreateTextureAtlas
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
            this.components = new System.ComponentModel.Container();
            this.addTextureButton = new System.Windows.Forms.Button();
            this.loadedTextureList = new System.Windows.Forms.ListView();
            this.loadedImages = new System.Windows.Forms.ImageList(this.components);
            this.selectedTexturePanel = new System.Windows.Forms.Panel();
            this.TextureAtlasPanel = new System.Windows.Forms.Panel();
            this.selectedPictureBox = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.selectedTexturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTextureButton
            // 
            this.addTextureButton.Location = new System.Drawing.Point(12, 39);
            this.addTextureButton.Name = "addTextureButton";
            this.addTextureButton.Size = new System.Drawing.Size(171, 28);
            this.addTextureButton.TabIndex = 0;
            this.addTextureButton.Text = "Add image";
            this.addTextureButton.UseVisualStyleBackColor = true;
            this.addTextureButton.Click += new System.EventHandler(this.addTextureButton_Click);
            // 
            // loadedTextureList
            // 
            this.loadedTextureList.AllowDrop = true;
            this.loadedTextureList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.loadedTextureList.GridLines = true;
            this.loadedTextureList.LargeImageList = this.loadedImages;
            this.loadedTextureList.Location = new System.Drawing.Point(12, 84);
            this.loadedTextureList.MultiSelect = false;
            this.loadedTextureList.Name = "loadedTextureList";
            this.loadedTextureList.Size = new System.Drawing.Size(171, 484);
            this.loadedTextureList.TabIndex = 1;
            this.loadedTextureList.UseCompatibleStateImageBehavior = false;
            this.loadedTextureList.SelectedIndexChanged += new System.EventHandler(this.loadedTextureList_SelectedIndexChanged);
            this.loadedTextureList.DragDrop += new System.Windows.Forms.DragEventHandler(this.loadedTextureList_DragDrop);
            // 
            // loadedImages
            // 
            this.loadedImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.loadedImages.ImageSize = new System.Drawing.Size(16, 16);
            this.loadedImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // selectedTexturePanel
            // 
            this.selectedTexturePanel.AllowDrop = true;
            this.selectedTexturePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedTexturePanel.AutoScroll = true;
            this.selectedTexturePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selectedTexturePanel.Controls.Add(this.selectedPictureBox);
            this.selectedTexturePanel.Location = new System.Drawing.Point(3, 3);
            this.selectedTexturePanel.Name = "selectedTexturePanel";
            this.selectedTexturePanel.Size = new System.Drawing.Size(283, 478);
            this.selectedTexturePanel.TabIndex = 2;
            this.selectedTexturePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.selectedTexturePanel_MouseDown);
            // 
            // TextureAtlasPanel
            // 
            this.TextureAtlasPanel.AllowDrop = true;
            this.TextureAtlasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TextureAtlasPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TextureAtlasPanel.Location = new System.Drawing.Point(3, 3);
            this.TextureAtlasPanel.Name = "TextureAtlasPanel";
            this.TextureAtlasPanel.Size = new System.Drawing.Size(447, 473);
            this.TextureAtlasPanel.TabIndex = 3;
            this.TextureAtlasPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextureAtlasPanel_DragDrop);
            this.TextureAtlasPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextureAtlasPanel_DragEnter);
            this.TextureAtlasPanel.DragLeave += new System.EventHandler(this.TextureAtlasPanel_DragLeave);
            // 
            // selectedPictureBox
            // 
            this.selectedPictureBox.Location = new System.Drawing.Point(1, 1);
            this.selectedPictureBox.Name = "selectedPictureBox";
            this.selectedPictureBox.Size = new System.Drawing.Size(375, 470);
            this.selectedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.selectedPictureBox.TabIndex = 0;
            this.selectedPictureBox.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(206, 84);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.selectedTexturePanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TextureAtlasPanel);
            this.splitContainer1.Size = new System.Drawing.Size(746, 484);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 4;
            // 
            // FormCreateTextureAtlas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(977, 577);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.loadedTextureList);
            this.Controls.Add(this.addTextureButton);
            this.Name = "FormCreateTextureAtlas";
            this.Text = "Create TextureAtlas";
            this.SizeChanged += new System.EventHandler(this.FormCreateTextureAtlas_SizeChanged);
            this.selectedTexturePanel.ResumeLayout(false);
            this.selectedTexturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTextureButton;
        private System.Windows.Forms.ListView loadedTextureList;
        private System.Windows.Forms.Panel selectedTexturePanel;
        private System.Windows.Forms.Panel TextureAtlasPanel;
        private System.Windows.Forms.ImageList loadedImages;
        private System.Windows.Forms.PictureBox selectedPictureBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}