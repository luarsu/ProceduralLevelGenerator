using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace maze
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            csCaveGenerator caveG = new csCaveGenerator();
            //Create the cave
            caveG.Build();
            //Place the treasures
            caveG.placeTreasure();
            //Place the enemies
            caveG.placeEnemies();
            //Place the decoration
            caveG.placeDecoration();
            //Connect the caves with tunnels
            caveG.ConnectCaves();
            Bitmap bmp = caveG.GetMapImage();
            //Generate and save the image
            bmp.Save("map.png", ImageFormat.Jpeg);
            Console.WriteLine("Saved!");
        }
    }
}