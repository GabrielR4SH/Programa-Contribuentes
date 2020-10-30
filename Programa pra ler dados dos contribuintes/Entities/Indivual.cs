using System;
using System.Collections.Generic;
using System.Text;
using Programa_pra_ler_dados_dos_contribuintes.Entities;

namespace Programa_pra_ler_dados_dos_contribuintes.Entities
{
    class Indivual : TaxPayer
    {

        public double HealthExpenditures { get; set; }

        public Indivual()
        {

        }

        public Indivual(string name, double anualIncome, double healthExpenditures) 
            : base(name,anualIncome)

        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.0)
            {
                return AnualIncome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
            
        }
    }
    
   }

