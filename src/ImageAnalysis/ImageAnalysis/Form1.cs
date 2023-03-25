using System.Windows.Forms;

namespace ImageAnalysis
{
    public partial class Form1 : Form
    {
        Bitmap bmp = null;
        string path = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                toolStripStatusLabel.Text = "Wait";
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 4);
                path = openFileDialog.FileName;
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 4);
                bmp = new Bitmap(path);
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 4);
                MainPictureBoxUpdate();
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 4);
                toolStripProgressBar.Value = 0;
                toolStripStatusLabel.Text = "Standby";
            }
        }

        void MainPictureBoxUpdate()
        {
            mainPictureBox.Image = bmp;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bmp == null)
            {

            }
            else
            {
                toolStripStatusLabel.Text = "Wait";
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 2);
                bmp.Save(path);
                toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 2);
                toolStripProgressBar.Value = 0;
                toolStripStatusLabel.Text = "Standby";
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bmp == null)
            {

            }
            else
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    toolStripStatusLabel.Text = "Wait";
                    toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 2);
                    bmp.Save(saveFileDialog.FileName);
                    toolStripProgressBar.Value = toolStripProgressBar.Value + (100 / 2);
                    toolStripProgressBar.Value = 0;
                    toolStripStatusLabel.Text = "Standby";
                }
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void cropToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}