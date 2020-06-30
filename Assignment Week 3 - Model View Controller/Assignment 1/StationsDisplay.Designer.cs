namespace Assignment_1
{
    partial class StationsDisplay
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
            this.lstStations = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstStations
            // 
            this.lstStations.Location = new System.Drawing.Point(29, 46);
            this.lstStations.Name = "lstStations";
            this.lstStations.Size = new System.Drawing.Size(237, 320);
            this.lstStations.TabIndex = 0;
            this.lstStations.UseCompatibleStateImageBehavior = false;
            // 
            // StationsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 409);
            this.Controls.Add(this.lstStations);
            this.Name = "StationsDisplay";
            this.Text = "StationsDisplay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstStations;
    }
}