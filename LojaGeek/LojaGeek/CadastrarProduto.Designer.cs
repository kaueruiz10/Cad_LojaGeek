
namespace LojaGeek
{
    partial class CadastrarProduto
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
            this.lblCadClie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.txtCadnomeProduto = new System.Windows.Forms.TextBox();
            this.txtCadDesc = new System.Windows.Forms.TextBox();
            this.mskCodProduto = new System.Windows.Forms.MaskedTextBox();
            this.txtCadPagamento = new System.Windows.Forms.TextBox();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadClie
            // 
            this.lblCadClie.AutoSize = true;
            this.lblCadClie.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCadClie.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadClie.ForeColor = System.Drawing.Color.Black;
            this.lblCadClie.Location = new System.Drawing.Point(150, 46);
            this.lblCadClie.Name = "lblCadClie";
            this.lblCadClie.Size = new System.Drawing.Size(512, 32);
            this.lblCadClie.TabIndex = 1;
            this.lblCadClie.Text = "CADASTRO DE PRODUTOS GEEK STORE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(79, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Produto:";
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescricao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbldescricao.Location = new System.Drawing.Point(129, 182);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(111, 24);
            this.lbldescricao.TabIndex = 3;
            this.lbldescricao.Text = "Descrição";
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProduto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCodProduto.Location = new System.Drawing.Point(72, 238);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(169, 24);
            this.lblCodProduto.TabIndex = 4;
            this.lblCodProduto.Text = "Código Produto";
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.BackColor = System.Drawing.Color.Black;
            this.lblPagamento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPagamento.Location = new System.Drawing.Point(115, 293);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(125, 24);
            this.lblPagamento.TabIndex = 5;
            this.lblPagamento.Text = "Pagamento";
            // 
            // txtCadnomeProduto
            // 
            this.txtCadnomeProduto.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadnomeProduto.Location = new System.Drawing.Point(247, 121);
            this.txtCadnomeProduto.Name = "txtCadnomeProduto";
            this.txtCadnomeProduto.Size = new System.Drawing.Size(359, 29);
            this.txtCadnomeProduto.TabIndex = 8;
            // 
            // txtCadDesc
            // 
            this.txtCadDesc.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadDesc.Location = new System.Drawing.Point(247, 180);
            this.txtCadDesc.Name = "txtCadDesc";
            this.txtCadDesc.Size = new System.Drawing.Size(359, 29);
            this.txtCadDesc.TabIndex = 9;
            // 
            // mskCodProduto
            // 
            this.mskCodProduto.Location = new System.Drawing.Point(247, 239);
            this.mskCodProduto.Mask = "(00) 00000-0000";
            this.mskCodProduto.Name = "mskCodProduto";
            this.mskCodProduto.Size = new System.Drawing.Size(220, 20);
            this.mskCodProduto.TabIndex = 12;
            // 
            // txtCadPagamento
            // 
            this.txtCadPagamento.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadPagamento.Location = new System.Drawing.Point(247, 290);
            this.txtCadPagamento.Name = "txtCadPagamento";
            this.txtCadPagamento.Size = new System.Drawing.Size(359, 29);
            this.txtCadPagamento.TabIndex = 13;
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.Color.DimGray;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(247, 359);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(140, 52);
            this.btnCadastrarProduto.TabIndex = 14;
            this.btnCadastrarProduto.Text = "CADASTRAR";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DimGray;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(466, 359);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(140, 52);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LojaGeek.Properties.Resources.logo_geek_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(703, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // CadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.txtCadPagamento);
            this.Controls.Add(this.mskCodProduto);
            this.Controls.Add(this.txtCadDesc);
            this.Controls.Add(this.txtCadnomeProduto);
            this.Controls.Add(this.lblPagamento);
            this.Controls.Add(this.lblCodProduto);
            this.Controls.Add(this.lbldescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCadClie);
            this.Name = "CadastrarProduto";
            this.Text = "CadastrarProduto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadClie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.TextBox txtCadnomeProduto;
        private System.Windows.Forms.TextBox txtCadDesc;
        private System.Windows.Forms.MaskedTextBox mskCodProduto;
        private System.Windows.Forms.TextBox txtCadPagamento;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}