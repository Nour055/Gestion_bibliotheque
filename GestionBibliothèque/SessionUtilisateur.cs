using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GestionBibliothèque
{
    class SessionUtilisateur
    {
        public static string Email { get; set; }
        public static int Id { get; set; }
        public static string Nom { get; set; }
        public static string Prenom { get; set; }
        public static void Clear()
        {
            Email = null;
            Nom = null;
            Prenom = null;

            Id = 0;
        }

    }
}
