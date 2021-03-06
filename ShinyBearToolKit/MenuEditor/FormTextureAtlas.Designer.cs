﻿namespace ShinyBearToolKit.MenuEditor
{
    partial class FormTextureAtlas
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
            this.btnImage = new System.Windows.Forms.Button();
            this.listViewImage = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PanelTextureAtlas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(21, 12);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(114, 47);
            this.btnImage.TabIndex = 0;
            this.btnImage.Text = "Add Image";
            this.btnImage.UseVisualStyleBackColor = true;
            
            // 
            // listViewImage
            // 
            this.listViewImage.AllowDrop = true;
            this.listViewImage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewImage.LargeImageList = this.imageList1;
            this.listViewImage.Location = new System.Drawing.Point(21, 77);
            this.listViewImage.Name = "listViewImage";
            this.listViewImage.Size = new System.Drawing.Size(216, 351);
            this.listViewImage.TabIndex = 1;
            this.listViewImage.UseCompatibleStateImageBehavior = false;
            this.listViewImage.View = System.Windows.Forms.View.Tile;
            
            
            
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Images";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PanelTextureAtlas
            // 
            this.PanelTextureAtlas.AllowDrop = true;
            this.PanelTextureAtlas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelTextureAtlas.Location = new System.Drawing.Point(243, 12);
            this.PanelTextureAtlas.Name = "PanelTextureAtlas";
            this.PanelTextureAtlas.Size = new System.Drawing.Size(614, 416);
            this.PanelTextureAtlas.TabIndex = 2;
            this.PanelTextureAtlas.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelTextureAtlas_DragDrop);
            this.PanelTextureAtlas.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelTextureAtlas_DragEnter);
            this.PanelTextureAtlas.DragLeave += new System.EventHandler(this.PanelTextureAtlas_DragLeave);
            this.PanelTextureAtlas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTextureAtlas_MouseDown);
            this.PanelTextureAtlas.MouseEnter += new System.EventHandler(this.PanelTextureAtlas_MouseEnter);
            this.PanelTextureAtlas.MouseLeave += new System.EventHandler(this.PanelTextureAtlas_MouseLeave);
            this.PanelTextureAtlas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelTextureAtlas_MouseUp);
            // 
            // FormTextureAtlas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 440);
            this.Controls.Add(this.PanelTextureAtlas);
            this.Controls.Add(this.listViewImage);
            this.Controls.Add(this.btnImage);
            this.Name = "FormTextureAtlas";
            this.Text = "FormTextureAtlas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTextureAtlas_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.ListView listViewImage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel PanelTextureAtlas;
        
    }
}