
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Challenges
{
    class Draw
    {
        public static Bitmap update(Bitmap image, int Space)
        {
            for(int i = 0; i < image.Height; i++) {
                for(int j = 0; j < image.Width; j++) {
                    try {
                        image.SetPixel(j, i, Color.Black);
                    } catch { Error(j, i); }
                }
            }
            return image;
        }
        public static Bitmap Clear(int Height, int Width)
        {
            Bitmap image = new Bitmap(Height, Width);
            for (int i = 0; i < image.Height ; i++) {
                for (int j = 1; j < image.Width ; j++) {
                    try {
                        image.SetPixel(j, i, Color.Black);
                    } catch { Error(j, i); }
                }
            }
            return image;
        }
        public static Bitmap Grid( Bitmap image, int grid)
        {
            int X = image.Width / grid;
            int Y = image.Height / grid;
            int hor = 0;
            int ver = 0;
            for (int i = 0; i < image.Height; i++) {
                ver++;
                for ( int j = 0; j < image.Width; j++) {
                    hor++;
                    if(ver == Y) {
                        try {
                            image.SetPixel(j, i, Color.White);
                        } catch { Error(j, i); }
                    }
                    if (hor == X) {
                        try {
                            image.SetPixel(j, i, Color.White);
                            hor = 0;
                        } catch { Error(j,i); }
                    }
                    }
                if (ver == Y) { ver = 0; }
                hor = 0;    
                }
            image.Save("test.png");
            return image;
        }
        public static Bitmap Wall(Bitmap image, MazeGen.Cell cell)
        {
            int scale = image.Width / cell.size;

            if(cell.top)
                for(int i = 0; i < ( scale *(cell.x+1)); i++) {
                    if (i > scale * cell.x) {
                        image.SetPixel(i, scale * cell.y, Color.White);
                    }
                }
            if (cell.bottom)
                for (int i = 0; i < (scale * (cell.x + 1)); i++) {
                    if (i > scale * cell.x) {
                        try {
                            image.SetPixel(i, scale * (cell.y + 1), Color.White);
                        } catch {}
                        }
                }
            if (cell.right)
                for (int i = 0; i < (scale * (cell.y + 1)); i++) {
                    if (i > scale * cell.y) {
                        try {
                            image.SetPixel(scale * (cell.x + 1), i , Color.White);
                        } catch {}
                    }
                }
            if (cell.left)
                for (int i = 0; i < (scale * (cell.y + 1)); i++) {
                    if (i > scale * cell.y) {
                        try {
                            image.SetPixel(scale * (cell.x), i, Color.White);
                        } catch {}
                    }
                }
            return image;
        }
        public static Bitmap Fill(Bitmap image, MazeGen.Cell cell)
        {
            int scale = image.Width / cell.size;

            

            for(int i = 0; i < image.Height; i++) {
                for(int j = 0; j < image.Width; j++) {
                    if (i > scale * (cell.x - 1)&& i < scale * cell.x&& j > scale * (cell.y - 1)&& j < scale * cell.y) {
                        image.SetPixel(j,i, Color.Orange);
                    }
                }
            }

            return image;
        }

        private static void Error(int j, int i)
        {
            Console.WriteLine(i + "," + j);
        }
    }
}
