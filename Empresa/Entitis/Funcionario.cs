using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Entitis
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorHora { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string nome, int horas, double valorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorHora = valorHora;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\n" +
                   $"Pagamento: {Pagamento():C}";
        }

        public virtual double Pagamento()
        {
            return ValorHora * Horas;
        }
    }
}
