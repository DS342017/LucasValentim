using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMVC.Models
{
    public class Pedido
    {
        [Key]
        [DisplayName("Pedido")]
        public int IdPedido { get; set; }
        [DisplayName("Nome do Medicamento")]
        [Required(ErrorMessage ="*Preenchimento Obrigatório")]
        public string NomeMedicamento { get; set; }
        [DisplayName("Qtde de Medicamento")]
        [Required(ErrorMessage = "*Preenchimento Obrigatório")]
        public string QtdeMedicamento { get; set; }
        [DisplayName("Codigo Cliente")]
        [Required(ErrorMessage = "*Preenchimento Obrigatório")]
        public string CodCliente { get; set; }
        [DisplayName("Data de Entrega")]
        [Required(ErrorMessage = "*Preenchimento Obrigatório")]
        [DataType(DataType.Date)]
        public string DataEntrega { get; set; }
    }
}