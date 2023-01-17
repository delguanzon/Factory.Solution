using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    // properties, constructors, methods, etc. go here
    public int EngineerId { get; set; }

    [Required(ErrorMessage = "The Engineers's Name can't be empty!")]
    public string Name { get; set; }

    [Required(ErrorMessage = "The Engineers's Contact Number can't be empty!")]
    public string ContactNumber { get; set; }

    public int LocationId { get; set; }
    public Location Location { get; set; }
    public List<EngineerMachine> JoinEntities { get; set; }
    public List<Incident> Incidents { get; set; }

  }
}