using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebMVC.Models
{
    public class PedidoContext : DbContext
    {
        DbSet<Pedido> pedidos;
        public System.Data.Entity.DbSet<WebMVC.Models.Pedido> Pedidoes { get; set; }
    }
}