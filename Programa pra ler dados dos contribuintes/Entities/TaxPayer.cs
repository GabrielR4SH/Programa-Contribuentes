using System;
using System.Collections.Generic;
using System.Text;

namespace Programa_pra_ler_dados_dos_contribuintes.Entities
{
    abstract class TaxPayer 
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer()
        {

        }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
