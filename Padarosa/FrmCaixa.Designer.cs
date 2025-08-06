namespace Padarosa
{
    partial class FrmCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaixa));
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.lblNcomanda = new System.Windows.Forms.Label();
            this.txbNcomanda = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.chbPagamentoRecebido = new System.Windows.Forms.CheckBox();
            this.btnEncerrarComanda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaixa.BackgroundColor = System.Drawing.Color.White;
            this.dgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixa.Location = new System.Drawing.Point(-1, 61);
            this.dgvCaixa.Name = "dgvCaixa";
            this.dgvCaixa.Size = new System.Drawing.Size(654, 532);
            this.dgvCaixa.TabIndex = 0;
            // 
            // lblNcomanda
            // 
            this.lblNcomanda.AutoSize = true;
            this.lblNcomanda.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNcomanda.ForeColor = System.Drawing.Color.White;
            this.lblNcomanda.Location = new System.Drawing.Point(12, 9);
            this.lblNcomanda.Name = "lblNcomanda";
            this.lblNcomanda.Size = new System.Drawing.Size(239, 46);
            this.lblNcomanda.TabIndex = 1;
            this.lblNcomanda.Text = "N º Comanda";
            // 
            // txbNcomanda
            // 
            this.txbNcomanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNcomanda.Location = new System.Drawing.Point(257, 17);
            this.txbNcomanda.Name = "txbNcomanda";
            this.txbNcomanda.Size = new System.Drawing.Size(211, 38);
            this.txbNcomanda.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(659, 408);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(302, 85);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "R$ 49,5";
            // 
            // btnListar
            // 
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.White;
            this.btnListar.Location = new System.Drawing.Point(479, 17);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(174, 38);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // chbPagamentoRecebido
            // 
            this.chbPagamentoRecebido.AutoSize = true;
            this.chbPagamentoRecebido.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPagamentoRecebido.ForeColor = System.Drawing.Color.White;
            this.chbPagamentoRecebido.Location = new System.Drawing.Point(659, 504);
            this.chbPagamentoRecebido.Name = "chbPagamentoRecebido";
            this.chbPagamentoRecebido.Size = new System.Drawing.Size(264, 35);
            this.chbPagamentoRecebido.TabIndex = 5;
            this.chbPagamentoRecebido.Text = "Pagamento Recebido";
            this.chbPagamentoRecebido.UseVisualStyleBackColor = true;
            this.chbPagamentoRecebido.CheckedChanged += new System.EventHandler(this.chbPagamentoRecebido_CheckedChanged);
            // 
            // btnEncerrarComanda
            // 
            this.btnEncerrarComanda.Enabled = false;
            this.btnEncerrarComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrarComanda.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrarComanda.ForeColor = System.Drawing.Color.LightGreen;
            this.btnEncerrarComanda.Location = new System.Drawing.Point(659, 545);
            this.btnEncerrarComanda.Name = "btnEncerrarComanda";
            this.btnEncerrarComanda.Size = new System.Drawing.Size(382, 48);
            this.btnEncerrarComanda.TabIndex = 6;
            this.btnEncerrarComanda.Text = "Encerrar Comanda";
            this.btnEncerrarComanda.UseVisualStyleBackColor = true;
            this.btnEncerrarComanda.Click += new System.EventHandler(this.btnEncerrarComanda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(659, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 388);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1043, 605);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEncerrarComanda);
            this.Controls.Add(this.chbPagamentoRecebido);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txbNcomanda);
            this.Controls.Add(this.lblNcomanda);
            this.Controls.Add(this.dgvCaixa);
            this.Name = "FrmCaixa";
            this.Text = "FrmCaixacs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCaixa;
        private System.Windows.Forms.Label lblNcomanda;
        private System.Windows.Forms.TextBox txbNcomanda;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.CheckBox chbPagamentoRecebido;
        private System.Windows.Forms.Button btnEncerrarComanda;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}