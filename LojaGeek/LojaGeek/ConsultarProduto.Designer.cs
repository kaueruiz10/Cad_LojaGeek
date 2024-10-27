
namespace LojaGeek
{
    partial class ConsultarProduto
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
            this.lsbListaPedido = new System.Windows.Forms.ListBox();
            this.btnConsultarPedido = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lsbListaPedido
            // 
            this.lsbListaPedido.BackColor = System.Drawing.Color.DimGray;
            this.lsbListaPedido.FormattingEnabled = true;
            this.lsbListaPedido.Location = new System.Drawing.Point(206, 1);
            this.lsbListaPedido.Name = "lsbListaPedido";
            this.lsbListaPedido.Size = new System.Drawing.Size(398, 355);
            this.lsbListaPedido.TabIndex = 1;
            // 
            // btnConsultarPedido
            // 
            this.btnConsultarPedido.BackColor = System.Drawing.Color.DarkGray;
            this.btnConsultarPedido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPedido.Location = new System.Drawing.Point(206, 390);
            this.btnConsultarPedido.Name = "btnConsultarPedido";
            this.btnConsultarPedido.Size = new System.Drawing.Size(131, 48);
            this.btnConsultarPedido.TabIndex = 2;
            this.btnConsultarPedido.Text = "CONSULTAR";
            this.btnConsultarPedido.UseVisualStyleBackColor = false;
            this.btnConsultarPedido.Click += new System.EventHandler(this.btnConsultarPedido_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(473, 390);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(131, 48);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LojaGeek.Properties.Resources.logo_geek_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(701, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnConsultarPedido);
            this.Controls.Add(this.lsbListaPedido);
            this.Name = "ConsultarProduto";
            this.Text = "ConsultarProduto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbListaPedido;
        private System.Windows.Forms.Button btnConsultarPedido;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}