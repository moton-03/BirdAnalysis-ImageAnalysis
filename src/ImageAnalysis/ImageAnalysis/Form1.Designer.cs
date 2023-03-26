namespace ImageAnalysis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mainTableLayoutPanel = new TableLayoutPanel();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            closeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            revertToolStripMenuItem = new ToolStripMenuItem();
            imageToolStripMenuItem = new ToolStripMenuItem();
            cropToolStripMenuItem = new ToolStripMenuItem();
            resizeToolStripMenuItem = new ToolStripMenuItem();
            rotateToolStripMenuItem = new ToolStripMenuItem();
            flipToolStripMenuItem = new ToolStripMenuItem();
            horizontalFlipToolStripMenuItem = new ToolStripMenuItem();
            verticalFlipToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripProgressBar = new ToolStripProgressBar();
            mainPictureBoxPanel = new Panel();
            mainPictureBox = new PictureBox();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            mainTableLayoutPanel.SuspendLayout();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            mainPictureBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPictureBox).BeginInit();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(menuStrip, 0, 0);
            mainTableLayoutPanel.Controls.Add(statusStrip, 0, 2);
            mainTableLayoutPanel.Controls.Add(mainPictureBoxPanel, 0, 1);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 3;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle());
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle());
            mainTableLayoutPanel.Size = new Size(800, 450);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, imageToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 33);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, toolStripSeparator2, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator3, closeToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(270, 34);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(267, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(270, 34);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(270, 34);
            saveAsToolStripMenuItem.Text = "SaveAs";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(267, 6);
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(270, 34);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(267, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(270, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { revertToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // revertToolStripMenuItem
            // 
            revertToolStripMenuItem.Name = "revertToolStripMenuItem";
            revertToolStripMenuItem.Size = new Size(164, 34);
            revertToolStripMenuItem.Text = "Revert";
            revertToolStripMenuItem.Click += revertToolStripMenuItem_Click;
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cropToolStripMenuItem, resizeToolStripMenuItem, rotateToolStripMenuItem, flipToolStripMenuItem });
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(78, 29);
            imageToolStripMenuItem.Text = "Image";
            // 
            // cropToolStripMenuItem
            // 
            cropToolStripMenuItem.Name = "cropToolStripMenuItem";
            cropToolStripMenuItem.Size = new Size(166, 34);
            cropToolStripMenuItem.Text = "Crop";
            cropToolStripMenuItem.Click += cropToolStripMenuItem_Click;
            // 
            // resizeToolStripMenuItem
            // 
            resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            resizeToolStripMenuItem.Size = new Size(166, 34);
            resizeToolStripMenuItem.Text = "Resize";
            resizeToolStripMenuItem.Click += resizeToolStripMenuItem_Click;
            // 
            // rotateToolStripMenuItem
            // 
            rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            rotateToolStripMenuItem.Size = new Size(166, 34);
            rotateToolStripMenuItem.Text = "Rotate";
            rotateToolStripMenuItem.Click += rotateToolStripMenuItem_Click;
            // 
            // flipToolStripMenuItem
            // 
            flipToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { horizontalFlipToolStripMenuItem, verticalFlipToolStripMenuItem });
            flipToolStripMenuItem.Name = "flipToolStripMenuItem";
            flipToolStripMenuItem.Size = new Size(166, 34);
            flipToolStripMenuItem.Text = "Flip";
            // 
            // horizontalFlipToolStripMenuItem
            // 
            horizontalFlipToolStripMenuItem.Name = "horizontalFlipToolStripMenuItem";
            horizontalFlipToolStripMenuItem.Size = new Size(224, 34);
            horizontalFlipToolStripMenuItem.Text = "HorizontalFlip";
            horizontalFlipToolStripMenuItem.Click += horizontalFlipToolStripMenuItem_Click;
            // 
            // verticalFlipToolStripMenuItem
            // 
            verticalFlipToolStripMenuItem.Name = "verticalFlipToolStripMenuItem";
            verticalFlipToolStripMenuItem.Size = new Size(224, 34);
            verticalFlipToolStripMenuItem.Text = "VerticalFlip";
            verticalFlipToolStripMenuItem.Click += verticalFlipToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(270, 34);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripProgressBar });
            statusStrip.Location = new Point(0, 418);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 32);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            toolStripProgressBar.Name = "toolStripProgressBar";
            toolStripProgressBar.Size = new Size(100, 24);
            // 
            // mainPictureBoxPanel
            // 
            mainPictureBoxPanel.AutoScroll = true;
            mainPictureBoxPanel.Controls.Add(mainPictureBox);
            mainPictureBoxPanel.Dock = DockStyle.Fill;
            mainPictureBoxPanel.Location = new Point(3, 36);
            mainPictureBoxPanel.Name = "mainPictureBoxPanel";
            mainPictureBoxPanel.Size = new Size(794, 379);
            mainPictureBoxPanel.TabIndex = 2;
            // 
            // mainPictureBox
            // 
            mainPictureBox.Location = new Point(0, 0);
            mainPictureBox.Name = "mainPictureBox";
            mainPictureBox.Size = new Size(794, 379);
            mainPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            mainPictureBox.TabIndex = 0;
            mainPictureBox.TabStop = false;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainTableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "ImageAnalysis";
            mainTableLayoutPanel.ResumeLayout(false);
            mainTableLayoutPanel.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            mainPictureBoxPanel.ResumeLayout(false);
            mainPictureBoxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem revertToolStripMenuItem;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem cropToolStripMenuItem;
        private ToolStripMenuItem rotateToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private StatusStrip statusStrip;
        private ToolStripProgressBar toolStripProgressBar;
        private OpenFileDialog openFileDialog;
        private Panel mainPictureBoxPanel;
        private PictureBox mainPictureBox;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private SaveFileDialog saveFileDialog;
        private ToolStripMenuItem resizeToolStripMenuItem;
        private ToolStripMenuItem flipToolStripMenuItem;
        private ToolStripMenuItem horizontalFlipToolStripMenuItem;
        private ToolStripMenuItem verticalFlipToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}