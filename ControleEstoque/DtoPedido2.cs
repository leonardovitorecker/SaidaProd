using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque1
{
    public class DtoPedido2
    {
        public int id { get; set; }

        public int idProduto { get; set; }
        public string nomeCliente { get; set; }
        public decimal valorPedido { get; set; }
        public decimal quantidadePedido { get; set; }
    }
}
