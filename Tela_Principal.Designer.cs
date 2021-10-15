
namespace AulaMiriam_TelaDeLogin
{
    partial class Tela_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Principal));
            this.btn_Cliente = new System.Windows.Forms.Button();
            this.btn_Peca = new System.Windows.Forms.Button();
            this.btn_Fornecedor = new System.Windows.Forms.Button();
            this.btn_Aparelho = new System.Windows.Forms.Button();
            this.btn_Produtos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cliente.BackgroundImage")));
            this.btn_Cliente.FlatAppearance.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btn_Cliente.FlatAppearance.BorderSize = 0;
            this.btn_Cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Cliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cliente.Location = new System.Drawing.Point(174, 12);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Size = new System.Drawing.Size(118, 59);
            this.btn_Cliente.TabIndex = 1;
            this.btn_Cliente.Text = "Cliente";
            this.btn_Cliente.UseVisualStyleBackColor = true;
            this.btn_Cliente.Click += new System.EventHandler(this.btn_Cliente_Click);
            // 
            // btn_Peca
            // 
            this.btn_Peca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Peca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Peca.BackgroundImage")));
            this.btn_Peca.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Peca.Location = new System.Drawing.Point(298, 12);
            this.btn_Peca.Name = "btn_Peca";
            this.btn_Peca.Size = new System.Drawing.Size(118, 59);
            this.btn_Peca.TabIndex = 2;
            this.btn_Peca.Text = "Peças";
            this.btn_Peca.UseVisualStyleBackColor = true;
            // 
            // btn_Fornecedor
            // 
            this.btn_Fornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fornecedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Fornecedor.BackgroundImage")));
            this.btn_Fornecedor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fornecedor.Location = new System.Drawing.Point(422, 12);
            this.btn_Fornecedor.Name = "btn_Fornecedor";
            this.btn_Fornecedor.Size = new System.Drawing.Size(118, 59);
            this.btn_Fornecedor.TabIndex = 3;
            this.btn_Fornecedor.Text = "Fornecedor";
            this.btn_Fornecedor.UseVisualStyleBackColor = true;
            // 
            // btn_Aparelho
            // 
            this.btn_Aparelho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Aparelho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Aparelho.BackgroundImage")));
            this.btn_Aparelho.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aparelho.Location = new System.Drawing.Point(546, 12);
            this.btn_Aparelho.Name = "btn_Aparelho";
            this.btn_Aparelho.Size = new System.Drawing.Size(118, 59);
            this.btn_Aparelho.TabIndex = 4;
            this.btn_Aparelho.Text = "Aparelhos";
            this.btn_Aparelho.UseVisualStyleBackColor = true;
            // 
            // btn_Produtos
            // 
            this.btn_Produtos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Produtos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Produtos.BackgroundImage")));
            this.btn_Produtos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Produtos.Location = new System.Drawing.Point(670, 12);
            this.btn_Produtos.Name = "btn_Produtos";
            this.btn_Produtos.Size = new System.Drawing.Size(118, 59);
            this.btn_Produtos.TabIndex = 5;
            this.btn_Produtos.Text = "Produtos";
            this.btn_Produtos.UseVisualStyleBackColor = true;
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Produtos);
            this.Controls.Add(this.btn_Aparelho);
            this.Controls.Add(this.btn_Fornecedor);
            this.Controls.Add(this.btn_Peca);
            this.Controls.Add(this.btn_Cliente);
            this.Name = "Tela_Principal";
            this.Text = "Tela_Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cliente;
        private System.Windows.Forms.Button btn_Peca;
        private System.Windows.Forms.Button btn_Fornecedor;
        private System.Windows.Forms.Button btn_Aparelho;
        private System.Windows.Forms.Button btn_Produtos;
    }
}