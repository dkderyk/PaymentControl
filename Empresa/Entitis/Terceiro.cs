using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Entitis
{
    public class Terceiro : Funcionario
    {
        public double Adicional { get; set; }

        public Terceiro()
        { 
        }

        public Terceiro(string nome, int horas, double valorHora, double adicional) : base(nome, horas, valorHora)
        {
            Adicional = adicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * Adicional;
        }
    }
}
