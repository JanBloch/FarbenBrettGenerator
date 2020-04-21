using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarbenBrett
{
    public partial class Form1 : Form
    {

        private Random random = new Random();

        int panelXCount = 5;
        int panelYCount = 5;

        private Panel[,] colorPanels;

        int panelWidth = 50;
        int panelHeight = 50;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numAreaWidth.Value = panelXCount;
            numAreaHeight.Value = panelYCount;

            numRectWidth.Value = panelWidth;
            numRectHeight.Value = panelHeight;

            initColorPanels();
            setColors();
        }
        private void initColorPanels()
        {
            colorPanels = new Panel[panelXCount, panelYCount];

            pnlContainer.Width = panelXCount * panelWidth;
            pnlContainer.Height = panelYCount * panelHeight;

            pnlContainer.Controls.Clear();

            for (int i = 0; i < colorPanels.GetLength(0); i++)
            {
                initColorPanelRow(i);
            }
        }

        private void initColorPanelRow(int row)
        {
            for (int i = 0; i < colorPanels.GetLength(1); i++)
            {
                colorPanels[row, i] = new Panel();
                colorPanels[row, i].Width = panelWidth;
                colorPanels[row, i].Height = panelHeight;
                colorPanels[row, i].Left = i * panelWidth;
                colorPanels[row, i].Top = row * panelHeight;
                colorPanels[row, i].BackColor = Color.Black;
                pnlContainer.Controls.Add(colorPanels[row, i]);
            }
        }


        private void setColors()
        {
            for (int i = 0; i < colorPanels.GetLength(0); i++)
            {
                setRowColors(i);
            }
        }

        private void setRowColors(int index)
        {
            for (int i = 0; i < colorPanels.GetLength(1); i++)
            {
                colorPanels[index, i].BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            }
        }

        private void btnSetSize_Click(object sender, EventArgs e)
        {
            panelXCount = Convert.ToInt32(numAreaWidth.Value);
            panelYCount = Convert.ToInt32(numAreaHeight.Value);
            initColorPanels();
            setColors();
        }

        private void btnSetRectangleSize_Click(object sender, EventArgs e)
        {
            panelWidth = Convert.ToInt32(numRectWidth.Value);
            panelHeight = Convert.ToInt32(numRectHeight.Value);
            initColorPanels();
            setColors();
        }
    }
}
