namespace ConsoleApp.Entities
{
    public class Path
    {
        public State Origin { get; set; }
        public State Destination { get; set; }
        public Designation Designation { get; set; }
        public Path(Designation designation)
        {
            Designation = designation;
        }
    }
}