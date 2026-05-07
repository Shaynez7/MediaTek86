using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// Table Responsable de la base de données
    /// </summary>
    public class Responsable
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>

        public Responsable(string login, string pwd)
        {
            this.Login = login;
            this.Pwd = pwd;
        }

        public string Login { get; set; }
        public string Pwd { get; set; }
    }
}
