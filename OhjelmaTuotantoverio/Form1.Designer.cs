namespace OhjelmaTuotantoverio
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
            this.components = new System.ComponentModel.Container();
            this.pisteTeksti = new System.Windows.Forms.Label();
            this.Vihollinen3 = new System.Windows.Forms.PictureBox();
            this.Vihollinen2 = new System.Windows.Forms.PictureBox();
            this.Vihollinen1 = new System.Windows.Forms.PictureBox();
            this.LaavaMaa = new System.Windows.Forms.PictureBox();
            this.Pelaaja = new System.Windows.Forms.PictureBox();
            this.Ajastin = new System.Windows.Forms.Timer(this.components);
            this.Lopputeksti = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Vihollinen3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vihollinen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vihollinen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaavaMaa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pelaaja)).BeginInit();
            this.SuspendLayout();
            // 
            // pisteTeksti
            // 
            this.pisteTeksti.AutoSize = true;
            this.pisteTeksti.Font = new System.Drawing.Font("Goudy Stout", 27.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pisteTeksti.Location = new System.Drawing.Point(39, 28);
            this.pisteTeksti.Name = "pisteTeksti";
            this.pisteTeksti.Size = new System.Drawing.Size(696, 90);
            this.pisteTeksti.TabIndex = 5;
            this.pisteTeksti.Text = "Pisteet: 0";
            this.pisteTeksti.Click += new System.EventHandler(this.label1_Click);
            // 
            // Vihollinen3
            // 
            this.Vihollinen3.Image = global::OhjelmaTuotantoverio.Properties.Resources.tulivihollinen;
            this.Vihollinen3.Location = new System.Drawing.Point(1478, 805);
            this.Vihollinen3.Name = "Vihollinen3";
            this.Vihollinen3.Size = new System.Drawing.Size(198, 192);
            this.Vihollinen3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vihollinen3.TabIndex = 4;
            this.Vihollinen3.TabStop = false;
            // 
            // Vihollinen2
            // 
            this.Vihollinen2.Image = global::OhjelmaTuotantoverio.Properties.Resources.tulivihollinen;
            this.Vihollinen2.Location = new System.Drawing.Point(1644, 640);
            this.Vihollinen2.Name = "Vihollinen2";
            this.Vihollinen2.Size = new System.Drawing.Size(121, 111);
            this.Vihollinen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vihollinen2.TabIndex = 3;
            this.Vihollinen2.TabStop = false;
            // 
            // Vihollinen1
            // 
            this.Vihollinen1.Image = global::OhjelmaTuotantoverio.Properties.Resources.tulivihollinen;
            this.Vihollinen1.Location = new System.Drawing.Point(766, 119);
            this.Vihollinen1.Name = "Vihollinen1";
            this.Vihollinen1.Size = new System.Drawing.Size(213, 223);
            this.Vihollinen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vihollinen1.TabIndex = 2;
            this.Vihollinen1.TabStop = false;
            // 
            // LaavaMaa
            // 
            this.LaavaMaa.Image = global::OhjelmaTuotantoverio.Properties.Resources.laavacropped;
            this.LaavaMaa.Location = new System.Drawing.Point(-3, 1030);
            this.LaavaMaa.Name = "LaavaMaa";
            this.LaavaMaa.Size = new System.Drawing.Size(1854, 132);
            this.LaavaMaa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LaavaMaa.TabIndex = 1;
            this.LaavaMaa.TabStop = false;
            // 
            // Pelaaja
            // 
            this.Pelaaja.Image = global::OhjelmaTuotantoverio.Properties.Resources.pelihahmo1;
            this.Pelaaja.Location = new System.Drawing.Point(208, 332);
            this.Pelaaja.Name = "Pelaaja";
            this.Pelaaja.Size = new System.Drawing.Size(339, 177);
            this.Pelaaja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pelaaja.TabIndex = 0;
            this.Pelaaja.TabStop = false;
            // 
            // Ajastin
            // 
            this.Ajastin.Enabled = true;
            this.Ajastin.Interval = 20;
            this.Ajastin.Tick += new System.EventHandler(this.pelinAjastinTapahtuma);
            // 
            // Lopputeksti
            // 
            this.Lopputeksti.AutoSize = true;
            this.Lopputeksti.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lopputeksti.Location = new System.Drawing.Point(280, 512);
            this.Lopputeksti.Name = "Lopputeksti";
            this.Lopputeksti.Size = new System.Drawing.Size(0, 99);
            this.Lopputeksti.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1840, 1157);
            this.Controls.Add(this.Lopputeksti);
            this.Controls.Add(this.pisteTeksti);
            this.Controls.Add(this.Vihollinen3);
            this.Controls.Add(this.Vihollinen2);
            this.Controls.Add(this.Vihollinen1);
            this.Controls.Add(this.LaavaMaa);
            this.Controls.Add(this.Pelaaja);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.peliNappiAlas);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.peliNappiYlos);
            ((System.ComponentModel.ISupportInitialize)(this.Vihollinen3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vihollinen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vihollinen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaavaMaa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pelaaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pelaaja;
        private System.Windows.Forms.PictureBox LaavaMaa;
        private System.Windows.Forms.PictureBox Vihollinen1;
        private System.Windows.Forms.PictureBox Vihollinen2;
        private System.Windows.Forms.PictureBox Vihollinen3;
        private System.Windows.Forms.Label pisteTeksti;
        private System.Windows.Forms.Timer Ajastin;
        private System.Windows.Forms.Label Lopputeksti;
    }
}

