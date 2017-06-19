using System.Collections.Generic;

namespace Domain.Entities
{
    public class Designation
    {
        public string Color { get; private set; }
        public List<Path> Paths { get; set; }

        internal Designation(string color)
        {
            Color = color;
            Paths = new List<Path>();
        }
    }
}