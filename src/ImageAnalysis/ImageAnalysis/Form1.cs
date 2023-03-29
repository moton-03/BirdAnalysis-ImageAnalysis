using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ImageAnalysis
{
    public partial class Form1 : Form
    {
        Bitmap bmp = null;
        string path = "";

        bool fileOpen = false;

        public Form1()
        {
            InitializeComponent();
            MenuUpdate();
        }

        void MainPictureBoxUpdate()
        {
            mainPictureBox.Image = bmp;
        }

        void MenuUpdate()
        {
            openToolStripMenuItem.Visible = false;
            saveToolStripMenuItem.Visible = false;
            saveAsToolStripMenuItem.Visible = false;
            closeToolStripMenuItem.Visible = false;
            exitToolStripMenuItem.Visible = false;
            revertToolStripMenuItem.Visible = false;
            imageToolStripMenuItem.Visible = false;
            aboutToolStripMenuItem.Visible = false;

            openToolStripMenuItem.Visible = true;
            exitToolStripMenuItem.Visible = true;
            aboutToolStripMenuItem.Visible = true;

            if (fileOpen)
            {
                openToolStripMenuItem.Visible = true;
                saveToolStripMenuItem.Visible = true;
                saveAsToolStripMenuItem.Visible = true;
                closeToolStripMenuItem .Visible = true;
                revertToolStripMenuItem .Visible = true;
                imageToolStripMenuItem.Visible = true;
            }
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
                fileOpen = true;
                MenuUpdate();
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
            if (!(bmp == null))
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
        }

        private void revertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(bmp == null))
            {
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 3);
                bmp = new Bitmap(path);
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 3);
                MainPictureBoxUpdate();
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 3);
                toolStripProgressBar.Value = 0;
            }
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(bmp == null))
            {
                string inputSideSize = Microsoft.VisualBasic.Interaction.InputBox("SideSize:", "Resize");
                int valueSideSize;
                if ((int.TryParse(inputSideSize, out valueSideSize)))
                {
                    toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 8);
                    int width = valueSideSize;
                    int height = valueSideSize;

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
                    MessageBox.Show("Do not enter text.", "Resize", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(bmp == null))
            {
                string inputAngle = Microsoft.VisualBasic.Interaction.InputBox("Angle:", "Rotate");
                int valueAngle;
                if ((int.TryParse(inputAngle, out valueAngle)))
                {
                    toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 8);
                    int angle = valueAngle;

                    toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 8);
                    var matrix = new Matrix();
                    toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 8);
                    matrix.RotateAt(angle, new PointF(bmp.Width / 2f, bmp.Height / 2f));

                    toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 8);
                    var bmp2 = new Bitmap(bmp.Width, bmp.Height);
                    toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 8);
                    using (var g = Graphics.FromImage(bmp2))
                    {
                        g.Transform = matrix;
                        g.DrawImage(bmp, 0, 0);
                    }

                    toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 8);
                    bmp = bmp2;

                    toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 8);
                    MainPictureBoxUpdate();
                    toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 8);
                    toolStripProgressBar.Value = 0;
                }
                else
                {
                    MessageBox.Show("Do not enter text.", "Rotate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void horizontalFlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(bmp == null))
            {
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 3);
                bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);

                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 3);
                MainPictureBoxUpdate();
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 3);
                toolStripProgressBar.Value = 0;
            }
        }

        private void verticalFlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(bmp == null))
            {
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 3);
                bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);

                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 3);
                MainPictureBoxUpdate();
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 3);
                toolStripProgressBar.Value = 0;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 4);
            bmp = null;
            path = "";
            toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 4);

            toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 4);
            MainPictureBoxUpdate();
            fileOpen = false;
            MenuUpdate();
            toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 4);
            toolStripProgressBar.Value = 0;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by BirdSoft. Included in BirdAnalysis.", "About");
        }
    }
}