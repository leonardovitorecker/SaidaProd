namespace ControleEstoque1
{
    partial class FrmSaida
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IdProduto = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ValorProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.dataGridViewSaida = new System.Windows.Forms.DataGridView();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.bntConsulta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // bntNovo
            // 
            this.bntNovo.FlatAppearance.BorderSize = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo Produto";
            // 
            // txt_IdProduto
            // 
            this.txt_IdProduto.Location = new System.Drawing.Point(27, 141);
            this.txt_IdProduto.Name = "txt_IdProduto";
            this.txt_IdProduto.Size = new System.Drawing.Size(100, 20);
            this.txt_IdProduto.TabIndex = 3;
            this.txt_IdProduto.TextChanged += new System.EventHandler(this.txt_IdProduto_TextChanged);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(27, 297);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(115, 23);
            this.btn_Adicionar.TabIndex = 4;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor";
            // 
            // txt_ValorProd
            // 
            this.txt_ValorProd.Location = new System.Drawing.Point(27, 192);
            this.txt_ValorProd.Name = "txt_ValorProd";
            this.txt_ValorProd.Size = new System.Drawing.Size(100, 20);
            this.txt_ValorProd.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade";
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Location = new System.Drawing.Point(27, 254);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(100, 20);
            this.txt_Quantidade.TabIndex = 8;
            // 
            // dataGridViewSaida
            // 
            this.dataGridViewSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaida.Location = new System.Drawing.Point(178, 124);
            this.dataGridViewSaida.Name = "dataGridViewSaida";
            this.dataGridViewSaida.Size = new System.Drawing.Size(621, 150);
            this.dataGridViewSaida.TabIndex = 13;
            this.dataGridViewSaida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSaida_CellContentClick);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(673, 281);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(115, 23);
            this.btn_Salvar.TabIndex = 14;
            this.btn_Salvar.Text = "Salvar Pedido";
            this.btn_Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // bntConsulta
            // 
            this.bntConsulta.Location = new System.Drawing.Point(143, 137);
            this.bntConsulta.Name = "bntConsulta";
            this.bntConsulta.Size = new System.Drawing.Size(29, 27);
            this.bntConsulta.TabIndex = 15;
            this.bntConsulta.Text = "...";
            this.bntConsulta.UseVisualStyleBackColor = true;
            this.bntConsulta.Click += new System.EventHandler(this.bntConsulta_Click);
            // 
            // FrmSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntConsulta);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.dataGridViewSaida);
            this.Controls.Add(this.txt_Quantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ValorProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.txt_IdProduto);
            this.Controls.Add(this.label1);
            this.Name = "FrmSaida";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_IdProduto, 0);
            this.Controls.SetChildIndex(this.btn_Adicionar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_ValorProd, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txt_Quantidade, 0);
            this.Controls.SetChildIndex(this.dataGridViewSaida, 0);
            this.Controls.SetChildIndex(this.btn_Salvar, 0);
            this.Controls.SetChildIndex(this.bntConsulta, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IdProduto;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ValorProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.DataGridView dataGridViewSaida;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button bntConsulta;
    }
}
