using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class MyEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MyEntity> RecursiveEntities { get; set; }

        public MyEntity()
        {
            this.RecursiveEntities = new List<MyEntity>();
        }
    }
}
