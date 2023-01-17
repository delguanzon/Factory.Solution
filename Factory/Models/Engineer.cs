using System;
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
    [Display(Name = "Contact Number")]
    public string ContactNumber { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [Display(Name = "License Expiry Date")]
    public DateTime LicenseExpiry { get; set; }
    public bool isIdle { get; set; }
    public int LocationId { get; set; }
    public Location Location { get; set; }
    public List<EngineerMachine> JoinEntities { get; set; }
    public List<Incident> Incidents { get; set; }

  }
}