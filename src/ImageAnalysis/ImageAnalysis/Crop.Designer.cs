namespace ImageAnalysis
{
    partial class Crop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crop));
            mainTableLayoutPanel = new TableLayoutPanel();
            cropButton = new Button();
            tabControl1 = new TabControl();
            topLeftTabPage = new TabPage();
            bottomRightTabPage = new TabPage();
            mainTableLayoutPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(cropButton, 0, 1);
            mainTableLayoutPanel.Controls.Add(tabControl1, 0, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 2;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle());
            mainTableLayoutPanel.Size = new Size(800, 450);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // cropButton
            // 
            cropButton.Location = new Point(3, 413);
            cropButton.Name = "cropButton";
            cropButton.Size = new Size(112, 34);
            cropButton.TabIndex = 0;
            cropButton.Text = "Clop";
            cropButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(topLeftTabPage);
            tabControl1.Controls.Add(bottomRightTabPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(794, 404);
            tabControl1.TabIndex = 1;
            // 
            // topLeftTabPage
            // 
            topLeftTabPage.Location = new Point(4, 34);
            topLeftTabPage.Name = "topLeftTabPage";
            topLeftTabPage.Padding = new Padding(3);
            topLeftTabPage.Size = new Size(786, 366);
            topLeftTabPage.TabIndex = 0;
            topLeftTabPage.Text = "TopLeft";
            topLeftTabPage.UseVisualStyleBackColor = true;
            // 
            // bottomRightTabPage
            // 
            bottomRightTabPage.Location = new Point(4, 34);
            bottomRightTabPage.Name = "bottomRightTabPage";
            bottomRightTabPage.Padding = new Padding(3);
            bottomRightTabPage.Size = new Size(786, 366);
            bottomRightTabPage.TabIndex = 1;
            bottomRightTabPage.Text = "BottomRight";
            bottomRightTabPage.UseVisualStyleBackColor = true;
            // 
            // Crop
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainTableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Crop";
            Text = "Crop";
            mainTableLayoutPanel.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private Button cropButton;
        private TabControl tabControl1;
        private TabPage topLeftTabPage;
        private TabPage bottomRightTabPage;
    }
}