using System;
using System.Collections.Generic;

namespace ConsoleApp.Entities
{
    public class Designation
    {
        public Guid Id { get; set; }
        public List<Path> Paths { get; set; }

        public Designation()
        {
            Id = Guid.NewGuid();
        }
    }
}