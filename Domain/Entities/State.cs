using System.Collections.Generic;

namespace Domain.Entities
{
    public class State
    {
        public List<Unit> Units { get; set; }
        internal State()
        {
            Units = new List<Unit>();
        }
    }
}