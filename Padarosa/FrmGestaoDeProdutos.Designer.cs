namespace Padarosa
{
    partial class FrmGestaoDeProdutos
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
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.lblApagar = new System.Windows.Forms.Label();
            this.btnApagarProduto = new System.Windows.Forms.Button();
            this.grbEdicao = new System.Windows.Forms.GroupBox();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.txbEditarPreco = new System.Windows.Forms.TextBox();
            this.txbEditarCategoria = new System.Windows.Forms.TextBox();
            this.txbEditarProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEditarProduto = new System.Windows.Forms.Label();
            this.grbCadastroProdutos = new System.Windows.Forms.GroupBox();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.txbCadastrarPreco = new System.Windows.Forms.TextBox();
            this.txbCadastrarCategoria = new System.Windows.Forms.TextBox();
            this.txbCadastrarProdutos = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbApagar.SuspendLayout();
            this.grbEdicao.SuspendLayout();
            this.grbCadastroProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.lblApagar);
            this.grbApagar.Controls.Add(this.btnApagarProduto);
            this.grbApagar.Enabled = false;
            this.grbApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbApagar.Location = new System.Drawing.Point(44, 518);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(754, 58);
            this.grbApagar.TabIndex = 12;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Location = new System.Drawing.Point(20, 29);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(292, 20);
            this.lblApagar.TabIndex = 1;
            this.lblApagar.Text = "Selecione o ususario que deseja apagar";
            // 
            // btnApagarProduto
            // 
            this.btnApagarProduto.BackColor = System.Drawing.Color.Snow;
            this.btnApagarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarProduto.ForeColor = System.Drawing.Color.Red;
            this.btnApagarProduto.Location = new System.Drawing.Point(617, 19);
            this.btnApagarProduto.Name = "btnApagarProduto";
            this.btnApagarProduto.Size = new System.Drawing.Size(131, 30);
            this.btnApagarProduto.TabIndex = 9;
            this.btnApagarProduto.Text = "Apagar";
            this.btnApagarProduto.UseVisualStyleBackColor = false;
            this.btnApagarProduto.Click += new System.EventHandler(this.btnApagarProduto_Click);
            // 
            // grbEdicao
            // 
            this.grbEdicao.Controls.Add(this.btnEditarProduto);
            this.grbEdicao.Controls.Add(this.txbEditarPreco);
            this.grbEdicao.Controls.Add(this.txbEditarCategoria);
            this.grbEdicao.Controls.Add(this.txbEditarProduto);
            this.grbEdicao.Controls.Add(this.label1);
            this.grbEdicao.Controls.Add(this.label2);
            this.grbEdicao.Controls.Add(this.lblEditarProduto);
            this.grbEdicao.Enabled = false;
            this.grbEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEdicao.Location = new System.Drawing.Point(429, 325);
            this.grbEdicao.Name = "grbEdicao";
            this.grbEdicao.Size = new System.Drawing.Size(369, 187);
            this.grbEdicao.TabIndex = 11;
            this.grbEdicao.TabStop = false;
            this.grbEdicao.Text = "Edição";
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarProduto.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProduto.Location = new System.Drawing.Point(19, 137);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(344, 39);
            this.btnEditarProduto.TabIndex = 8;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = false;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // txbEditarPreco
            // 
            this.txbEditarPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEditarPreco.Location = new System.Drawing.Point(151, 66);
            this.txbEditarPreco.Name = "txbEditarPreco";
            this.txbEditarPreco.Size = new System.Drawing.Size(212, 29);
            this.txbEditarPreco.TabIndex = 6;
            // 
            // txbEditarCategoria
            // 
            this.txbEditarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEditarCategoria.Location = new System.Drawing.Point(151, 100);
            this.txbEditarCategoria.Name = "txbEditarCategoria";
            this.txbEditarCategoria.Size = new System.Drawing.Size(212, 31);
            this.txbEditarCategoria.TabIndex = 7;
            // 
            // txbEditarProduto
            // 
            this.txbEditarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEditarProduto.Location = new System.Drawing.Point(151, 32);
            this.txbEditarProduto.Name = "txbEditarProduto";
            this.txbEditarProduto.Size = new System.Drawing.Size(212, 29);
            this.txbEditarProduto.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "categoria";
            // 
            // lblEditarProduto
            // 
            this.lblEditarProduto.AutoSize = true;
            this.lblEditarProduto.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarProduto.Location = new System.Drawing.Point(15, 32);
            this.lblEditarProduto.Name = "lblEditarProduto";
            this.lblEditarProduto.Size = new System.Drawing.Size(70, 21);
            this.lblEditarProduto.TabIndex = 0;
            this.lblEditarProduto.Text = "Produto";
            // 
            // grbCadastroProdutos
            // 
            this.grbCadastroProdutos.Controls.Add(this.btnCadastrarProduto);
            this.grbCadastroProdutos.Controls.Add(this.txbCadastrarPreco);
            this.grbCadastroProdutos.Controls.Add(this.txbCadastrarCategoria);
            this.grbCadastroProdutos.Controls.Add(this.txbCadastrarProdutos);
            this.grbCadastroProdutos.Controls.Add(this.lblPreco);
            this.grbCadastroProdutos.Controls.Add(this.lblCategoria);
            this.grbCadastroProdutos.Controls.Add(this.lblNomeProduto);
            this.grbCadastroProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastroProdutos.Location = new System.Drawing.Point(44, 325);
            this.grbCadastroProdutos.Name = "grbCadastroProdutos";
            this.grbCadastroProdutos.Size = new System.Drawing.Size(369, 187);
            this.grbCadastroProdutos.TabIndex = 10;
            this.grbCadastroProdutos.TabStop = false;
            this.grbCadastroProdutos.Text = "Cadastro";
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.Location = new System.Drawing.Point(19, 137);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(344, 39);
            this.btnCadastrarProduto.TabIndex = 4;
            this.btnCadastrarProduto.Text = "Cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // txbCadastrarPreco
            // 
            this.txbCadastrarPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCadastrarPreco.Location = new System.Drawing.Point(151, 66);
            this.txbCadastrarPreco.Name = "txbCadastrarPreco";
            this.txbCadastrarPreco.Size = new System.Drawing.Size(212, 29);
            this.txbCadastrarPreco.TabIndex = 2;
            // 
            // txbCadastrarCategoria
            // 
            this.txbCadastrarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCadastrarCategoria.Location = new System.Drawing.Point(151, 100);
            this.txbCadastrarCategoria.Name = "txbCadastrarCategoria";
            this.txbCadastrarCategoria.Size = new System.Drawing.Size(212, 31);
            this.txbCadastrarCategoria.TabIndex = 3;
            // 
            // txbCadastrarProdutos
            // 
            this.txbCadastrarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCadastrarProdutos.Location = new System.Drawing.Point(151, 32);
            this.txbCadastrarProdutos.Name = "txbCadastrarProdutos";
            this.txbCadastrarProdutos.Size = new System.Drawing.Size(212, 29);
            this.txbCadastrarProdutos.TabIndex = 1;
            this.txbCadastrarProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbCadastrarProdutos_KeyDown);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(20, 74);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(51, 21);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Preço";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(14, 103);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(92, 25);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(15, 32);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(70, 21);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Produto";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(44, 21);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(754, 277);
            this.dgvProdutos.TabIndex = 9;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // FrmGestaoDeProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 597);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEdicao);
            this.Controls.Add(this.grbCadastroProdutos);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "FrmGestaoDeProdutos";
            this.Text = "FrmGestaoDeProdutos";
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.grbEdicao.ResumeLayout(false);
            this.grbEdicao.PerformLayout();
            this.grbCadastroProdutos.ResumeLayout(false);
            this.grbCadastroProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.Button btnApagarProduto;
        private System.Windows.Forms.GroupBox grbEdicao;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.TextBox txbEditarPreco;
        private System.Windows.Forms.TextBox txbEditarCategoria;
        private System.Windows.Forms.TextBox txbEditarProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEditarProduto;
        private System.Windows.Forms.GroupBox grbCadastroProdutos;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.TextBox txbCadastrarPreco;
        private System.Windows.Forms.TextBox txbCadastrarCategoria;
        private System.Windows.Forms.TextBox txbCadastrarProdutos;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.DataGridView dgvProdutos;
    }
}