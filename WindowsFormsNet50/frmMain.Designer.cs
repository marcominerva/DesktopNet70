
namespace WindowsFormsNet50
{
    partial class frmMain
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
            this.OpenFormButton = new System.Windows.Forms.Button();
            this.GetLocationButton = new System.Windows.Forms.Button();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.TakePictureButton = new System.Windows.Forms.Button();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFormButton
            // 
            this.OpenFormButton.Location = new System.Drawing.Point(34, 25);
            this.OpenFormButton.Name = "OpenFormButton";
            this.OpenFormButton.Size = new System.Drawing.Size(177, 37);
            this.OpenFormButton.TabIndex = 0;
            this.OpenFormButton.Text = "Open New Form";
            this.OpenFormButton.UseVisualStyleBackColor = true;
            this.OpenFormButton.Click += new System.EventHandler(this.OpenFormButton_Click);
            // 
            // GetLocationButton
            // 
            this.GetLocationButton.Location = new System.Drawing.Point(231, 24);
            this.GetLocationButton.Name = "GetLocationButton";
            this.GetLocationButton.Size = new System.Drawing.Size(177, 38);
            this.GetLocationButton.TabIndex = 1;
            this.GetLocationButton.Text = "Get Location";
            this.GetLocationButton.UseVisualStyleBackColor = true;
            this.GetLocationButton.Click += new System.EventHandler(this.GetLocationButton_Click);
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(231, 105);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(83, 20);
            this.lblLongitude.TabIndex = 3;
            this.lblLongitude.Text = "(longitude)";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(231, 76);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(70, 20);
            this.lblLatitude.TabIndex = 4;
            this.lblLatitude.Text = "(latitude)";
            // 
            // TakePictureButton
            // 
            this.TakePictureButton.Location = new System.Drawing.Point(433, 24);
            this.TakePictureButton.Name = "TakePictureButton";
            this.TakePictureButton.Size = new System.Drawing.Size(177, 38);
            this.TakePictureButton.TabIndex = 5;
            this.TakePictureButton.Text = "Take Picture";
            this.TakePictureButton.UseVisualStyleBackColor = true;
            this.TakePictureButton.Click += new System.EventHandler(this.TakePictureButton_Click);
            // 
            // picPhoto
            // 
            this.picPhoto.Location = new System.Drawing.Point(225, 161);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(385, 277);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 6;
            this.picPhoto.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.TakePictureButton);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.GetLocationButton);
            this.Controls.Add(this.OpenFormButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Forms with .NET 5.0";
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFormButton;
        private System.Windows.Forms.Button GetLocationButton;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Button TakePictureButton;
        private System.Windows.Forms.PictureBox picPhoto;
    }
}

