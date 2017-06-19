using Domain.Entities;

namespace Domain
{
    public class DomainFactory
    {
        private static string[] _colors = new[] 
        {
            "Red",
            "Green",
            "Blue",
            "Yellow",
            "Orange",
            "Purple"
        };

        private int _position = 0;

        public Designation CreateDesignation()
        {
            return new Designation(_colors[_position++]);
        }

        public Game CreateGame()
        {
            return new Game();
        }

        public Path CreatePath()
        {
            return new Path();
        }

        public State CreateState()
        {
            return new State();
        }

        public Unit CreateUnit()
        {
            return new Unit();
        }
    }
}