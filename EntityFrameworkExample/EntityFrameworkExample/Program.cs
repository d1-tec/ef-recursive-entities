using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ExampleContext())
            {
                MyEntity owner = new MyEntity { Name = "I'm the owner" };
                owner.RecursiveEntities.Add(new MyEntity { Name = "Recursive 1" });
                owner.RecursiveEntities.Add(new MyEntity { Name = "Recursive 2" });

                context.Entities.Add(owner);
                context.SaveChanges();
            }

            Console.ReadLine();
        }
    }
}
