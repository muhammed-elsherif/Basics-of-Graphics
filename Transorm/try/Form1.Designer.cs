namespace @try
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.WidthTrackBar = new System.Windows.Forms.TrackBar();
            this.WidthTrackBarLabel = new System.Windows.Forms.Label();
            this.UploadButton = new System.Windows.Forms.Button();
            this.HeightTrackBar = new System.Windows.Forms.TrackBar();
            this.HeightTrackBarLabel = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.Label();
            this.RotationTrackBar = new System.Windows.Forms.TrackBar();
            this.RotationAngelLabel = new System.Windows.Forms.Label();
            this.Rotation = new System.Windows.Forms.Label();
            this.translationLabel = new System.Windows.Forms.Label();
            this.translationPixel = new System.Windows.Forms.Label();
            this.xTrackBar = new System.Windows.Forms.TrackBar();
            this.yTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reflectionLabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.WidthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WidthTrackBar
            // 
            this.WidthTrackBar.BackColor = System.Drawing.Color.Brown;
            this.WidthTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WidthTrackBar.LargeChange = 10;
            this.WidthTrackBar.Location = new System.Drawing.Point(1362, 224);
            this.WidthTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.WidthTrackBar.Maximum = 200;
            this.WidthTrackBar.Name = "WidthTrackBar";
            this.WidthTrackBar.Size = new System.Drawing.Size(468, 56);
            this.WidthTrackBar.TabIndex = 0;
            this.WidthTrackBar.TickFrequency = 20;
            this.WidthTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.WidthTrackBar.Value = 100;
            this.WidthTrackBar.Scroll += new System.EventHandler(this.WidthTrackBar_Scroll);
            // 
            // WidthTrackBarLabel
            // 
            this.WidthTrackBarLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WidthTrackBarLabel.AutoSize = true;
            this.WidthTrackBarLabel.BackColor = System.Drawing.Color.LightCoral;
            this.WidthTrackBarLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WidthTrackBarLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthTrackBarLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WidthTrackBarLabel.Location = new System.Drawing.Point(1523, 295);
            this.WidthTrackBarLabel.Margin = new System.Windows.Forms.Padding(0);
            this.WidthTrackBarLabel.MaximumSize = new System.Drawing.Size(159, 43);
            this.WidthTrackBarLabel.MinimumSize = new System.Drawing.Size(159, 43);
            this.WidthTrackBarLabel.Name = "WidthTrackBarLabel";
            this.WidthTrackBarLabel.Size = new System.Drawing.Size(159, 43);
            this.WidthTrackBarLabel.TabIndex = 2;
            this.WidthTrackBarLabel.Text = "Value: 100%";
            this.WidthTrackBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WidthTrackBarLabel.Click += new System.EventHandler(this.WidthTrackBarLabel_Click);
            // 
            // UploadButton
            // 
            this.UploadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UploadButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.UploadButton.FlatAppearance.BorderSize = 3;
            this.UploadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.UploadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.UploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadButton.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadButton.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.UploadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UploadButton.Location = new System.Drawing.Point(750, 33);
            this.UploadButton.Margin = new System.Windows.Forms.Padding(4);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UploadButton.Size = new System.Drawing.Size(288, 58);
            this.UploadButton.TabIndex = 1;
            this.UploadButton.Text = "Upload";
            this.UploadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // HeightTrackBar
            // 
            this.HeightTrackBar.BackColor = System.Drawing.Color.Chocolate;
            this.HeightTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HeightTrackBar.LargeChange = 10;
            this.HeightTrackBar.Location = new System.Drawing.Point(1362, 513);
            this.HeightTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.HeightTrackBar.Maximum = 200;
            this.HeightTrackBar.Name = "HeightTrackBar";
            this.HeightTrackBar.Size = new System.Drawing.Size(468, 56);
            this.HeightTrackBar.TabIndex = 3;
            this.HeightTrackBar.TickFrequency = 20;
            this.HeightTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.HeightTrackBar.Value = 100;
            this.HeightTrackBar.Scroll += new System.EventHandler(this.HeightTrackBar_Scroll);
            // 
            // HeightTrackBarLabel
            // 
            this.HeightTrackBarLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightTrackBarLabel.AutoSize = true;
            this.HeightTrackBarLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.HeightTrackBarLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeightTrackBarLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightTrackBarLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HeightTrackBarLabel.Location = new System.Drawing.Point(1523, 587);
            this.HeightTrackBarLabel.Margin = new System.Windows.Forms.Padding(0);
            this.HeightTrackBarLabel.MaximumSize = new System.Drawing.Size(159, 43);
            this.HeightTrackBarLabel.MinimumSize = new System.Drawing.Size(159, 43);
            this.HeightTrackBarLabel.Name = "HeightTrackBarLabel";
            this.HeightTrackBarLabel.Size = new System.Drawing.Size(159, 43);
            this.HeightTrackBarLabel.TabIndex = 4;
            this.HeightTrackBarLabel.Text = "Value: 100%";
            this.HeightTrackBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Width
            // 
            this.Width.AutoSize = true;
            this.Width.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Width.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Width.Location = new System.Drawing.Point(1540, 169);
            this.Width.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Width.MinimumSize = new System.Drawing.Size(111, 38);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(111, 38);
            this.Width.TabIndex = 5;
            this.Width.Text = "Width";
            this.Width.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Height.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Height.Location = new System.Drawing.Point(1540, 459);
            this.Height.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Height.MinimumSize = new System.Drawing.Size(111, 38);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(111, 38);
            this.Height.TabIndex = 6;
            this.Height.Text = "Height";
            this.Height.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RotationTrackBar
            // 
            this.RotationTrackBar.BackColor = System.Drawing.Color.DarkGreen;
            this.RotationTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RotationTrackBar.LargeChange = 30;
            this.RotationTrackBar.Location = new System.Drawing.Point(13, 197);
            this.RotationTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.RotationTrackBar.Maximum = 360;
            this.RotationTrackBar.Name = "RotationTrackBar";
            this.RotationTrackBar.Size = new System.Drawing.Size(465, 56);
            this.RotationTrackBar.TabIndex = 0;
            this.RotationTrackBar.TickFrequency = 30;
            this.RotationTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.RotationTrackBar.Scroll += new System.EventHandler(this.RotationTrackBar_Scroll);
            // 
            // RotationAngelLabel
            // 
            this.RotationAngelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RotationAngelLabel.AutoSize = true;
            this.RotationAngelLabel.BackColor = System.Drawing.Color.LightGreen;
            this.RotationAngelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RotationAngelLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotationAngelLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RotationAngelLabel.Location = new System.Drawing.Point(145, 269);
            this.RotationAngelLabel.Margin = new System.Windows.Forms.Padding(0);
            this.RotationAngelLabel.MaximumSize = new System.Drawing.Size(213, 43);
            this.RotationAngelLabel.MinimumSize = new System.Drawing.Size(213, 43);
            this.RotationAngelLabel.Name = "RotationAngelLabel";
            this.RotationAngelLabel.Size = new System.Drawing.Size(213, 43);
            this.RotationAngelLabel.TabIndex = 8;
            this.RotationAngelLabel.Text = "Rotation Angle: 0 °";
            this.RotationAngelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rotation
            // 
            this.Rotation.AutoSize = true;
            this.Rotation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rotation.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rotation.Location = new System.Drawing.Point(181, 146);
            this.Rotation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rotation.MinimumSize = new System.Drawing.Size(111, 38);
            this.Rotation.Name = "Rotation";
            this.Rotation.Size = new System.Drawing.Size(129, 38);
            this.Rotation.TabIndex = 9;
            this.Rotation.Text = "Rotation";
            this.Rotation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // translationLabel
            // 
            this.translationLabel.AutoSize = true;
            this.translationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translationLabel.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationLabel.Location = new System.Drawing.Point(142, 387);
            this.translationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.translationLabel.MinimumSize = new System.Drawing.Size(111, 38);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(168, 38);
            this.translationLabel.TabIndex = 12;
            this.translationLabel.Text = "Translation";
            this.translationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.translationLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // translationPixel
            // 
            this.translationPixel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.translationPixel.AutoSize = true;
            this.translationPixel.BackColor = System.Drawing.Color.LightGreen;
            this.translationPixel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translationPixel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationPixel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.translationPixel.Location = new System.Drawing.Point(142, 587);
            this.translationPixel.Margin = new System.Windows.Forms.Padding(0);
            this.translationPixel.MaximumSize = new System.Drawing.Size(213, 43);
            this.translationPixel.MinimumSize = new System.Drawing.Size(213, 43);
            this.translationPixel.Name = "translationPixel";
            this.translationPixel.Size = new System.Drawing.Size(213, 43);
            this.translationPixel.TabIndex = 11;
            this.translationPixel.Text = "Translation: 0 pixel";
            this.translationPixel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.translationPixel.Click += new System.EventHandler(this.label2_Click);
            // 
            // xTrackBar
            // 
            this.xTrackBar.BackColor = System.Drawing.Color.DarkGreen;
            this.xTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xTrackBar.LargeChange = 30;
            this.xTrackBar.Location = new System.Drawing.Point(55, 441);
            this.xTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.xTrackBar.Maximum = 700;
            this.xTrackBar.Name = "xTrackBar";
            this.xTrackBar.Size = new System.Drawing.Size(465, 56);
            this.xTrackBar.TabIndex = 0;
            this.xTrackBar.TickFrequency = 30;
            this.xTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.xTrackBar.Scroll += new System.EventHandler(this.TranslationTrackBar_Scroll);
            // 
            // yTrackBar
            // 
            this.yTrackBar.BackColor = System.Drawing.Color.DarkGreen;
            this.yTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yTrackBar.LargeChange = 30;
            this.yTrackBar.Location = new System.Drawing.Point(55, 513);
            this.yTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.yTrackBar.Maximum = 700;
            this.yTrackBar.Name = "yTrackBar";
            this.yTrackBar.Size = new System.Drawing.Size(465, 56);
            this.yTrackBar.TabIndex = 13;
            this.yTrackBar.TickFrequency = 30;
            this.yTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.yTrackBar.Scroll += new System.EventHandler(this.TranslationTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Y";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox.InitialImage = global::@try.Properties.Resources.uploadImage1;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(766, 586);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.WaitOnLoad = true;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(557, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 586);
            this.panel1.TabIndex = 16;
            // 
            // reflectionLabel
            // 
            this.reflectionLabel.AutoSize = true;
            this.reflectionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reflectionLabel.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel.Location = new System.Drawing.Point(15, 667);
            this.reflectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reflectionLabel.MinimumSize = new System.Drawing.Size(111, 38);
            this.reflectionLabel.Name = "reflectionLabel";
            this.reflectionLabel.Size = new System.Drawing.Size(153, 38);
            this.reflectionLabel.TabIndex = 17;
            this.reflectionLabel.Text = "Reflection";
            this.reflectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(255, 687);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 20);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ON";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.ReflectRadioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(395, 687);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 20);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "OFF";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::@try.Properties.Resources.desktop_wallpaper_landscape_minimalist;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1881, 781);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.reflectionLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yTrackBar);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.translationPixel);
            this.Controls.Add(this.xTrackBar);
            this.Controls.Add(this.Rotation);
            this.Controls.Add(this.RotationAngelLabel);
            this.Controls.Add(this.RotationTrackBar);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.HeightTrackBarLabel);
            this.Controls.Add(this.HeightTrackBar);
            this.Controls.Add(this.WidthTrackBarLabel);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.WidthTrackBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transformations";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WidthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar WidthTrackBar;
        private System.Windows.Forms.Label WidthTrackBarLabel;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.TrackBar HeightTrackBar;
        private System.Windows.Forms.Label HeightTrackBarLabel;
        private System.Windows.Forms.Label Width;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.TrackBar RotationTrackBar;
        private System.Windows.Forms.Label RotationAngelLabel;
        private System.Windows.Forms.Label Rotation;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.Label translationPixel;
        private System.Windows.Forms.TrackBar xTrackBar;
        private System.Windows.Forms.TrackBar yTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label reflectionLabel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

