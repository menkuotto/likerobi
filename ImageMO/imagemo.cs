﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Windows;
namespace ImageMO
{

    public class Img
    {
   

        /// <summary>
        /// Képlopó, egy webbrowser képét adja vissza
        /// </summary>
        /// <param name="Browser1"></param>
        /// <returns></returns>
        public static Bitmap screen_img(WebBrowser Browser1)
        {
            var topLeftCorner = Browser1.PointToScreen(new Point(0, 0));
            var topLeftGdiPoint = new System.Drawing.Point((int)topLeftCorner.X, (int)topLeftCorner.Y);
            var size = new System.Drawing.Size((int)Browser1.Width, (int)Browser1.Height);
            Bitmap screenShot = new Bitmap(size.Width,size.Height);
                using (var graphics = Graphics.FromImage(screenShot))
                {
                    graphics.CopyFromScreen(topLeftGdiPoint, new System.Drawing.Point(),
                         size, CopyPixelOperation.SourceCopy);
                }
            return screenShot;
        }

 
        /// <summary>
        /// Képlopó, egy webbrowser képét adja vissza és át is méretezi
        /// </summary>
        /// <param name="Browser1"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static Bitmap screen_img_resize(WebBrowser Browser1,int width=250,int height=150)
        { 
        var topLeftCorner = Browser1.PointToScreen(new Point(0, 0));
        var topLeftGdiPoint = new System.Drawing.Point((int)topLeftCorner.X, (int)topLeftCorner.Y);
        var size = new System.Drawing.Size((int)Browser1.Width, (int)Browser1.Height);
        var size2 = new System.Drawing.Size(width, height);
        Bitmap screenShot = new Bitmap(width, height);
                // Bitmap b = new Bitmap(size.Width, size.Height);

                using (var graphics = Graphics.FromImage(screenShot))
                {
                    graphics.CopyFromScreen(topLeftGdiPoint, new System.Drawing.Point(),
                         size2, CopyPixelOperation.SourceCopy);
                }

            return screenShot;
         }

    }
}
