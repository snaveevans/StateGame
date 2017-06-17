using System.Collections.Generic;

namespace ConsoleApp.Entities
{
    public class Game
    {
        public List<State> States { get; set; }
        public List<Designation> Designations { get; set; }

        public Game()
        {
            States = new List<State>();
            Designations = new List<Designation>();
        }
    }
}