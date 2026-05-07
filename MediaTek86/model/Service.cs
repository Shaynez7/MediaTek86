using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// Table Service de la base de données
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>

        public Service(int idservice, string nom)
        {
            this.Idservice = idservice;
            this.Nom = nom;
        }

        public int Idservice { get; set; }
        public string Nom { get; set; }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du service</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
