using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using TeatrProject.Enums;
using TeatrProject.Services;
using Core.Services.Contracts;

namespace TeatrProject.Models
{
    internal class Ticket : Entity
    {
        internal Seans Seans { get; set; }

        internal int Row { get; set; }

        internal int Column { get; set; }

        public override string ToString()
        {
            return $"Seans: {Seans}, row: {Row}, Column: {Column}";
        }
    }
}
