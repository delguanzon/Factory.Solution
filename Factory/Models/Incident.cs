using System;

namespace Factory.Models;

public class Incident
{
  public int IncidentId { get; set; }
  public string Description { get; set; }
  public bool IsResolved { get; set; }
  public DateTime StartDate { get; set; }
  public DateTime EndDate { get; set; }
  public int LocationId { get; set; }
  public Location Location { get; set; }
  public int EngineerId { get; set; }
  public Engineer Engineer { get; set; }
  public int MachineId { get; set; }
  public Machine Machine { get; set; }
}