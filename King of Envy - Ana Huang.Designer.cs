namespace Atestat
{
    partial class King_of_Envy___Ana_Huang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(King_of_Envy___Ana_Huang));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.inapoi_kingofenvy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Atestat.Properties.Resources.King_of_Envy_paperback;
            this.pictureBox1.Location = new System.Drawing.Point(516, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 344);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.richTextBox1.Location = new System.Drawing.Point(68, 75);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(380, 296);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // inapoi_kingofenvy
            // 
            this.inapoi_kingofenvy.BackColor = System.Drawing.Color.LightCoral;
            this.inapoi_kingofenvy.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inapoi_kingofenvy.Location = new System.Drawing.Point(213, 402);
            this.inapoi_kingofenvy.Name = "inapoi_kingofenvy";
            this.inapoi_kingofenvy.Size = new System.Drawing.Size(75, 23);
            this.inapoi_kingofenvy.TabIndex = 2;
            this.inapoi_kingofenvy.Text = "Inapoi";
            this.inapoi_kingofenvy.UseVisualStyleBackColor = false;
            this.inapoi_kingofenvy.Click += new System.EventHandler(this.inapoi_kingofenvy_Click);
            // 
            // King_of_Envy___Ana_Huang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Atestat.Properties.Resources.Book_Pages_Wallpaper;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inapoi_kingofenvy);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "King_of_Envy___Ana_Huang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "King_of_Envy___Ana_Huang";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button inapoi_kingofenvy;
    }
}