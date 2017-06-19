using System.Collections.Generic;

namespace Domain.Entities
{
    public class Game
    {
        public List<State> States { get; set; }
        public List<Designation> Designations { get; set; }
        internal Game()
        {
            States = new List<State>();
            Designations = new List<Designation>();
        }
    }
}