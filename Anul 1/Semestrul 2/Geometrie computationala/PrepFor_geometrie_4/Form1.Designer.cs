namespace PrepFor_geometrie_4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.drawAxis = new System.Windows.Forms.Button();
            this.btn_drawRandom = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_addPoint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.canvasImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selectNmbPoints = new System.Windows.Forms.NumericUpDown();
            this.genPointsByNmb = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasImage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectNmbPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.drawAxis);
            this.panel1.Controls.Add(this.btn_drawRandom);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_addPoint);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Location = new System.Drawing.Point(44, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 243);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Basics";
            // 
            // drawAxis
            // 
            this.drawAxis.Location = new System.Drawing.Point(10, 148);
            this.drawAxis.Name = "drawAxis";
            this.drawAxis.Size = new System.Drawing.Size(75, 23);
            this.drawAxis.TabIndex = 8;
            this.drawAxis.Text = "Draw Axis";
            this.drawAxis.UseVisualStyleBackColor = true;
            this.drawAxis.Click += new System.EventHandler(this.drawAxis_Click);
            // 
            // btn_drawRandom
            // 
            this.btn_drawRandom.Location = new System.Drawing.Point(11, 107);
            this.btn_drawRandom.Name = "btn_drawRandom";
            this.btn_drawRandom.Size = new System.Drawing.Size(75, 35);
            this.btn_drawRandom.TabIndex = 7;
            this.btn_drawRandom.Text = "Draw Squares";
            this.btn_drawRandom.UseVisualStyleBackColor = true;
            this.btn_drawRandom.Click += new System.EventHandler(this.btn_drawRandom_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Draw lines";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_addPoint
            // 
            this.btn_addPoint.Location = new System.Drawing.Point(10, 47);
            this.btn_addPoint.Name = "btn_addPoint";
            this.btn_addPoint.Size = new System.Drawing.Size(75, 23);
            this.btn_addPoint.TabIndex = 5;
            this.btn_addPoint.Text = "Add Points";
            this.btn_addPoint.UseVisualStyleBackColor = true;
            this.btn_addPoint.Click += new System.EventHandler(this.btn_addPoint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(10, 214);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(10, 185);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // canvasImage
            // 
            this.canvasImage.Location = new System.Drawing.Point(265, 35);
            this.canvasImage.Name = "canvasImage";
            this.canvasImage.Size = new System.Drawing.Size(801, 558);
            this.canvasImage.TabIndex = 1;
            this.canvasImage.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.selectNmbPoints);
            this.panel2.Controls.Add(this.genPointsByNmb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(44, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 307);
            this.panel2.TabIndex = 2;
            // 
            // selectNmbPoints
            // 
            this.selectNmbPoints.Location = new System.Drawing.Point(14, 66);
            this.selectNmbPoints.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.selectNmbPoints.Name = "selectNmbPoints";
            this.selectNmbPoints.Size = new System.Drawing.Size(120, 20);
            this.selectNmbPoints.TabIndex = 2;
            this.selectNmbPoints.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // genPointsByNmb
            // 
            this.genPointsByNmb.Location = new System.Drawing.Point(14, 92);
            this.genPointsByNmb.Name = "genPointsByNmb";
            this.genPointsByNmb.Size = new System.Drawing.Size(114, 23);
            this.genPointsByNmb.TabIndex = 1;
            this.genPointsByNmb.Text = "Generate points";
            this.genPointsByNmb.UseVisualStyleBackColor = true;
            this.genPointsByNmb.Click += new System.EventHandler(this.genPointsByNmb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Invelitoare convexa";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(37, 212);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1105, 629);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.canvasImage);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Computaional Geometry";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectNmbPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox canvasImage;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_addPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_drawRandom;
        private System.Windows.Forms.Button drawAxis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button genPointsByNmb;
        private System.Windows.Forms.NumericUpDown selectNmbPoints;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

