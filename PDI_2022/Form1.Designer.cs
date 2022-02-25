
namespace PDI_2022
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
            this.origemPictureBox = new System.Windows.Forms.PictureBox();
            this.destinoPictureBox = new System.Windows.Forms.PictureBox();
            this.rPanel = new System.Windows.Forms.Panel();
            this.gPanel = new System.Windows.Forms.Panel();
            this.bPanel = new System.Windows.Forms.Panel();
            this.rgbPanel = new System.Windows.Forms.Panel();
            this.xTrackBar = new System.Windows.Forms.TrackBar();
            this.yTrackBar = new System.Windows.Forms.TrackBar();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.pixelLabel = new System.Windows.Forms.Label();
            this.rgbLabel = new System.Windows.Forms.Label();
            this.copiaButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalasDeCinzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luminosityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efeitosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espelhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinoCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.origemPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTrackBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // origemPictureBox
            // 
            this.origemPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("origemPictureBox.Image")));
            this.origemPictureBox.Location = new System.Drawing.Point(53, 49);
            this.origemPictureBox.Name = "origemPictureBox";
            this.origemPictureBox.Size = new System.Drawing.Size(225, 225);
            this.origemPictureBox.TabIndex = 0;
            this.origemPictureBox.TabStop = false;
            // 
            // destinoPictureBox
            // 
            this.destinoPictureBox.Location = new System.Drawing.Point(528, 49);
            this.destinoPictureBox.Name = "destinoPictureBox";
            this.destinoPictureBox.Size = new System.Drawing.Size(225, 225);
            this.destinoPictureBox.TabIndex = 1;
            this.destinoPictureBox.TabStop = false;
            // 
            // rPanel
            // 
            this.rPanel.Location = new System.Drawing.Point(296, 49);
            this.rPanel.Name = "rPanel";
            this.rPanel.Size = new System.Drawing.Size(112, 112);
            this.rPanel.TabIndex = 5;
            // 
            // gPanel
            // 
            this.gPanel.Location = new System.Drawing.Point(410, 49);
            this.gPanel.Name = "gPanel";
            this.gPanel.Size = new System.Drawing.Size(112, 112);
            this.gPanel.TabIndex = 6;
            // 
            // bPanel
            // 
            this.bPanel.Location = new System.Drawing.Point(296, 162);
            this.bPanel.Name = "bPanel";
            this.bPanel.Size = new System.Drawing.Size(112, 112);
            this.bPanel.TabIndex = 7;
            // 
            // rgbPanel
            // 
            this.rgbPanel.Location = new System.Drawing.Point(410, 162);
            this.rgbPanel.Name = "rgbPanel";
            this.rgbPanel.Size = new System.Drawing.Size(112, 112);
            this.rgbPanel.TabIndex = 8;
            // 
            // xTrackBar
            // 
            this.xTrackBar.Location = new System.Drawing.Point(53, 305);
            this.xTrackBar.Maximum = 255;
            this.xTrackBar.Name = "xTrackBar";
            this.xTrackBar.Size = new System.Drawing.Size(225, 45);
            this.xTrackBar.TabIndex = 9;
            this.xTrackBar.Scroll += new System.EventHandler(this.xTrackBar_Scroll);
            // 
            // yTrackBar
            // 
            this.yTrackBar.Location = new System.Drawing.Point(2, 49);
            this.yTrackBar.Maximum = 255;
            this.yTrackBar.Name = "yTrackBar";
            this.yTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.yTrackBar.Size = new System.Drawing.Size(45, 225);
            this.yTrackBar.TabIndex = 10;
            this.yTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.yTrackBar.Value = 255;
            this.yTrackBar.Scroll += new System.EventHandler(this.yTrackBar_Scroll);
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(2, 31);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(13, 15);
            this.yLabel.TabIndex = 11;
            this.yLabel.Text = "0";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(284, 292);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(13, 15);
            this.xLabel.TabIndex = 12;
            this.xLabel.Text = "0";
            // 
            // pixelLabel
            // 
            this.pixelLabel.AutoSize = true;
            this.pixelLabel.Location = new System.Drawing.Point(76, 31);
            this.pixelLabel.Name = "pixelLabel";
            this.pixelLabel.Size = new System.Drawing.Size(53, 15);
            this.pixelLabel.TabIndex = 13;
            this.pixelLabel.Text = "Pixel: 0;0";
            // 
            // rgbLabel
            // 
            this.rgbLabel.AutoSize = true;
            this.rgbLabel.Location = new System.Drawing.Point(296, 31);
            this.rgbLabel.Name = "rgbLabel";
            this.rgbLabel.Size = new System.Drawing.Size(77, 15);
            this.rgbLabel.TabIndex = 14;
            this.rgbLabel.Text = "R: 0; G: 0; B: 0";
            // 
            // copiaButton
            // 
            this.copiaButton.Location = new System.Drawing.Point(236, 385);
            this.copiaButton.Name = "copiaButton";
            this.copiaButton.Size = new System.Drawing.Size(98, 23);
            this.copiaButton.TabIndex = 15;
            this.copiaButton.Text = "Copiar";
            this.copiaButton.UseVisualStyleBackColor = true;
            this.copiaButton.Click += new System.EventHandler(this.copiaButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrosToolStripMenuItem,
            this.efeitosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escalasDeCinzaToolStripMenuItem});
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.filtrosToolStripMenuItem.Text = "Filtros";
            // 
            // escalasDeCinzaToolStripMenuItem
            // 
            this.escalasDeCinzaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.luminosityToolStripMenuItem,
            this.averageToolStripMenuItem,
            this.lightnessToolStripMenuItem});
            this.escalasDeCinzaToolStripMenuItem.Name = "escalasDeCinzaToolStripMenuItem";
            this.escalasDeCinzaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.escalasDeCinzaToolStripMenuItem.Text = "Escalas de Cinza";
            // 
            // luminosityToolStripMenuItem
            // 
            this.luminosityToolStripMenuItem.Name = "luminosityToolStripMenuItem";
            this.luminosityToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.luminosityToolStripMenuItem.Text = "Luminosity";
            this.luminosityToolStripMenuItem.Click += new System.EventHandler(this.luminosityToolStripMenuItem_Click);
            // 
            // averageToolStripMenuItem
            // 
            this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
            this.averageToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.averageToolStripMenuItem.Text = "Average";
            this.averageToolStripMenuItem.Click += new System.EventHandler(this.averageToolStripMenuItem_Click);
            // 
            // lightnessToolStripMenuItem
            // 
            this.lightnessToolStripMenuItem.Name = "lightnessToolStripMenuItem";
            this.lightnessToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.lightnessToolStripMenuItem.Text = "Lightness";
            this.lightnessToolStripMenuItem.Click += new System.EventHandler(this.lightnessToolStripMenuItem_Click);
            // 
            // efeitosToolStripMenuItem
            // 
            this.efeitosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negativoToolStripMenuItem,
            this.espelhamentoToolStripMenuItem});
            this.efeitosToolStripMenuItem.Name = "efeitosToolStripMenuItem";
            this.efeitosToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.efeitosToolStripMenuItem.Text = "Efeitos";
            // 
            // negativoToolStripMenuItem
            // 
            this.negativoToolStripMenuItem.Name = "negativoToolStripMenuItem";
            this.negativoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.negativoToolStripMenuItem.Text = "Negativo";
            this.negativoToolStripMenuItem.Click += new System.EventHandler(this.negativoToolStripMenuItem_Click);
            // 
            // espelhamentoToolStripMenuItem
            // 
            this.espelhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verticalToolStripMenuItem,
            this.horizontalToolStripMenuItem});
            this.espelhamentoToolStripMenuItem.Name = "espelhamentoToolStripMenuItem";
            this.espelhamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.espelhamentoToolStripMenuItem.Text = "Espelhamento";
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // destinoCheckBox
            // 
            this.destinoCheckBox.AutoSize = true;
            this.destinoCheckBox.Location = new System.Drawing.Point(53, 280);
            this.destinoCheckBox.Name = "destinoCheckBox";
            this.destinoCheckBox.Size = new System.Drawing.Size(154, 19);
            this.destinoCheckBox.TabIndex = 17;
            this.destinoCheckBox.Text = "Usar imagem de destino";
            this.destinoCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.destinoCheckBox);
            this.Controls.Add(this.copiaButton);
            this.Controls.Add(this.rgbLabel);
            this.Controls.Add(this.pixelLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.yTrackBar);
            this.Controls.Add(this.xTrackBar);
            this.Controls.Add(this.rgbPanel);
            this.Controls.Add(this.bPanel);
            this.Controls.Add(this.gPanel);
            this.Controls.Add(this.rPanel);
            this.Controls.Add(this.destinoPictureBox);
            this.Controls.Add(this.origemPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.origemPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTrackBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox origemPictureBox;
        private System.Windows.Forms.PictureBox destinoPictureBox;
        private System.Windows.Forms.Panel rPanel;
        private System.Windows.Forms.Panel gPanel;
        private System.Windows.Forms.Panel bPanel;
        private System.Windows.Forms.Panel rgbPanel;
        private System.Windows.Forms.TrackBar xTrackBar;
        private System.Windows.Forms.TrackBar yTrackBar;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label pixelLabel;
        private System.Windows.Forms.Label rgbLabel;
        private System.Windows.Forms.Button copiaButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalasDeCinzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luminosityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem efeitosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espelhamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.CheckBox destinoCheckBox;
    }
}

