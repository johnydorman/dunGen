using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dunGen
{
    public partial class dunGen : Form
    {

        int width, height;
        int[,] maze;

        public dunGen()
        {
            InitializeComponent();
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            createDungeon();
            loadDungeonPreview(maze, height, width);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            writeToFile(maze, height, width);
        }

        private void defaultButton_Click(object sender, EventArgs e)
        {
            resetToDefault();
        }

        void resetToDefault()
        {
            widthUpDown.Value = 100;
            heightUpDown.Value = 100;
            iterationsUpDown.Value = 5000;
        }

        void createDungeon()
        {
            //Grab and create maze values
            int iterations = (int)iterationsUpDown.Value;
            width = (int)widthUpDown.Value;
            height = (int)heightUpDown.Value;
            maze = new int[height, width];

            int currentY = height / 2;
            int currentX = width / 2;

            //Fill the dungeon
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    maze[y, x] = 1;
                }
            }

            //Empty the starting position
            maze[currentY, currentX] = 0;

            Random rng = new Random();

            //Make a dungeon
            for (int i = 0; i < iterations; i++)
            {
                //Move in a direction
                switch (rng.Next(1, 5))
                {
                    case 1:
                        if (currentY > 2) currentY--;
                        break;
                    case 2:
                        if (currentX > 2) currentX--;
                        break;
                    case 3:
                        if (currentY < height - 2) currentY++;
                        break;
                    case 4:
                        if (currentX < width - 2) currentX++;
                        break;
                }
                maze[currentY, currentX] = 0;
            }
        }

        void loadDungeonPreview(int[,] maze, int height, int width)
        {
            Bitmap bmp = new Bitmap(width, height);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (maze[y, x] == 1) bmp.SetPixel(x, y, Color.Black);
                    else if (maze[y, x] == 0) bmp.SetPixel(x, y, Color.White);
                }
            }

            dungeonPreview.Image = bmp;
        }

        void writeToFile(int[,] maze, int height, int width)
        {
            string mazeString = "";

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    mazeString += maze[y, x];
                }
                mazeString += '\n';
            }

            System.IO.StreamWriter file = new System.IO.StreamWriter(".\\output.txt");
            file.WriteLine(mazeString);
            file.Close();
        }

        private void dunGen_Load(object sender, EventArgs e) {}
    }
}
