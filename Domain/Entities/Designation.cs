using System.Collections.Generic;

namespace Domain.Entities
{
    public class Designation
    {
        public List<Path> Paths { get; set; }

        internal Designation()
        {
            Paths = new List<Path>();
        }
    }
}