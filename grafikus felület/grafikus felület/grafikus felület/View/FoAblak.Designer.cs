namespace EatAdvisor
{
    partial class FoAblak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoAblak));
            this.btnRangsor = new System.Windows.Forms.Button();
            this.btnErtekel = new System.Windows.Forms.Button();
            this.btnKijelentkezes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRangsor
            // 
            this.btnRangsor.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRangsor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRangsor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRangsor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRangsor.ForeColor = System.Drawing.Color.White;
            this.btnRangsor.Location = new System.Drawing.Point(92, 121);
            this.btnRangsor.Name = "btnRangsor";
            this.btnRangsor.Size = new System.Drawing.Size(214, 65);
            this.btnRangsor.TabIndex = 1;
            this.btnRangsor.Text = "Éttermek értékelései";
            this.btnRangsor.UseVisualStyleBackColor = false;
            this.btnRangsor.Click += new System.EventHandler(this.btnRangsor_Click);
            // 
            // btnErtekel
            // 
            this.btnErtekel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnErtekel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnErtekel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnErtekel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnErtekel.ForeColor = System.Drawing.Color.White;
            this.btnErtekel.Location = new System.Drawing.Point(92, 50);
            this.btnErtekel.Name = "btnErtekel";
            this.btnErtekel.Size = new System.Drawing.Size(214, 65);
            this.btnErtekel.TabIndex = 0;
            this.btnErtekel.Text = "Értékelés";
            this.btnErtekel.UseVisualStyleBackColor = false;
            this.btnErtekel.Click += new System.EventHandler(this.btnErtekel_Click);
            // 
            // btnKijelentkezes
            // 
            this.btnKijelentkezes.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnKijelentkezes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKijelentkezes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKijelentkezes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKijelentkezes.ForeColor = System.Drawing.Color.White;
            this.btnKijelentkezes.Location = new System.Drawing.Point(92, 192);
            this.btnKijelentkezes.Name = "btnKijelentkezes";
            this.btnKijelentkezes.Size = new System.Drawing.Size(214, 65);
            this.btnKijelentkezes.TabIndex = 2;
            this.btnKijelentkezes.Text = "Kijelentkezés";
            this.btnKijelentkezes.UseVisualStyleBackColor = false;
            this.btnKijelentkezes.Click += new System.EventHandler(this.btnKijelentkezes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FoAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 444);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKijelentkezes);
            this.Controls.Add(this.btnRangsor);
            this.Controls.Add(this.btnErtekel);
            this.Name = "FoAblak";
            this.Text = "Fő ablak";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRangsor;
        private System.Windows.Forms.Button btnErtekel;
        private System.Windows.Forms.Button btnKijelentkezes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}