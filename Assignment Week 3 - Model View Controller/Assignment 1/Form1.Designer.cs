namespace Assignment_1
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnNewDisplay = new System.Windows.Forms.Button();
            this.btnStations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(120, 108);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(219, 55);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNewDisplay
            // 
            this.btnNewDisplay.Location = new System.Drawing.Point(24, 229);
            this.btnNewDisplay.Name = "btnNewDisplay";
            this.btnNewDisplay.Size = new System.Drawing.Size(140, 38);
            this.btnNewDisplay.TabIndex = 1;
            this.btnNewDisplay.Text = "New Display";
            this.btnNewDisplay.UseVisualStyleBackColor = true;
            this.btnNewDisplay.Click += new System.EventHandler(this.btnNewDisplay_Click);
            // 
            // btnStations
            // 
            this.btnStations.Location = new System.Drawing.Point(295, 229);
            this.btnStations.Name = "btnStations";
            this.btnStations.Size = new System.Drawing.Size(140, 38);
            this.btnStations.TabIndex = 2;
            this.btnStations.Text = "Stations";
            this.btnStations.UseVisualStyleBackColor = true;
            this.btnStations.Click += new System.EventHandler(this.btnStations_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 288);
            this.Controls.Add(this.btnStations);
            this.Controls.Add(this.btnNewDisplay);
            this.Controls.Add(this.btnNext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnNewDisplay;
        private System.Windows.Forms.Button btnStations;
    }
}

