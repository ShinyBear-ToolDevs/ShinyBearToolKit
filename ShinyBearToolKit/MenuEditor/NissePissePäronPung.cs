using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShinyBearToolKit.MenuEditor
{
    class NissePissePäronPung
    {
    //    private Bitmap image;
    //    private Bitmap newImage;
    //    private Rectangle imageRegion;

    //    private PictureBox pbImageRegion;
    //    private Point clickedPointOne;
    //    private Point clickedPointTwo;

    //    private bool allowMouseMove;
    //    private bool clickedCutButton;
    //    private bool firstClick;

    //    private void btnCut_Click(object sender, EventArgs e)
    //    {
    //        firstClick = false;
    //        clickedCutButton = true;
    //        allowMouseMove = false;

    //        pbImageRegion = new PictureBox();
    //        pbImageRegion.BackColor = Color.Transparent;
    //        pbImageRegion.BorderStyle = BorderStyle.FixedSingle;
    //        pbImageRegion.Size = new Size(0, 0);
    //        pbImageRegion.MouseMove += new MouseEventHandler(pbImageRegion_MouseMove);
    //    }

    //    void pbImageRegion_MouseMove(object sender, MouseEventArgs e)
    //    {
    //        if (allowMouseMove == true)
    //            pbImageRegion.Size = new Size(Math.Abs(e.X - clickedPointOne.X - 2), Math.Abs(e.Y - clickedPointOne.Y - 2));
    //    }

    //    private void selectedPictureBox_MouseMove(object sender, MouseEventArgs e)
    //    {
    //        //It works only from left to right
    //        if (allowMouseMove == true)
    //            pbImageRegion.Size = new Size(Math.Abs(e.X - clickedPointOne.X - 2), Math.Abs(e.Y - clickedPointOne.Y - 2));
    //    }

    //    private void selectedPictureBox_Paint(object sender, PaintEventArgs e)
    //    {
    //        if (newImage != null && allowMouseMove == false)
    //        {
    //            Bitmap bmp = new Bitmap(newImage.Width, newImage.Height);
    //            Graphics g = Graphics.FromImage(bmp);
    //            g.FillRectangle(new SolidBrush(selectedPictureBox.BackColor), new Rectangle(new Point(0, 0), newImage.Size));

    //            g = Graphics.FromImage(image);
    //            g.DrawImage(bmp, clickedPointOne);
    //        }
    //    }

    //    private void selectedPictureBox_MouseClick(object sender, MouseEventArgs e)
    //    {
    //        if (clickedCutButton == true)
    //        {
    //            if (e.Button == MouseButtons.Left)
    //            {
    //                if (firstClick == false)
    //                {
    //                    pbImageRegion.Location = new Point(e.X, e.Y);
    //                    selectedPictureBox.Controls.Add(pbImageRegion);
    //                    clickedPointOne = new Point(e.X, e.Y);
    //                    allowMouseMove = true;
    //                    firstClick = true;
    //                }
    //                else
    //                {
    //                    imageRegion = new Rectangle(clickedPointOne, pbImageRegion.Size);
    //                    newImage = image.Clone(imageRegion, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
    //                    allowMouseMove = false;
    //                    selectedPictureBox.Invalidate();
    //                }
    //            }
    //        }
    //    }

    }
}
