using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1console.Data
{
    public partial class Utilisateur
    {

        public override string ToString()
        {
            return "---------------------\nLogin " + login + "\nEmail " + email + "\nPassword " + password;
        }
    }
}
