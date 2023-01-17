using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models;

public class Location 
{
  public int LocationId { get; set; }
  public string Name { get; set; }
  
  [Required(ErrorMessage = "The Location's Address can't be empty!")]
  public string Address { get; set; }
  public List<Machine> Machines { get; set; }
  public List<Engineer> Engineers { get; set; }
  public List<Incident> Incidents { get; set; }

}