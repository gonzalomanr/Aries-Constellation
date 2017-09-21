namespace Aries_Constellation
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
            this.AriesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AriesLabel
            // 
            this.AriesLabel.AutoSize = true;
            this.AriesLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AriesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AriesLabel.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AriesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AriesLabel.Location = new System.Drawing.Point(63, 284);
            this.AriesLabel.Name = "AriesLabel";
            this.AriesLabel.Size = new System.Drawing.Size(189, 26);
            this.AriesLabel.TabIndex = 0;
            this.AriesLabel.Text = "Aries Constellation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(318, 319);
            this.Controls.Add(this.AriesLabel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AriesLabel;
    }
}

