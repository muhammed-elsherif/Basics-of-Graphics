namespace Graphics
{
    partial class Line_drawing
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.X2 = new System.Windows.Forms.TextBox();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Draw_dda = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Drw_Bresenham = new System.Windows.Forms.Button();
            this.showResult = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.X1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yCenter = new System.Windows.Forms.TextBox();
            this.Radius = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.xCenter = new System.Windows.Forms.TextBox();
            this.Drw_Circle = new System.Windows.Forms.Button();
            this.Drw_Elipse = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.xCenterE = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.yCenterE = new System.Windows.Forms.TextBox();
            this.xRadiusE = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.yRadiusE = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "X2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Y2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Enter point2";
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(159, 155);
            this.X2.Margin = new System.Windows.Forms.Padding(4);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(76, 22);
            this.X2.TabIndex = 20;
            this.X2.TextChanged += new System.EventHandler(this.X2_TextChanged);
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(304, 155);
            this.Y2.Margin = new System.Windows.Forms.Padding(4);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(76, 22);
            this.Y2.TabIndex = 19;
            this.Y2.TextChanged += new System.EventHandler(this.Y2_TextChanged);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(144)))));
            this.panel.Controls.Add(this.panel1);
            this.panel.Location = new System.Drawing.Point(540, 37);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(600, 554);
            this.panel.TabIndex = 15;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(300, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 554);
            this.panel1.TabIndex = 32;
            // 
            // Draw_dda
            // 
            this.Draw_dda.Location = new System.Drawing.Point(40, 215);
            this.Draw_dda.Margin = new System.Windows.Forms.Padding(4);
            this.Draw_dda.Name = "Draw_dda";
            this.Draw_dda.Size = new System.Drawing.Size(219, 28);
            this.Draw_dda.TabIndex = 28;
            this.Draw_dda.Text = "Draw lline with DDA";
            this.Draw_dda.UseVisualStyleBackColor = true;
            this.Draw_dda.Click += new System.EventHandler(this.Draw_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(40, 565);
            this.Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(219, 28);
            this.Clear.TabIndex = 29;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Drw_Bresenham
            // 
            this.Drw_Bresenham.Location = new System.Drawing.Point(272, 215);
            this.Drw_Bresenham.Margin = new System.Windows.Forms.Padding(4);
            this.Drw_Bresenham.Name = "Drw_Bresenham";
            this.Drw_Bresenham.Size = new System.Drawing.Size(219, 28);
            this.Drw_Bresenham.TabIndex = 30;
            this.Drw_Bresenham.Text = "Draw lline with Bresenham";
            this.Drw_Bresenham.UseVisualStyleBackColor = true;
            this.Drw_Bresenham.Click += new System.EventHandler(this.Drw_Bresenham_Click);
            // 
            // showResult
            // 
            this.showResult.Location = new System.Drawing.Point(272, 565);
            this.showResult.Margin = new System.Windows.Forms.Padding(4);
            this.showResult.Name = "showResult";
            this.showResult.Size = new System.Drawing.Size(219, 28);
            this.showResult.TabIndex = 31;
            this.showResult.Text = "Show result";
            this.showResult.UseVisualStyleBackColor = true;
            this.showResult.Click += new System.EventHandler(this.showResult_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(540, 314);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 1);
            this.panel2.TabIndex = 33;
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(304, 65);
            this.Y1.Margin = new System.Windows.Forms.Padding(4);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(76, 22);
            this.Y1.TabIndex = 18;
            this.Y1.TextChanged += new System.EventHandler(this.Y1_TextChanged);
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(157, 65);
            this.X1.Margin = new System.Windows.Forms.Padding(4);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(77, 22);
            this.X1.TabIndex = 21;
            this.X1.TextChanged += new System.EventHandler(this.X1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Enter point1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Y1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "X1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Y_Center";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Radius";
            // 
            // yCenter
            // 
            this.yCenter.Location = new System.Drawing.Point(181, 293);
            this.yCenter.Margin = new System.Windows.Forms.Padding(4);
            this.yCenter.Name = "yCenter";
            this.yCenter.Size = new System.Drawing.Size(77, 22);
            this.yCenter.TabIndex = 35;
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(326, 293);
            this.Radius.Margin = new System.Windows.Forms.Padding(4);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(76, 22);
            this.Radius.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 265);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "X_Center";
            // 
            // xCenter
            // 
            this.xCenter.Location = new System.Drawing.Point(35, 293);
            this.xCenter.Margin = new System.Windows.Forms.Padding(4);
            this.xCenter.Name = "xCenter";
            this.xCenter.Size = new System.Drawing.Size(77, 22);
            this.xCenter.TabIndex = 39;
            // 
            // Drw_Circle
            // 
            this.Drw_Circle.Location = new System.Drawing.Point(103, 347);
            this.Drw_Circle.Margin = new System.Windows.Forms.Padding(4);
            this.Drw_Circle.Name = "Drw_Circle";
            this.Drw_Circle.Size = new System.Drawing.Size(219, 28);
            this.Drw_Circle.TabIndex = 41;
            this.Drw_Circle.Text = "Draw Circle with Bresenham";
            this.Drw_Circle.UseVisualStyleBackColor = true;
            this.Drw_Circle.Click += new System.EventHandler(this.Drw_Circle_Click);
            // 
            // Drw_Elipse
            // 
            this.Drw_Elipse.Location = new System.Drawing.Point(99, 479);
            this.Drw_Elipse.Margin = new System.Windows.Forms.Padding(4);
            this.Drw_Elipse.Name = "Drw_Elipse";
            this.Drw_Elipse.Size = new System.Drawing.Size(219, 28);
            this.Drw_Elipse.TabIndex = 48;
            this.Drw_Elipse.Text = "Draw Elipse";
            this.Drw_Elipse.UseVisualStyleBackColor = true;
            this.Drw_Elipse.Click += new System.EventHandler(this.Drw_Elipse_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 407);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "X_Center";
            // 
            // xCenterE
            // 
            this.xCenterE.Location = new System.Drawing.Point(12, 435);
            this.xCenterE.Margin = new System.Windows.Forms.Padding(4);
            this.xCenterE.Name = "xCenterE";
            this.xCenterE.Size = new System.Drawing.Size(77, 22);
            this.xCenterE.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 407);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "Y_Center";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(299, 407);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 44;
            this.label12.Text = "X_Radius";
            // 
            // yCenterE
            // 
            this.yCenterE.Location = new System.Drawing.Point(158, 435);
            this.yCenterE.Margin = new System.Windows.Forms.Padding(4);
            this.yCenterE.Name = "yCenterE";
            this.yCenterE.Size = new System.Drawing.Size(77, 22);
            this.yCenterE.TabIndex = 43;
            // 
            // xRadiusE
            // 
            this.xRadiusE.Location = new System.Drawing.Point(303, 435);
            this.xRadiusE.Margin = new System.Windows.Forms.Padding(4);
            this.xRadiusE.Name = "xRadiusE";
            this.xRadiusE.Size = new System.Drawing.Size(76, 22);
            this.xRadiusE.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(428, 407);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 16);
            this.label13.TabIndex = 50;
            this.label13.Text = "Y_Radius";
            // 
            // yRadiusE
            // 
            this.yRadiusE.Location = new System.Drawing.Point(432, 435);
            this.yRadiusE.Margin = new System.Windows.Forms.Padding(4);
            this.yRadiusE.Name = "yRadiusE";
            this.yRadiusE.Size = new System.Drawing.Size(76, 22);
            this.yRadiusE.TabIndex = 49;
            // 
            // Line_drawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 634);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.yRadiusE);
            this.Controls.Add(this.Drw_Elipse);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.xCenterE);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.yCenterE);
            this.Controls.Add(this.xRadiusE);
            this.Controls.Add(this.Drw_Circle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.xCenter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yCenter);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.showResult);
            this.Controls.Add(this.Drw_Bresenham);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Draw_dda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Line_drawing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Line drawing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button Draw_dda;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Drw_Bresenham;
        private System.Windows.Forms.Button showResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yCenter;
        private System.Windows.Forms.TextBox Radius;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox xCenter;
        private System.Windows.Forms.Button Drw_Circle;
        private System.Windows.Forms.Button Drw_Elipse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox xCenterE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox yCenterE;
        private System.Windows.Forms.TextBox xRadiusE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox yRadiusE;
    }
}

