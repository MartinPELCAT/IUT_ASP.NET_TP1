using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD1console.Data;

namespace TD1console
{
    class Program
    {

        public static void Exo2q1()
        {
            using (var ctx = new FilmsDbContext())
            {
                foreach (var u in ctx.Films)
                {
                    Console.WriteLine(u);
                }
            }
            Console.ReadKey();
        }

        public static void Exo2q2()
        {
            using (var ctx = new FilmsDbContext())
            {
                foreach (var u in ctx.Utilisateurs)
                {
                    Console.WriteLine(u.email);
                }
            }
            Console.ReadKey();
        }
        public static void Exo2q3()
        {
            using (var ctx = new FilmsDbContext())
            {
                foreach (var u in ctx.Utilisateurs.OrderBy(u => u.login))
                {
                    Console.WriteLine(u.login);
                }
            }
            Console.ReadKey();
        }

        public static void Exo2q4()
        {
            using (var ctx = new FilmsDbContext())
            {
                foreach (var u in ctx.Films.Include("Categorie1").Where(u => u.Categorie1.nom == "Action"))
                {
                        Console.WriteLine(u);                   
                }
            }
            Console.ReadKey();
        }


        public static void Exo2q5()
        {
            using (var ctx = new FilmsDbContext())
            { 
               var u =  ctx.Categories.ToList().Count();
               Console.WriteLine(u);
     
            }
            Console.ReadKey();
        }

        public static void Exo2q6()
        {
            using (var ctx = new FilmsDbContext())
            {
                var u = ctx.Avis.Min(p => p.note);
                Console.WriteLine(u);

            }
            Console.ReadKey();
        }

        public static void Exo2q7()
        {
            using (var ctx = new FilmsDbContext())
            {
                foreach(var u in ctx.Films.Where(p=>p.nom.StartsWith("ve")))
                {
                    Console.WriteLine(u);
                }          
            }
            Console.ReadKey();
        }


        public static void Exo2q8()
        {
            using (var ctx = new FilmsDbContext())
            {
                var PulpFiction = ctx.Films.Include("Avis1").First(u => u.nom == "Pulp Fiction").Avis1.Average(u => u.note);
                Console.WriteLine(PulpFiction);
                   
            }
            Console.ReadKey();
        }


        public static void Exo2q9()
        {
            using (var ctx = new FilmsDbContext())
            {
                var userMaxNote = ctx.Avis.OrderByDescending(u => u.note).First().UtilisateurAvis;
                Console.WriteLine(userMaxNote);

            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {

            Exo2q9();



        }
    }
}
