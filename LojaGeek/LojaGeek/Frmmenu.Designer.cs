
namespace LojaGeek
{
    partial class Frmmenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMenuCadCli = new System.Windows.Forms.Button();
            this.btnMenuCadProd = new System.Windows.Forms.Button();
            this.btnMenuCons = new System.Windows.Forms.Button();
            this.btnMenuConsProd = new System.Windows.Forms.Button();
            this.cADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTROCLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTROPRODUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnVoltarLogin = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnMenuCadCli
            // 
            this.btnMenuCadCli.BackColor = System.Drawing.Color.DarkGray;
            this.btnMenuCadCli.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCadCli.Location = new System.Drawing.Point(48, 196);
            this.btnMenuCadCli.Name = "btnMenuCadCli";
            this.btnMenuCadCli.Size = new System.Drawing.Size(107, 78);
            this.btnMenuCadCli.TabIndex = 2;
            this.btnMenuCadCli.Text = "CADASTRAR CLIENTE";
            this.btnMenuCadCli.UseVisualStyleBackColor = false;
            this.btnMenuCadCli.Click += new System.EventHandler(this.btnMenuCadCli_Click);
            // 
            // btnMenuCadProd
            // 
            this.btnMenuCadProd.BackColor = System.Drawing.Color.DarkGray;
            this.btnMenuCadProd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCadProd.Location = new System.Drawing.Point(201, 196);
            this.btnMenuCadProd.Name = "btnMenuCadProd";
            this.btnMenuCadProd.Size = new System.Drawing.Size(107, 78);
            this.btnMenuCadProd.TabIndex = 3;
            this.btnMenuCadProd.Text = "CADASTRAR PRODUTO";
            this.btnMenuCadProd.UseVisualStyleBackColor = false;
            this.btnMenuCadProd.Click += new System.EventHandler(this.btnMenuCadProd_Click);
            // 
            // btnMenuCons
            // 
            this.btnMenuCons.BackColor = System.Drawing.Color.DarkGray;
            this.btnMenuCons.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCons.Location = new System.Drawing.Point(355, 196);
            this.btnMenuCons.Name = "btnMenuCons";
            this.btnMenuCons.Size = new System.Drawing.Size(107, 78);
            this.btnMenuCons.TabIndex = 4;
            this.btnMenuCons.Text = "CONSULTAR CLIENTE";
            this.btnMenuCons.UseVisualStyleBackColor = false;
            this.btnMenuCons.Click += new System.EventHandler(this.btnMenuCons_Click);
            // 
            // btnMenuConsProd
            // 
            this.btnMenuConsProd.BackColor = System.Drawing.Color.DarkGray;
            this.btnMenuConsProd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuConsProd.Location = new System.Drawing.Point(503, 196);
            this.btnMenuConsProd.Name = "btnMenuConsProd";
            this.btnMenuConsProd.Size = new System.Drawing.Size(107, 78);
            this.btnMenuConsProd.TabIndex = 5;
            this.btnMenuConsProd.Text = "CONSULTAR PRODUTO";
            this.btnMenuConsProd.UseVisualStyleBackColor = false;
            this.btnMenuConsProd.Click += new System.EventHandler(this.btnMenuConsProd_Click);
            // 
            // cADASTROToolStripMenuItem
            // 
            this.cADASTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROCLIENTEToolStripMenuItem,
            this.cADASTROPRODUToolStripMenuItem});
            this.cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            this.cADASTROToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.cADASTROToolStripMenuItem.Text = "CADASTRO";
            this.cADASTROToolStripMenuItem.Click += new System.EventHandler(this.cADASTROToolStripMenuItem_Click);
            // 
            // cADASTROCLIENTEToolStripMenuItem
            // 
            this.cADASTROCLIENTEToolStripMenuItem.Name = "cADASTROCLIENTEToolStripMenuItem";
            this.cADASTROCLIENTEToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.cADASTROCLIENTEToolStripMenuItem.Text = "CADASTRO CLIENTE";
            // 
            // cADASTROPRODUToolStripMenuItem
            // 
            this.cADASTROPRODUToolStripMenuItem.Name = "cADASTROPRODUToolStripMenuItem";
            this.cADASTROPRODUToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.cADASTROPRODUToolStripMenuItem.Text = "CADASTRO PRODUTO";
            this.cADASTROPRODUToolStripMenuItem.Click += new System.EventHandler(this.cADASTROPRODUToolStripMenuItem_Click);
            // 
            // cONSULTAToolStripMenuItem
            // 
            this.cONSULTAToolStripMenuItem.Name = "cONSULTAToolStripMenuItem";
            this.cONSULTAToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.cONSULTAToolStripMenuItem.Text = "CONSULTA";
            this.cONSULTAToolStripMenuItem.Click += new System.EventHandler(this.cONSULTAToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROToolStripMenuItem,
            this.cONSULTAToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btnVoltarLogin
            // 
            this.btnVoltarLogin.BackColor = System.Drawing.Color.DarkGray;
            this.btnVoltarLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarLogin.Location = new System.Drawing.Point(638, 196);
            this.btnVoltarLogin.Name = "btnVoltarLogin";
            this.btnVoltarLogin.Size = new System.Drawing.Size(107, 78);
            this.btnVoltarLogin.TabIndex = 6;
            this.btnVoltarLogin.Text = "VOLTAR";
            this.btnVoltarLogin.UseVisualStyleBackColor = false;
            this.btnVoltarLogin.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltarLogin);
            this.Controls.Add(this.btnMenuConsProd);
            this.Controls.Add(this.btnMenuCons);
            this.Controls.Add(this.btnMenuCadProd);
            this.Controls.Add(this.btnMenuCadCli);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmmenu";
            this.Text = "Frmmenu";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnMenuCadCli;
        private System.Windows.Forms.Button btnMenuCadProd;
        private System.Windows.Forms.Button btnMenuCons;
        private System.Windows.Forms.Button btnMenuConsProd;
        private System.Windows.Forms.ToolStripMenuItem cADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTROCLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTROPRODUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTAToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button btnVoltarLogin;
    }
}