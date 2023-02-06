using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace TeatrProject.Models
{
    
        internal class Film : Entity
        {
            internal string Name { get; set; }

            public override string ToString()
            {
                return $"Film: {Name}";
            }
        }
    
}
