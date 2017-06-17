using System.Collections.Generic;

namespace Domain.Entities
{
    public class Game
    {
        public List<State> States { get; set; }
        internal Game()
        {
            States = new List<State>();
        }
    }
}