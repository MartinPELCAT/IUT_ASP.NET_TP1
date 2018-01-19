using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1console.Data
{
    public partial class Avi
    {
        
        public override string ToString()
        {
            return "---------------------\nIdFilm " + film + "\nIdUtilisateur " + utilisateur + "\nAvis " + avis + "\nNote " + note;
        }
    }
}
