using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Domain.Entities
{
    public class Region
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}