using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Graphics
{
    public partial class Line_drawing : Form
    {
        List<Tuple<int, int>> points = new List<Tuple<int, int>>();
        List<Tuple<float, float>> pointsE = new List<Tuple<float, float>>();
        public Line_drawing()
        {
            InitializeComponent();
        }
        private void lineDDA(int x0, int y0, int x1, int y1)
        {
            SolidBrush mySolidBrush = new SolidBrush(Color.Black);
            var draw = panel.CreateGraphics();
            points.Clear();
            int dx = x1 - x0, dy = y1 - y0, steps, k;
            float xIncrement, yIncrement, x = x0, y = y0;
            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xIncrement = (float)dx / (float)steps;
            yIncrement = (float)dy / (float)steps;
            points.Add(new Tuple<int, int>(round(x), round(y)));
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                points.Add(new Tuple<int, int>(round(x), round(y)));
                draw.FillRectangle(mySolidBrush, x + (panel.Width / 2), (panel.Height) / 2 - y, 2, 2);
            }
        }

        int round(float a)
        {
            return (int)(a + 0.5);
        }
        private void lineBres(int x0, int y0, int x1, int y1)
        {
            points.Clear();
            SolidBrush mySolidBrush = new SolidBrush(Color.Aquamarine);

            
            var draw = panel.CreateGraphics();
            int dx = Math.Abs(x1 - x0), dy = Math.Abs(y1 - y0);
            int x, y, p = 2 * dy - dx;
            int twoDy = 2 * dy, twoDyMinusDx = 2 * (dy - dx);
            if (x0 > x1)
            {
                x = x1; y = y1;
                x1 = x0;
            }
            else
            {
                x = x0; y = y0;
            }
            points.Add(new Tuple<int, int>(x, y));
            while (x < x1)
            {
                x++;
                if (p < 0)
                    p += twoDy;
                else
                {
                    y++;
                    p += twoDyMinusDx;
                }
                points.Add(new Tuple<int, int>(x, y));
                draw.FillRectangle(mySolidBrush, x + (panel.Width / 2), (panel.Height) / 2 - y, 2, 2);
            }
        }

        private void PlotCircle(int xCenter, int yCenter, int radius)
        {
            points.Clear();
            SolidBrush mySolidBrush = new SolidBrush(Color.Blue);
            var draw = panel.CreateGraphics();
            int x = 0;
            int y = radius;
            int d = 3 - (2 * radius);

            while (x <= y)
            {
                points.Add(new Tuple<int, int>(xCenter + x, yCenter + y));
                points.Add(new Tuple<int, int>(xCenter - x, yCenter + y));
                points.Add(new Tuple<int, int>(xCenter + x, yCenter - y));
                points.Add(new Tuple<int, int>(xCenter - x, yCenter - y));
                points.Add(new Tuple<int, int>(xCenter + y, yCenter + x));
                points.Add(new Tuple<int, int>(xCenter - y, yCenter + x));
                points.Add(new Tuple<int, int>(xCenter + y, yCenter - x));
                points.Add(new Tuple<int, int>(xCenter - y, yCenter - x));
                
                if (d < 0)
                {
                    d += 4 * x + 6;
                }
                else
                {
                    d += 4 * (x - y) + 10;
                    y -= 1;
                }
                x++;
            }

            // Draw the circle points
            foreach (var point in points)
            {
                draw.FillRectangle(mySolidBrush, point.Item1 + (panel.Width / 2), (panel.Height) / 2 - point.Item2, 2, 2);
            }
        }

        private void PlotEllipse(int xCenter, int yCenter, int xRadius, int yRadius)
        {
            points.Clear();
            SolidBrush mySolidBrush = new SolidBrush(Color.Black);
            var draw = panel.CreateGraphics();
            float x = 0;
            float y = yRadius;
            double d1 = (yRadius * yRadius) - (xRadius * xRadius * yRadius) + (0.25 * xRadius * xRadius);
            double dx = 2 * yRadius * yRadius * x;
            double dy = 2 * xRadius * xRadius * y;

            while (dx < dy)
            {
                pointsE.Add(new Tuple<float, float>(xCenter + x, yCenter + y));
                pointsE.Add(new Tuple<float, float>(xCenter - x, yCenter + y));
                pointsE.Add(new Tuple<float, float>(xCenter + x, yCenter - y));
                pointsE.Add(new Tuple<float, float>(xCenter - x, yCenter - y));

                if (d1 < 0)
                {
                    x++;
                    dx += 2 * yRadius * yRadius;
                    d1 += dx + (yRadius * yRadius);
                }
                else
                {
                    x++;
                    y--;
                    dx += 2 * yRadius * yRadius;
                    dy -= 2 * xRadius * xRadius;
                    d1 += dx - dy + (yRadius * yRadius);
                }
            }

            double d2 = ((yRadius * yRadius) * ((x + 0.5) * (x + 0.5))) +
                        ((xRadius * xRadius) * ((y - 1) * (y - 1))) -
                        (xRadius * xRadius * yRadius * yRadius);
            while (y >= 0)
            {
                pointsE.Add(new Tuple<float, float>(xCenter + x, yCenter + y));
                pointsE.Add(new Tuple<float, float>(xCenter - x, yCenter + y));
                pointsE.Add(new Tuple<float, float>(xCenter + x, yCenter - y));
                pointsE.Add(new Tuple<float, float>(xCenter - x, yCenter - y));

                if (d2 > 0)
                {
                    y--;
                    dy -= 2 * xRadius * xRadius;
                    d2 += (xRadius * xRadius) - dy;
                }
                else
                {
                    y--;
                    x++;
                    dx += 2 * yRadius * yRadius;
                    dy -= 2 * xRadius * xRadius;
                    d2 += dx - dy + (xRadius * xRadius);
                }
            }

            // Draw the ellipse points
            foreach (var point in pointsE)
            {
                draw.FillRectangle(mySolidBrush, point.Item1 + (panel.Width / 2), (panel.Height) / 2 - point.Item2, 2, 2);
            }
        }



        private void Draw_Click(object sender, EventArgs e)
        {
            int x1, x2, y1, y2;
            x1 = int.Parse(X1.Text); 
            y1 = int.Parse(Y1.Text);
            x2 = int.Parse(X2.Text);
            y2 = int.Parse(Y2.Text);

            lineDDA(x1, y1, x2, y2);
        }
        private void Drw_Bresenham_Click(object sender, EventArgs e)
        {
            int x1, x2, y1, y2;
            x1 = int.Parse(X1.Text); 
            y1 = int.Parse(Y1.Text);
            x2 = int.Parse(X2.Text);
            y2 = int.Parse(Y2.Text);

            lineBres(x1, y1, x2, y2);
        }

        private void Drw_Circle_Click(object sender, EventArgs e)
        {
            int x_center, y_center, radius;
            x_center = int.Parse(xCenter.Text);
            y_center = int.Parse(yCenter.Text);
            radius = int.Parse(Radius.Text);

            PlotCircle(x_center, y_center, radius);
        }
        
        private void Drw_Elipse_Click(object sender, EventArgs e)
        {
            int x_center, y_center, x_radius, y_radius;
            x_center = int.Parse(xCenterE.Text);
            y_center = int.Parse(yCenterE.Text);
            x_radius = int.Parse(xRadiusE.Text);
            y_radius = int.Parse(yRadiusE.Text);

            PlotEllipse(x_center, y_center, x_radius, y_radius);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            X1.Clear();
            Y1.Clear();
            X2.Clear();
            Y2.Clear();
            xCenter.Clear();
            yCenter.Clear();
            Radius.Clear();
            xCenterE.Clear();
            yCenterE.Clear();
            xRadiusE.Clear();
            yRadiusE.Clear();
            panel.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void X1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Y1_TextChanged(object sender, EventArgs e)
        {

        }

        private void X2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Y2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowDataTable(DataTable table)
        {
            DataGridView dataGridView = new DataGridView();
            dataGridView.DataSource = table;
            Form form = new Form();
            form.Text = "Circle Drawing Steps";
            form.Controls.Add(dataGridView);
            dataGridView.Dock = DockStyle.Fill;
            form.ShowDialog();
        }

        private void showResult_Click(object sender, EventArgs e)
        {
            // Check if points were generated from PlotCircle
            bool isCircle = points.Any() && points.All(p => p.Item1 != 0 && p.Item2 != 0);
            int k = 0, counter = 0;

            if (isCircle)
            {
                // Create a DataTable to store the values
                DataTable table = new DataTable();
                table.Columns.Add("k", typeof(int));
                //table.Columns.Add("d", typeof(int));
                table.Columns.Add("(x_k+1, y_k+1)", typeof(string));
                table.Columns.Add("2x_k+1", typeof(int));
                table.Columns.Add("2y_k+1", typeof(int));

                foreach (var pair in points)
                {
                    if (counter % 8 == 0)
                    {
                        table.Rows.Add(k++, $"({pair.Item1}, {pair.Item2})", 2 * (pair.Item1), 2 * (pair.Item2));
                    }
                    counter++;
                }

                ShowDataTable(table);
            }
            else
            {
                StringBuilder message = new StringBuilder();
                if (pointsE.Any())
                {
                    foreach (var pair in pointsE)
                    {
                        message.AppendLine($"({pair.Item1}, {pair.Item2})");
                    }
                }
                else
                {
                    foreach (var pair in points)
                    {
                        message.AppendLine($"({pair.Item1}, {pair.Item2})");
                    }
                }
                RichTextBox richTextBox = new RichTextBox();
                richTextBox.Text = message.ToString();
                richTextBox.Dock = DockStyle.Fill;
                richTextBox.ReadOnly = true;
                richTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
                Form form = new Form();
                form.Text = "Line Points";
                form.Controls.Add(richTextBox);
                form.ShowDialog();
            }

            points.Clear();            
        }
    }
}
