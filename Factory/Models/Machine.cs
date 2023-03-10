using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Factory.Models
{
  public class Machine
  {
    // properties, constructors, methods, etc. go here
    public int MachineId { get; set; }

    [Required(ErrorMessage = "The Machines's Name can't be empty!")]
    public string Name { get; set; }

    [Required(ErrorMessage = "The Machine's Description can't be empty!")]
    public string Description { get; set; }    
    public DateTime LastServiced { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [Column(TypeName="date")]
    public DateTime NextService { get; set; }
    public bool IsOperational { get; set; }
    public bool UnderRepair { get; set; }
    public int LocationId { get; set; }
    public Location Location { get; set; }
    public List<EngineerMachine> JoinEntities { get; set; }
    public List<Incident> Incidents { get; set; }

  }
}