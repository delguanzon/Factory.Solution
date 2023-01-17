using System.Collections.Generic;
using Factory.Models;
using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryDBInitializer
  {
      private readonly ModelBuilder modelBuilder;

      public FactoryDBInitializer(ModelBuilder modelBuilder)
      {
          this.modelBuilder = modelBuilder;
      }

      public void Seed()
      {
          modelBuilder.Entity<Location>().HasData(
                new Location(){ LocationId = 1, Name="Seattle", Address="123 Main St" },
                new Location(){ LocationId = 2, Name="Portland", Address="456 Main St" },
                new Location(){ LocationId = 3, Name="Tacoma", Address="789 Main St" },
                new Location(){ LocationId = 4, Name="Tilamook", Address="1011 Main St" }
        );
    }
  }
}
