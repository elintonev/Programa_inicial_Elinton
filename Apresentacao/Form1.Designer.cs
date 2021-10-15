
namespace AulaMiriam_TelaDeLogin
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(726, 166);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_Usuario.TabIndex = 1;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(726, 213);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(100, 20);
            this.txt_Senha.TabIndex = 2;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.Location = new System.Drawing.Point(496, 288);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(280, 75);
            this.btn_Entrar.TabIndex = 3;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Location = new System.Drawing.Point(811, 288);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(271, 75);
            this.btn_Sair.TabIndex = 4;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.Location = new System.Drawing.Point(590, 156);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(117, 42);
            this.lbl_Usuario.TabIndex = 5;
            this.lbl_Usuario.Text = "Usuário";
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.Location = new System.Drawing.Point(592, 194);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(101, 42);
            this.lbl_Senha.TabIndex = 6;
            this.lbl_Senha.Text = "Senha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1390, 623);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Senha;
    }
}

