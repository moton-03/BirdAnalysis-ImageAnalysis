using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ImageAnalysis
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        string path = "";

        public Form1()
        {
            InitializeComponent();
        }

        void MainPictureBoxUpdate()
        {
            mainPictureBox.Image = bmp;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 4);
                path = openFileDialog.FileName;

                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 4);
                bmp = new Bitmap(path);
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 4);
                MainPictureBoxUpdate();
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 4);
                toolStripProgressBar.Value = 0;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(bmp == null))
            {
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 2);
                bmp.Save(path);
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 2);
                toolStripProgressBar.Value = 0;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(bmp == null))
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 2);
                    bmp.Save(saveFileDialog.FileName);
                    toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 2);
                    toolStripProgressBar.Value = 0;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void cropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string inputTopRightX = Microsoft.VisualBasic.Interaction.InputBox("TopRightX:", "Crop");
            int valueTopRightX;
            if ((int.TryParse(inputTopRightX, out valueTopRightX)))
            {
                string inputTopRightY = Microsoft.VisualBasic.Interaction.InputBox("TopRightY:", "Crop");
                int valueTopRightY;
                if ((int.TryParse(inputTopRightY, out valueTopRightY)))
                {
                    string inputBottomLeftX = Microsoft.VisualBasic.Interaction.InputBox("BottomLeftX:", "Crop");
                    int valueBottomLeftX;
                    if ((int.TryParse(inputBottomLeftX, out valueBottomLeftX)))
                    {
                        string inputBottomLeftY = Microsoft.VisualBasic.Interaction.InputBox("BottomLeftY:", "Crop");
                        int valueBottomLeftY;
                        if ((int.TryParse(inputBottomLeftY, out valueBottomLeftY)))
                        {
                            toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 7);
                            Rectangle rect = new Rectangle(valueTopRightX, valueTopRightY, valueBottomLeftX, valueBottomLeftY);

                            toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 7);
                            Bitmap bmp2 = new Bitmap(rect.Width, rect.Height);
                            toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 7);
                            Graphics g = Graphics.FromImage(bmp2);
                            toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 7);
                            g.DrawImage(bmp, new Rectangle(0, 0, bmp2.Width, bmp2.Height), rect, GraphicsUnit.Pixel);

                            toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 7);
                            bmp = bmp2;

                            toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 7);
                            MainPictureBoxUpdate();
                            toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 7);
                            toolStripProgressBar.Value = 0;
                        }
                        else
                        {
                            MessageBox.Show("Do not enter text.", "Crop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Do not enter text.", "Crop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Do not enter text.", "Crop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Do not enter text.", "Crop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void revertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 3);
            bmp = new Bitmap(path);
            toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 3);
            MainPictureBoxUpdate();
            toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 3);
            toolStripProgressBar.Value = 0;
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string inputMagnification = Microsoft.VisualBasic.Interaction.InputBox("Magnification:", "Crop");
            int valueMagnification;
            if ((int.TryParse(inputMagnification, out valueMagnification)))
            {
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 8);
                int width = bmp.Width * valueMagnification;
                int height = bmp.Height * valueMagnification;

                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 8);
                Bitmap bmp2 = new Bitmap(width, height);
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 8);
                Graphics g = Graphics.FromImage(bmp2);
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 8);
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 8);
                g.DrawImage(bmp, 0, 0, width, height);

                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 8);
                bmp = bmp2;

                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 8);
                MainPictureBoxUpdate();
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 8);
                toolStripProgressBar.Value = 0;
            }
            else
            {
                MessageBox.Show("Do not enter text.", "Crop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}