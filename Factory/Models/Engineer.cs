using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    // properties, constructors, methods, etc. go here
    public int EngineerId { get; set; }
    public string Name { get; set; }
    public string ContactNumber { get; set; }
    public List<EngineerMachine> JoinEntities { get; set; }

  }
}