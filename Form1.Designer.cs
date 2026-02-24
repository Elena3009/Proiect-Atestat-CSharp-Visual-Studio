namespace Atestat
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
            this.Latest_releases = new System.Windows.Forms.Button();
            this.dupa_gen = new System.Windows.Forms.Button();
            this.dupa_autor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Latest_releases
            // 
            this.Latest_releases.BackColor = System.Drawing.Color.LightCoral;
            this.Latest_releases.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Latest_releases.Location = new System.Drawing.Point(321, 154);
            this.Latest_releases.Name = "Latest_releases";
            this.Latest_releases.Size = new System.Drawing.Size(176, 43);
            this.Latest_releases.TabIndex = 0;
            this.Latest_releases.Text = "Latest releases ";
            this.Latest_releases.UseVisualStyleBackColor = false;
            this.Latest_releases.Click += new System.EventHandler(this.Latest_releases_Click);
            // 
            // dupa_gen
            // 
            this.dupa_gen.BackColor = System.Drawing.Color.LightCoral;
            this.dupa_gen.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dupa_gen.Location = new System.Drawing.Point(321, 214);
            this.dupa_gen.Name = "dupa_gen";
            this.dupa_gen.Size = new System.Drawing.Size(176, 43);
            this.dupa_gen.TabIndex = 1;
            this.dupa_gen.Text = "Gen ";
            this.dupa_gen.UseVisualStyleBackColor = false;
            this.dupa_gen.Click += new System.EventHandler(this.dupa_gen_Click);
            // 
            // dupa_autor
            // 
            this.dupa_autor.BackColor = System.Drawing.Color.LightCoral;
            this.dupa_autor.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dupa_autor.Location = new System.Drawing.Point(321, 282);
            this.dupa_autor.Name = "dupa_autor";
            this.dupa_autor.Size = new System.Drawing.Size(176, 43);
            this.dupa_autor.TabIndex = 2;
            this.dupa_autor.Text = "Autor ";
            this.dupa_autor.UseVisualStyleBackColor = false;
            this.dupa_autor.Click += new System.EventHandler(this.dupa_autor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Atestat.Properties.Resources.Bookshelf_Photos___Download_Free_High_Quality_Pictures___Freepik;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dupa_autor);
            this.Controls.Add(this.dupa_gen);
            this.Controls.Add(this.Latest_releases);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Latest_releases;
        private System.Windows.Forms.Button dupa_gen;
        private System.Windows.Forms.Button dupa_autor;
    }
}

