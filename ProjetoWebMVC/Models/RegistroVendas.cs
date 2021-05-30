using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWebMVC.Models
{
    public class RegistroVendas
    {
        public int Id{ get; set; }
        public DateTime Data { get; set; }
        public double  Resultar{ get; set; }
        public StatusVendas Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVendas()
        {

        }

        public RegistroVendas(int id, DateTime data, double resultar, StatusVendas status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Resultar = resultar;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
