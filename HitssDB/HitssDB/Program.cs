using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using HitssDB.Classes;

namespace HitssDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {

                Console.Write("Enter role name:");
                var rolname = Console.ReadLine();
                Console.Write("Enter role description:");
                var roldesc = Console.ReadLine();

                var rol = new Cat_Role { name = rolname, description = roldesc };
                db.cat_Roles.Add(rol);
        
                db.SaveChanges();

               
            }

            using (var db = new Context())
            {

                Console.Write("Enter Comany name:");
                var comname = Console.ReadLine();
                Console.Write("Enter company description:");
                var desc = Console.ReadLine();
                Console.Write("Enter company startdate:");
                var date = Console.ReadLine();

                var rol = new Company { name = comname, description = desc, startdate = date };
                db.companies.Add(rol);

                db.SaveChanges();

                
            }

            using (var db = new Context())
            {

                Console.Write("Enter client name:");
                var clientname = Console.ReadLine();
                Console.Write("Enter cient description:");
                var clientdesc = Console.ReadLine();

                var rol = new Client { name = clientname, description = clientdesc };
                db.clients.Add(rol);

                db.SaveChanges();

                Console.ReadKey();
            }
        }
    }
}
