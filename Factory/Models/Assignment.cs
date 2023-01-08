namespace Factory.Models
{
  public class Assignment
  {
    // properties, constructors, methods, etc. go here
    public int AssignmentId { get; set; }
    public int EngineerId { get; set; }
    public Engineer Engineer { get; set; }
    public int MachineId { get; set; }
    public Machine Machine { get; set; }

  }
}