using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWebMVC.Models
{
    public class Vendedor
    {
       

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }
        public double SalarioBase{ get; set; }
        public Departamento Departamento { get; set; }//ASSOCIAÇÃO DE  VENDEDOR COM  DEPARTAMENTO
        public ICollection<RegistroVendas> Vendas { get; set; } = new List<RegistroVendas>();// ASSOCIAÇÃO DE VENDEDOR COM REGISTRO DE VENDAS

        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, DateTime dataNasc, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNasc = dataNasc;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        // METODOS CUSTOMIZADOS
        public void AdicionarVendas( RegistroVendas rv)// adicionar 
        {
            Vendas.Add(rv);
        }
        public void RemoverVendas(RegistroVendas rv)// remover
        {
            Vendas.Remove(rv);
        }
        public double TotalDeVendas (DateTime inicial,DateTime final)// calculo de vendas no perido de data
        {
            return Vendas.Where(rv => rv.Data >= inicial && rv.Data <= final).Sum(rv => rv.Resultar);
        }
    }
}
