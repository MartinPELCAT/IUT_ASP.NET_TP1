using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD1console.Data;

namespace TD1console.Data
{
    public partial class Film
    {

        public override string ToString()
        {
            return "---------------------\nNom : " + nom + "\nDescription : " + description; 
        }


    }
}
