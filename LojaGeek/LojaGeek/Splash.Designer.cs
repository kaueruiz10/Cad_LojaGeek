
namespace LojaGeek
{
    partial class Splash
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.prgSplash = new System.Windows.Forms.ProgressBar();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // prgSplash
            // 
            this.prgSplash.Location = new System.Drawing.Point(-1, 301);
            this.prgSplash.Name = "prgSplash";
            this.prgSplash.Size = new System.Drawing.Size(800, 60);
            this.prgSplash.TabIndex = 1;
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LojaGeek.Properties.Resources.gifAnimado;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 343);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.prgSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.Text = "Tela De Login - Loja Geek";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar prgSplash;
        private System.Windows.Forms.Timer tmrSplash;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

