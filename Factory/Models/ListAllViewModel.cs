using System.Collections.Generic;

namespace Factory.Models
{
  public class ListAllViewModel
  {
    // properties, constructors, methods, etc. go here
    public List<Engineer> Engineers { get; set; }
    public List<Machine> Machines { get; set; }
    public List<Location> Locations { get; set; }
    public List<Incident> Incidents { get; set; }

  }
}