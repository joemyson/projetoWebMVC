using System;
using System.Collections.Generic;
using System.Linq;


namespace ProjetoWebMVC.Models

{    // criado o model do departamento 1º
    public class Departamento // CLASSE BASICA
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public ICollection<Vendedores> Vendedores { get; set; } = new List<Vendedores>();//ASSOCIAÇÃO DE DEPARTAMENTO COM VENDEDOR

        public Departamento()
        {

        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public void AdicionarVendedor(Vendedores vendedor)
        {
            Vendedores.Add(vendedor);
        }
        public double TotalVendas( DateTime inicial,DateTime final)
        {
            return Vendedores.Sum(Vendedor => Vendedor.TotalDeVendas(inicial, final));
;        }
    }
}
