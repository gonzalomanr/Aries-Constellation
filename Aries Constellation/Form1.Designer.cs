namespace Aries_Constellation
{
    partial class AriesConstellation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AriesConstellation));
            this.ariesLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ariesLabel
            // 
            this.ariesLabel.AutoSize = true;
            this.ariesLabel.BackColor = System.Drawing.Color.Transparent;
            this.ariesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ariesLabel.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ariesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ariesLabel.Location = new System.Drawing.Point(63, 258);
            this.ariesLabel.Name = "ariesLabel";
            this.ariesLabel.Size = new System.Drawing.Size(189, 26);
            this.ariesLabel.TabIndex = 0;
            this.ariesLabel.Text = "Aries Constellation";
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoLabel.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.infoLabel.Location = new System.Drawing.Point(12, 284);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(294, 27);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Gonzalo Manrique, Sep. 26th 2017";
            // 
            // AriesConstellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(318, 319);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.ariesLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AriesConstellation";
            this.Text = "Aries Constellation";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ariesLabel;
        private System.Windows.Forms.Label infoLabel;
        
    }
}

