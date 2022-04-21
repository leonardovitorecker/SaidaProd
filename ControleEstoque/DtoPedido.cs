using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ControleEstoque1
{
    [Table("pedido", Schema = "public")]
    public class DtoPedido

    {

        [Key]
        public int id { get; set; }
        public int idProduto {get;set;}
        public string nomeCliente { get; set; }
        public decimal valorPedido { get; set;}
        public decimal quantidadePedido { get; set; }
    }
}
