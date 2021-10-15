
namespace AulaMiriam_TelaDeLogin.TelaInicial
{
    partial class CadastroClientes
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
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_CodigoCliente = new System.Windows.Forms.Label();
            this.lbl_RazaoSocial = new System.Windows.Forms.Label();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.lbl_Uf = new System.Windows.Forms.Label();
            this.lbl_Tel = new System.Windows.Forms.Label();
            this.txt_CodigoCliente = new System.Windows.Forms.TextBox();
            this.txt_RazaoSocial = new System.Windows.Forms.TextBox();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.txt_Uf = new System.Windows.Forms.TextBox();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.lbl_Sucesso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_DataInclusao = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.mtb_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lbl_usuCad = new System.Windows.Forms.Label();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datainclusaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaosocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aulas_CSharpDataSet2 = new AulaMiriam_TelaDeLogin.Aulas_CSharpDataSet2();
            this.btn_BuscarCadastros = new System.Windows.Forms.Button();
            this.rbtn_PessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rbtn_PessoaFisica = new System.Windows.Forms.RadioButton();
            this.mtb_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clientesTableAdapter1 = new AulaMiriam_TelaDeLogin.Aulas_CSharpDataSet2TableAdapters.ClientesTableAdapter();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulas_CSharpDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar.Location = new System.Drawing.Point(32, 678);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(123, 34);
            this.btn_Confirmar.TabIndex = 9;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(278, 678);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(123, 34);
            this.btn_Cancelar.TabIndex = 10;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_CodigoCliente
            // 
            this.lbl_CodigoCliente.AutoSize = true;
            this.lbl_CodigoCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodigoCliente.Location = new System.Drawing.Point(28, 121);
            this.lbl_CodigoCliente.Name = "lbl_CodigoCliente";
            this.lbl_CodigoCliente.Size = new System.Drawing.Size(118, 20);
            this.lbl_CodigoCliente.TabIndex = 2;
            this.lbl_CodigoCliente.Text = "Código do Cliente";
            // 
            // lbl_RazaoSocial
            // 
            this.lbl_RazaoSocial.AutoSize = true;
            this.lbl_RazaoSocial.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RazaoSocial.Location = new System.Drawing.Point(28, 193);
            this.lbl_RazaoSocial.Name = "lbl_RazaoSocial";
            this.lbl_RazaoSocial.Size = new System.Drawing.Size(88, 20);
            this.lbl_RazaoSocial.TabIndex = 4;
            this.lbl_RazaoSocial.Text = "Razão Social";
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Endereco.Location = new System.Drawing.Point(28, 295);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(68, 20);
            this.lbl_Endereco.TabIndex = 6;
            this.lbl_Endereco.Text = "Endereço";
            // 
            // lbl_Bairro
            // 
            this.lbl_Bairro.AutoSize = true;
            this.lbl_Bairro.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lbl_Bairro.Location = new System.Drawing.Point(28, 331);
            this.lbl_Bairro.Name = "lbl_Bairro";
            this.lbl_Bairro.Size = new System.Drawing.Size(44, 20);
            this.lbl_Bairro.TabIndex = 7;
            this.lbl_Bairro.Text = "Bairro";
            // 
            // lbl_Uf
            // 
            this.lbl_Uf.AutoSize = true;
            this.lbl_Uf.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lbl_Uf.Location = new System.Drawing.Point(29, 364);
            this.lbl_Uf.Name = "lbl_Uf";
            this.lbl_Uf.Size = new System.Drawing.Size(26, 20);
            this.lbl_Uf.TabIndex = 8;
            this.lbl_Uf.Text = "UF";
            // 
            // lbl_Tel
            // 
            this.lbl_Tel.AutoSize = true;
            this.lbl_Tel.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lbl_Tel.Location = new System.Drawing.Point(28, 425);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(61, 20);
            this.lbl_Tel.TabIndex = 9;
            this.lbl_Tel.Text = "Telefone";
            // 
            // txt_CodigoCliente
            // 
            this.txt_CodigoCliente.Location = new System.Drawing.Point(191, 121);
            this.txt_CodigoCliente.Name = "txt_CodigoCliente";
            this.txt_CodigoCliente.Size = new System.Drawing.Size(130, 20);
            this.txt_CodigoCliente.TabIndex = 1;
            // 
            // txt_RazaoSocial
            // 
            this.txt_RazaoSocial.Location = new System.Drawing.Point(191, 193);
            this.txt_RazaoSocial.Name = "txt_RazaoSocial";
            this.txt_RazaoSocial.Size = new System.Drawing.Size(130, 20);
            this.txt_RazaoSocial.TabIndex = 3;
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Location = new System.Drawing.Point(191, 331);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(130, 20);
            this.txt_Bairro.TabIndex = 6;
            // 
            // txt_Uf
            // 
            this.txt_Uf.Location = new System.Drawing.Point(191, 364);
            this.txt_Uf.Name = "txt_Uf";
            this.txt_Uf.Size = new System.Drawing.Size(130, 20);
            this.txt_Uf.TabIndex = 7;
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Location = new System.Drawing.Point(191, 297);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(130, 20);
            this.txt_Endereco.TabIndex = 5;
            // 
            // lbl_Sucesso
            // 
            this.lbl_Sucesso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Sucesso.AutoSize = true;
            this.lbl_Sucesso.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sucesso.Location = new System.Drawing.Point(79, 467);
            this.lbl_Sucesso.Name = "lbl_Sucesso";
            this.lbl_Sucesso.Size = new System.Drawing.Size(215, 25);
            this.lbl_Sucesso.TabIndex = 18;
            this.lbl_Sucesso.Text = "Cadastrado com Sucesso";
            this.lbl_Sucesso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Sucesso.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(327, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(327, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(327, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(327, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Data de Inclusão";
            // 
            // dtp_DataInclusao
            // 
            this.dtp_DataInclusao.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtp_DataInclusao.Font = new System.Drawing.Font("Arial Narrow", 12.25F);
            this.dtp_DataInclusao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataInclusao.Location = new System.Drawing.Point(191, 157);
            this.dtp_DataInclusao.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dtp_DataInclusao.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_DataInclusao.Name = "dtp_DataInclusao";
            this.dtp_DataInclusao.Size = new System.Drawing.Size(130, 26);
            this.dtp_DataInclusao.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(327, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "*";
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Location = new System.Drawing.Point(191, 396);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(130, 20);
            this.txt_Cidade.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label7.Location = new System.Drawing.Point(29, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Cidade";
            // 
            // mtb_Telefone
            // 
            this.mtb_Telefone.Location = new System.Drawing.Point(191, 425);
            this.mtb_Telefone.Mask = "(99) 000-000-000";
            this.mtb_Telefone.Name = "mtb_Telefone";
            this.mtb_Telefone.Size = new System.Drawing.Size(130, 20);
            this.mtb_Telefone.TabIndex = 28;
            // 
            // mtb_CNPJ
            // 
            this.mtb_CNPJ.Location = new System.Drawing.Point(191, 229);
            this.mtb_CNPJ.Mask = "00.000.000/0000-00";
            this.mtb_CNPJ.Name = "mtb_CNPJ";
            this.mtb_CNPJ.Size = new System.Drawing.Size(130, 20);
            this.mtb_CNPJ.TabIndex = 29;
            // 
            // lbl_usuCad
            // 
            this.lbl_usuCad.AutoSize = true;
            this.lbl_usuCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuCad.Location = new System.Drawing.Point(28, 507);
            this.lbl_usuCad.Name = "lbl_usuCad";
            this.lbl_usuCad.Size = new System.Drawing.Size(192, 24);
            this.lbl_usuCad.TabIndex = 31;
            this.lbl_usuCad.Text = "Usuários Cadastrados";
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.Location = new System.Drawing.Point(155, 678);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(123, 34);
            this.btn_Alterar.TabIndex = 32;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoclienteDataGridViewTextBoxColumn,
            this.datainclusaoDataGridViewTextBoxColumn,
            this.razaosocialDataGridViewTextBoxColumn,
            this.cnpjDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.ufDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.cpf,
            this.inscricaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 534);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(369, 128);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // codigoclienteDataGridViewTextBoxColumn
            // 
            this.codigoclienteDataGridViewTextBoxColumn.DataPropertyName = "codigocliente";
            this.codigoclienteDataGridViewTextBoxColumn.HeaderText = "codigocliente";
            this.codigoclienteDataGridViewTextBoxColumn.Name = "codigoclienteDataGridViewTextBoxColumn";
            this.codigoclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoclienteDataGridViewTextBoxColumn.Width = 95;
            // 
            // datainclusaoDataGridViewTextBoxColumn
            // 
            this.datainclusaoDataGridViewTextBoxColumn.DataPropertyName = "data_inclusao";
            this.datainclusaoDataGridViewTextBoxColumn.HeaderText = "data_inclusao";
            this.datainclusaoDataGridViewTextBoxColumn.Name = "datainclusaoDataGridViewTextBoxColumn";
            this.datainclusaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.datainclusaoDataGridViewTextBoxColumn.Width = 98;
            // 
            // razaosocialDataGridViewTextBoxColumn
            // 
            this.razaosocialDataGridViewTextBoxColumn.DataPropertyName = "razao_social";
            this.razaosocialDataGridViewTextBoxColumn.HeaderText = "razao_social";
            this.razaosocialDataGridViewTextBoxColumn.Name = "razaosocialDataGridViewTextBoxColumn";
            this.razaosocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.razaosocialDataGridViewTextBoxColumn.Width = 91;
            // 
            // cnpjDataGridViewTextBoxColumn
            // 
            this.cnpjDataGridViewTextBoxColumn.DataPropertyName = "cnpj";
            this.cnpjDataGridViewTextBoxColumn.HeaderText = "cnpj";
            this.cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
            this.cnpjDataGridViewTextBoxColumn.ReadOnly = true;
            this.cnpjDataGridViewTextBoxColumn.Width = 52;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoDataGridViewTextBoxColumn.Width = 77;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            this.bairroDataGridViewTextBoxColumn.Width = 58;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidadeDataGridViewTextBoxColumn.Width = 64;
            // 
            // ufDataGridViewTextBoxColumn
            // 
            this.ufDataGridViewTextBoxColumn.DataPropertyName = "uf";
            this.ufDataGridViewTextBoxColumn.HeaderText = "uf";
            this.ufDataGridViewTextBoxColumn.Name = "ufDataGridViewTextBoxColumn";
            this.ufDataGridViewTextBoxColumn.ReadOnly = true;
            this.ufDataGridViewTextBoxColumn.Width = 41;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 70;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf";
            this.cpf.HeaderText = "cpf";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            this.cpf.Width = 47;
            // 
            // inscricaoDataGridViewTextBoxColumn
            // 
            this.inscricaoDataGridViewTextBoxColumn.DataPropertyName = "inscricao";
            this.inscricaoDataGridViewTextBoxColumn.HeaderText = "inscricao";
            this.inscricaoDataGridViewTextBoxColumn.Name = "inscricaoDataGridViewTextBoxColumn";
            this.inscricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.inscricaoDataGridViewTextBoxColumn.Width = 74;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.aulas_CSharpDataSet2;
            // 
            // aulas_CSharpDataSet2
            // 
            this.aulas_CSharpDataSet2.DataSetName = "Aulas_CSharpDataSet2";
            this.aulas_CSharpDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_BuscarCadastros
            // 
            this.btn_BuscarCadastros.Location = new System.Drawing.Point(226, 507);
            this.btn_BuscarCadastros.Name = "btn_BuscarCadastros";
            this.btn_BuscarCadastros.Size = new System.Drawing.Size(106, 24);
            this.btn_BuscarCadastros.TabIndex = 34;
            this.btn_BuscarCadastros.Text = "Buscar";
            this.btn_BuscarCadastros.UseVisualStyleBackColor = true;
            this.btn_BuscarCadastros.Click += new System.EventHandler(this.btn_BuscarCadastros_Click);
            // 
            // rbtn_PessoaJuridica
            // 
            this.rbtn_PessoaJuridica.AutoSize = true;
            this.rbtn_PessoaJuridica.Location = new System.Drawing.Point(33, 229);
            this.rbtn_PessoaJuridica.Name = "rbtn_PessoaJuridica";
            this.rbtn_PessoaJuridica.Size = new System.Drawing.Size(101, 17);
            this.rbtn_PessoaJuridica.TabIndex = 35;
            this.rbtn_PessoaJuridica.TabStop = true;
            this.rbtn_PessoaJuridica.Text = "Pessoa Jurídica";
            this.rbtn_PessoaJuridica.UseVisualStyleBackColor = true;
            this.rbtn_PessoaJuridica.CheckedChanged += new System.EventHandler(this.VerificarPessoaFouJ);
            // 
            // rbtn_PessoaFisica
            // 
            this.rbtn_PessoaFisica.AutoSize = true;
            this.rbtn_PessoaFisica.Location = new System.Drawing.Point(33, 262);
            this.rbtn_PessoaFisica.Name = "rbtn_PessoaFisica";
            this.rbtn_PessoaFisica.Size = new System.Drawing.Size(92, 17);
            this.rbtn_PessoaFisica.TabIndex = 36;
            this.rbtn_PessoaFisica.TabStop = true;
            this.rbtn_PessoaFisica.Text = "Pessoa Física";
            this.rbtn_PessoaFisica.UseVisualStyleBackColor = true;
            this.rbtn_PessoaFisica.CheckedChanged += new System.EventHandler(this.VerificarPessoaFouJ);
            // 
            // mtb_CPF
            // 
            this.mtb_CPF.Location = new System.Drawing.Point(191, 262);
            this.mtb_CPF.Mask = "000.000.000-00";
            this.mtb_CPF.Name = "mtb_CPF";
            this.mtb_CPF.Size = new System.Drawing.Size(130, 20);
            this.mtb_CPF.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(327, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 25);
            this.label8.TabIndex = 38;
            this.label8.Text = "*";
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Buscar.Location = new System.Drawing.Point(32, 86);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(369, 20);
            this.txt_Buscar.TabIndex = 39;
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.Location = new System.Drawing.Point(30, 60);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(59, 20);
            this.lbl_Buscar.TabIndex = 40;
            this.lbl_Buscar.Text = "Buscar";
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 727);
            this.Controls.Add(this.lbl_Buscar);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtb_CPF);
            this.Controls.Add(this.rbtn_PessoaFisica);
            this.Controls.Add(this.rbtn_PessoaJuridica);
            this.Controls.Add(this.btn_BuscarCadastros);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.lbl_usuCad);
            this.Controls.Add(this.mtb_CNPJ);
            this.Controls.Add(this.mtb_Telefone);
            this.Controls.Add(this.txt_Cidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_DataInclusao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Sucesso);
            this.Controls.Add(this.txt_Endereco);
            this.Controls.Add(this.txt_Uf);
            this.Controls.Add(this.txt_Bairro);
            this.Controls.Add(this.txt_RazaoSocial);
            this.Controls.Add(this.txt_CodigoCliente);
            this.Controls.Add(this.lbl_Tel);
            this.Controls.Add(this.lbl_Uf);
            this.Controls.Add(this.lbl_Bairro);
            this.Controls.Add(this.lbl_Endereco);
            this.Controls.Add(this.lbl_RazaoSocial);
            this.Controls.Add(this.lbl_CodigoCliente);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Confirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroClientes";
            this.Load += new System.EventHandler(this.CadastroClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulas_CSharpDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_CodigoCliente;
        private System.Windows.Forms.Label lbl_RazaoSocial;
        private System.Windows.Forms.Label lbl_Endereco;
        private System.Windows.Forms.Label lbl_Bairro;
        private System.Windows.Forms.Label lbl_Uf;
        private System.Windows.Forms.Label lbl_Tel;
        private System.Windows.Forms.Label lbl_Sucesso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_CodigoCliente;
        public System.Windows.Forms.TextBox txt_RazaoSocial;
        public System.Windows.Forms.TextBox txt_Bairro;
        public System.Windows.Forms.TextBox txt_Uf;
        public System.Windows.Forms.TextBox txt_Endereco;
        public System.Windows.Forms.DateTimePicker dtp_DataInclusao;
        public System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtb_Telefone;
        private System.Windows.Forms.MaskedTextBox mtb_CNPJ;
        private System.Windows.Forms.Label lbl_usuCad;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_BuscarCadastros;
        private System.Windows.Forms.RadioButton rbtn_PessoaJuridica;
        private System.Windows.Forms.RadioButton rbtn_PessoaFisica;
        private System.Windows.Forms.MaskedTextBox mtb_CPF;
        private System.Windows.Forms.Label label8;
        private Aulas_CSharpDataSet2 aulas_CSharpDataSet2;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private Aulas_CSharpDataSet2TableAdapters.ClientesTableAdapter clientesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainclusaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaosocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Label lbl_Buscar;
    }
}