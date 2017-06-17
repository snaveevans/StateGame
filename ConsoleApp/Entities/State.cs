using System.Collections.Generic;

namespace ConsoleApp.Entities
{
    public class State
    {
        public List<Unit> Units { get; set; }
        public State()
        {
            Units = new List<Unit>();
        }
    }
}