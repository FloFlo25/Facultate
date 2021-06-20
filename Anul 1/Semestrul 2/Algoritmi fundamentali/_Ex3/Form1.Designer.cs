namespace _Ex3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_refresh_Click = new System.Windows.Forms.Button();
            this.btn_clear_Click = new System.Windows.Forms.Button();
            this.btn_addPoint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_refresh_Click
            // 
            this.btn_refresh_Click.Location = new System.Drawing.Point(849, 27);
            this.btn_refresh_Click.Name = "btn_refresh_Click";
            this.btn_refresh_Click.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh_Click.TabIndex = 1;
            this.btn_refresh_Click.Text = "Refresh";
            this.btn_refresh_Click.UseVisualStyleBackColor = true;
            this.btn_refresh_Click.Click += new System.EventHandler(this.btn_refresh_Click_Click);
            // 
            // btn_clear_Click
            // 
            this.btn_clear_Click.Location = new System.Drawing.Point(849, 67);
            this.btn_clear_Click.Name = "btn_clear_Click";
            this.btn_clear_Click.Size = new System.Drawing.Size(75, 23);
            this.btn_clear_Click.TabIndex = 2;
            this.btn_clear_Click.Text = "Clear";
            this.btn_clear_Click.UseVisualStyleBackColor = true;
            this.btn_clear_Click.Click += new System.EventHandler(this.btn_clear_Click_Click);
            // 
            // btn_addPoint
            // 
            this.btn_addPoint.Location = new System.Drawing.Point(849, 109);
            this.btn_addPoint.Name = "btn_addPoint";
            this.btn_addPoint.Size = new System.Drawing.Size(75, 23);
            this.btn_addPoint.TabIndex = 3;
            this.btn_addPoint.Text = "button1";
            this.btn_addPoint.UseVisualStyleBackColor = true;
            this.btn_addPoint.Click += new System.EventHandler(this.btn_addPoint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 637);
            this.Controls.Add(this.btn_addPoint);
            this.Controls.Add(this.btn_clear_Click);
            this.Controls.Add(this.btn_refresh_Click);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_refresh_Click;
        private System.Windows.Forms.Button btn_clear_Click;
        private System.Windows.Forms.Button btn_addPoint;
    }
}

