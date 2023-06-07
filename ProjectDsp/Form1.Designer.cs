namespace ProjectDsp
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
            this.Upload = new System.Windows.Forms.Button();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.Fouriertransform = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Upload
            // 
            this.Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload.Location = new System.Drawing.Point(188, 341);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(197, 57);
            this.Upload.TabIndex = 0;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // picbox
            // 
            this.picbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.picbox.Location = new System.Drawing.Point(81, 12);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(424, 273);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox.TabIndex = 1;
            this.picbox.TabStop = false;
            // 
            // Fouriertransform
            // 
            this.Fouriertransform.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fouriertransform.Location = new System.Drawing.Point(66, 454);
            this.Fouriertransform.Name = "Fouriertransform";
            this.Fouriertransform.Size = new System.Drawing.Size(484, 57);
            this.Fouriertransform.TabIndex = 3;
            this.Fouriertransform.Text = "Continuous Fourier transform";
            this.Fouriertransform.UseVisualStyleBackColor = true;
            this.Fouriertransform.Click += new System.EventHandler(this.LaplaceTransform_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectDsp.Properties.Resources.polygons_geometric_blur_background_connected_dots_1920x1200_1740;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(617, 576);
            this.Controls.Add(this.Fouriertransform);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.Upload);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Button Fouriertransform;
    }
}

