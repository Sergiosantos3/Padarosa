namespace Padarosa
{
    partial class FrmComandas
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
            this.dgvComnadas = new System.Windows.Forms.DataGridView();
            this.grbInformaçoes = new System.Windows.Forms.GroupBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.lblproduto = new System.Windows.Forms.Label();
            this.lblComanda = new System.Windows.Forms.Label();
            this.grbLançamento = new System.Windows.Forms.GroupBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txbquantidade = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCamcelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComnadas)).BeginInit();
            this.grbInformaçoes.SuspendLayout();
            this.grbLançamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComnadas
            // 
            this.dgvComnadas.AllowUserToAddRows = false;
            this.dgvComnadas.AllowUserToDeleteRows = false;
            this.dgvComnadas.AllowUserToResizeColumns = false;
            this.dgvComnadas.AllowUserToResizeRows = false;
            this.dgvComnadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComnadas.BackgroundColor = System.Drawing.Color.White;
            this.dgvComnadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComnadas.Location = new System.Drawing.Point(12, 12);
            this.dgvComnadas.Name = "dgvComnadas";
            this.dgvComnadas.ReadOnly = true;
            this.dgvComnadas.Size = new System.Drawing.Size(480, 555);
            this.dgvComnadas.TabIndex = 1;
            this.dgvComnadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComnadas_CellClick);
            // 
            // grbInformaçoes
            // 
            this.grbInformaçoes.Controls.Add(this.btnContinuar);
            this.grbInformaçoes.Controls.Add(this.txbProduto);
            this.grbInformaçoes.Controls.Add(this.txbComanda);
            this.grbInformaçoes.Controls.Add(this.lblproduto);
            this.grbInformaçoes.Controls.Add(this.lblComanda);
            this.grbInformaçoes.ForeColor = System.Drawing.Color.White;
            this.grbInformaçoes.Location = new System.Drawing.Point(498, 12);
            this.grbInformaçoes.Name = "grbInformaçoes";
            this.grbInformaçoes.Size = new System.Drawing.Size(410, 229);
            this.grbInformaçoes.TabIndex = 7;
            this.grbInformaçoes.TabStop = false;
            this.grbInformaçoes.Text = "Informações";
            // 
            // btnContinuar
            // 
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnContinuar.Location = new System.Drawing.Point(16, 160);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(388, 43);
            this.btnContinuar.TabIndex = 11;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txbProduto
            // 
            this.txbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProduto.Location = new System.Drawing.Point(154, 92);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.Size = new System.Drawing.Size(250, 44);
            this.txbProduto.TabIndex = 10;
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(154, 23);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(250, 44);
            this.txbComanda.TabIndex = 9;
            // 
            // lblproduto
            // 
            this.lblproduto.AutoSize = true;
            this.lblproduto.BackColor = System.Drawing.Color.Black;
            this.lblproduto.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproduto.ForeColor = System.Drawing.Color.White;
            this.lblproduto.Location = new System.Drawing.Point(12, 92);
            this.lblproduto.Name = "lblproduto";
            this.lblproduto.Size = new System.Drawing.Size(136, 39);
            this.lblproduto.TabIndex = 8;
            this.lblproduto.Text = "Produto:";
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.ForeColor = System.Drawing.Color.White;
            this.lblComanda.Location = new System.Drawing.Point(3, 28);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(145, 39);
            this.lblComanda.TabIndex = 7;
            this.lblComanda.Text = "Comanda:";
            // 
            // grbLançamento
            // 
            this.grbLançamento.Controls.Add(this.btnLancar);
            this.grbLançamento.Controls.Add(this.txbquantidade);
            this.grbLançamento.Controls.Add(this.txbNome);
            this.grbLançamento.Controls.Add(this.lblQuantidade);
            this.grbLançamento.Controls.Add(this.label2);
            this.grbLançamento.Enabled = false;
            this.grbLançamento.ForeColor = System.Drawing.Color.White;
            this.grbLançamento.Location = new System.Drawing.Point(498, 296);
            this.grbLançamento.Name = "grbLançamento";
            this.grbLançamento.Size = new System.Drawing.Size(410, 220);
            this.grbLançamento.TabIndex = 8;
            this.grbLançamento.TabStop = false;
            this.grbLançamento.Text = "Lançamento";
            // 
            // btnLancar
            // 
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancar.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnLancar.Location = new System.Drawing.Point(16, 147);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(388, 43);
            this.btnLancar.TabIndex = 11;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // txbquantidade
            // 
            this.txbquantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbquantidade.Location = new System.Drawing.Point(183, 83);
            this.txbquantidade.Name = "txbquantidade";
            this.txbquantidade.Size = new System.Drawing.Size(221, 44);
            this.txbquantidade.TabIndex = 10;
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(183, 19);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(221, 44);
            this.txbNome.TabIndex = 9;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblQuantidade.Location = new System.Drawing.Point(12, 84);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(176, 39);
            this.lblQuantidade.TabIndex = 8;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Comanda:";
            // 
            // btnCamcelar
            // 
            this.btnCamcelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamcelar.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamcelar.ForeColor = System.Drawing.Color.Crimson;
            this.btnCamcelar.Location = new System.Drawing.Point(498, 524);
            this.btnCamcelar.Name = "btnCamcelar";
            this.btnCamcelar.Size = new System.Drawing.Size(404, 43);
            this.btnCamcelar.TabIndex = 12;
            this.btnCamcelar.Text = "Cancelar";
            this.btnCamcelar.UseVisualStyleBackColor = true;
            this.btnCamcelar.Click += new System.EventHandler(this.btnCamcelar_Click);
            // 
            // FrmComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(920, 579);
            this.Controls.Add(this.btnCamcelar);
            this.Controls.Add(this.grbLançamento);
            this.Controls.Add(this.grbInformaçoes);
            this.Controls.Add(this.dgvComnadas);
            this.Name = "FrmComandas";
            this.Text = "FrmComandacs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComnadas)).EndInit();
            this.grbInformaçoes.ResumeLayout(false);
            this.grbInformaçoes.PerformLayout();
            this.grbLançamento.ResumeLayout(false);
            this.grbLançamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComnadas;
        private System.Windows.Forms.GroupBox grbInformaçoes;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Label lblproduto;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.GroupBox grbLançamento;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.TextBox txbquantidade;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCamcelar;
    }
}