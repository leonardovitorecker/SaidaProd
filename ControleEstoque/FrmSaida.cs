using ControleEstoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleEstoque1
{
    public partial class FrmSaida : ControleEstoque.FrmBase
    {
        public FrmSaida()
        {
            InitializeComponent();
        }


        private void bntConsulta_Click(object sender, EventArgs e)
        {

            FrmConsulta c = new FrmConsulta();
            c.ShowDialog();
            if (c.idProduto != 0)
            {
                txt_IdProduto.Text = c.idProduto.ToString();
                txt_IdProduto.Focus();
                txt_ValorProd.Focus();
                txt_Quantidade.Focus();
            }
        }


        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            Model get = new Model();
            List<DtoProduto2> lista = get.ListProdutos();
            this.dataGridViewSaida.DataSource = lista;
            this.dataGridViewSaida.Refresh();

        }fdfefefwefwe
        private void dataGridViewSaida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }

}