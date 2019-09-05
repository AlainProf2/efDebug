using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efDebug
{
    public class Proprietaire
    {
        public int
        ProprietaireId
        { get; set; }

        public string Nom { get; set; }

        public int Liquidite { get; set; }
        [NotMapped]
        public int ValeurBoursiere { get; set; }

        public DateTime Naissance { get; set; }

    

        //collection navigation property
       // public ICollection<Transaction> Possession { get; set; }

        public Proprietaire()
        {
           // Possession = new Collection<Transaction>();
        }

    }
}
