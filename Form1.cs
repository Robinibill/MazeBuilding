using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Challenges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            int max = 25;
            MazeGen.Cell[,] grid = new MazeGen.Cell[max,max];
            for(int i = 0; i < max; i++) {
                for(int j = 0;j < max; j++) {
                    grid[i, j] = new MazeGen.Cell(i, j);
                    grid[i, j].Generate(max);
                }
            }

            foreach(MazeGen.Cell cell in grid) {
                cell.Generate(max);
                image = Draw.Wall(image, cell);
            }
            pictureBox1.Image = image;
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            Bitmap image = Draw.Clear(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = image;
            
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
//        int max = 5;
//        Bitmap image = new Bitmap(pictureBox1.Image);
//        List<MazeGen.Cell> grid = new List<MazeGen.Cell>();
//            for (int i = 0; i<max; i++) { 
//                for (int j = 0; j<max; j++) {
//                    MazeGen.Cell cell = new MazeGen.Cell(i, j);
//        cell.Generate(max);
//                    grid.Add(cell);
//                }
//}
//            foreach (MazeGen.Cell cell in grid) {
//                image = Draw.Wall(image, cell);
//            }
//            pictureBox1.Image = image;
    }
}
