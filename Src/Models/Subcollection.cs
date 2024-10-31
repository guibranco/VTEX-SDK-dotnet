using System;
using System.Collections.Generic;

namespace Models
{
    public class Subcollection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Brand> Brands { get; set; }
    }
}
