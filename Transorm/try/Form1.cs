using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace @try
{
    public partial class MainForm : Form
    {
        System.Drawing.Image originalImage;
        System.Drawing.Image tempImage;
        int tickValue;
        Bitmap rotatedImage;
        Bitmap translatedImage;
        public MainForm()
        {
            InitializeComponent();
            tempImage = new Bitmap("E:\\Mohamed Mostafa\\55555.jpg");
            pictureBox.Image = tempImage;
            originalImage = tempImage;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Load the uploaded image
                    originalImage = System.Drawing.Image.FromFile(dlg.FileName);

                    // Reset the track bars
                    WidthTrackBar.Value = 100;
                    HeightTrackBar.Value = 100;
                    xTrackBar.Value = xTrackBar.Minimum;
                    yTrackBar.Value = yTrackBar.Minimum;
                    RotationTrackBar.Value = RotationTrackBar.Minimum;

                    WidthTrackBarLabel.Text = "Value: " + WidthTrackBar.Value + "%";
                    HeightTrackBarLabel.Text = "Value: " + HeightTrackBar.Value + "%";
                    translationPixel.Text = "Translation: " + xTrackBar.Value + "pixel";
                    RotationAngelLabel.Text = "Rotation Angle: " + RotationTrackBar.Minimum + "°";

                    pictureBox.Size = new Size((Point)panel1.Size);
                    pictureBox.Image = originalImage;
                }
            }

        }

        private void WidthTrackBar_Scroll(object sender, EventArgs e)
        {
            tickValue = WidthTrackBar.Value;
            WidthTrackBarLabel.Text = "Value: " + (tickValue).ToString() + "%";
            if (tickValue != 0 && originalImage != null)
            {
                float scaleFactor = WidthTrackBar.Value / 100.0f;

                int newWidth = (int)(originalImage.Width * scaleFactor);
                pictureBox.Width = newWidth;
            }
        }
        private void HeightTrackBar_Scroll(object sender, EventArgs e)
        {
            tickValue = HeightTrackBar.Value;
            HeightTrackBarLabel.Text = "Value: " + (tickValue).ToString() + "%";
            if (tickValue != 0 && originalImage != null)
            {
                float scaleFactor = HeightTrackBar.Value / 100.0f;

                int newHeight = (int)(originalImage.Height * scaleFactor);
                pictureBox.Height = newHeight;
            }
        }

        private void WidthTrackBarLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void shearing(Object sender, EventArgs e)
        {
            this.CreateGraphics().FillRectangle(Brushes.White, 0, 0, 10000, 10000);

            #region 1- Initialize
            Point[] Object = new Point[4];
            Point[] newObject = new Point[4];
            Object[0] = new Point(100, 100);
            Object[1] = new Point(200, 100);
            Object[2] = new Point(200, 200);
            Object[3] = new Point(100, 200);

            this.CreateGraphics().DrawPolygon(new Pen(Color.Red, 3), Object);
            #endregion

            #region 2- Do X-Shear
            float shx = 2f;
            for (int i = 0; i < Object.Length; i++)
            {
                newObject[i].X = Object[i].X + (int)(shx * Object[i].Y);
                newObject[i].Y = Object[i].Y;
            }
            this.CreateGraphics().DrawPolygon(new Pen(Color.Blue, 3), Object);
            #endregion

            #region 3- Do y-Shear
            float shY = 2f;
            for (int i = 0; i < Object.Length; i++)
            {
                newObject[i].Y = Object[i].Y + (int)(shY * Object[i].X);
                newObject[i].X = Object[i].X;
            }
            this.CreateGraphics().DrawPolygon(new Pen(Color.Green, 3), Object);
            #endregion
        }

        private void RotationTrackBar_Scroll(object sender, EventArgs e)
        {
            float rotationAngle = RotationTrackBar.Value;
            RotationAngelLabel.Text = "Rotation Angle: " + rotationAngle + "°";
            if (originalImage != null)
            {
                rotatedImage = RotateImage(originalImage, (int)rotationAngle);

                pictureBox.Image = rotatedImage;
            }
        }
        private void TranslationTrackBar_Scroll(object sender, EventArgs e)
        {
            float xTranslation = xTrackBar.Value;
            float yTranslation = yTrackBar.Value;
            translationPixel.Text = "Translation: " + xTranslation + "pixel";
            if (originalImage != null)
            {
                translatedImage = TranslateImage(originalImage, (int)xTranslation, (int)yTranslation);

                pictureBox.Image = translatedImage;
            }
        }

        private void ReflectRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                pictureBox.Image = ReflectImage(originalImage);
            }
            else
            {
                pictureBox.Image = originalImage;
            }
        }

        private Bitmap RotateImage(System.Drawing.Image image, int angle)
        {
            Bitmap rotatedBitmap = new Bitmap(image.Width, image.Height);
            rotatedBitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedBitmap))
            {
                // Set the rotation point in the center of the image
                g.TranslateTransform(image.Width / 2, image.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-image.Width / 2, -image.Height / 2);

                g.DrawImage(image, new Point(0, 0));
            }

            return rotatedBitmap;
        }
        
        private Bitmap TranslateImage(System.Drawing.Image image, int offsetX, int offsetY)
        {
            Bitmap translatedBitmap = new Bitmap(image.Width, image.Height);
            translatedBitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics g = Graphics.FromImage(translatedBitmap))
            {
                // Translate the image by the specified offset
                g.TranslateTransform(offsetX, offsetY);

                g.DrawImage(image, new Point(0, 0));
            }

            return translatedBitmap;
        }

        private Bitmap ReflectImage(System.Drawing.Image image)
        {
            Bitmap reflectedBitmap = new Bitmap(image.Width, image.Height);
            reflectedBitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics g = Graphics.FromImage(reflectedBitmap))
            {
                // Flip the image horizontally
                g.TranslateTransform(image.Width, 0);
                g.ScaleTransform(-1, 1);

                g.DrawImage(image, new Point(0, 0));
            }

            return reflectedBitmap;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}