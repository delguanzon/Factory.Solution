using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Factory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Factory.Controllers
{
    public class EngineersController : Controller
    {

        private readonly FactoryContext _db;

        public EngineersController(FactoryContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Engineer> model = _db.Engineers.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.LocationId = new SelectList(_db.Locations, "LocationId", "Name");
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Engineer engineer)
        {   
            if (!ModelState.IsValid)
            {
                return View();
            }
            else 
            {
                _db.Add(engineer);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
            

        public ActionResult Details(int id) 
        {
            Engineer thisEngineer = _db.Engineers
                .Include(engineer => engineer.Location)
                .Include(engineer => engineer.JoinEntities)
                .ThenInclude(join => join.Machine)
                .FirstOrDefault(engineer => engineer.EngineerId == id);
            return View(thisEngineer);
        }

        public ActionResult Edit(int id)
        {
            Engineer thisEngineer = _db.Engineers
                                .Include(engineer => engineer.Location)                             
                                .FirstOrDefault(Engineer => Engineer.EngineerId == id);
            ViewBag.LocationId = new SelectList(_db.Locations, "LocationId", "Name", thisEngineer.Location.LocationId);
            return View(thisEngineer);
        }

        [HttpPost]
        public ActionResult Edit(Engineer engineer)
        {
            if (!ModelState.IsValid)
            {
                return View(engineer);
            }
            else 
            {
                _db.Engineers.Update(engineer);
                _db.SaveChanges();
                return RedirectToAction("Details", new { id = engineer.EngineerId });
            }
        }

        public ActionResult Delete(int id)
        {
            Engineer thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
            return View(thisEngineer);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Engineer thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
            _db.Engineers.Remove(thisEngineer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AssignMachine(int id)
        {
            Engineer thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
            List<Machine> allMachines = _db.Machines.ToList();
            ViewBag.Machines = new List<Machine>();
            ViewBag.Machines = _db.Machines.OrderBy(machine => machine.Name).ToList();            
            ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Name");
            return View(thisEngineer);
        }

        [HttpPost]
        public ActionResult AssignMachine(Engineer engineer, int machineId)
        {
            #nullable enable
            EngineerMachine? joinEntity = _db.EngineerMachines.FirstOrDefault(join => (join.MachineId == machineId && join.EngineerId == engineer.EngineerId));
            #nullable disable
            Machine machine = _db.Machines.FirstOrDefault(machine => machine.MachineId == machineId);
            if (joinEntity == null && machineId != 0)
            {
                _db.EngineerMachines.Add(new EngineerMachine() { MachineId = machineId, EngineerId = engineer.EngineerId });
                _db.SaveChanges();
                // if (engineer.LocationId == machine.LocationId )
                // {
                //     _db.EngineerMachines.Add(new EngineerMachine() { MachineId = machineId, EngineerId = engineer.EngineerId });
                //     _db.SaveChanges();
                // }
                // else 
                // {
                    
                //     return View(engineer);
                // }                
            }
            return RedirectToAction("Details", new { id = engineer.EngineerId });
        }

        [HttpPost]
        public ActionResult DeleteJoin(int joinId)
        {
            EngineerMachine joinEntry = _db.EngineerMachines.FirstOrDefault(entry => entry.EngineerMachineId == joinId);
            int engineerId = joinEntry.EngineerId;
            _db.EngineerMachines.Remove(joinEntry);
            _db.SaveChanges();
            return RedirectToAction("Details", new { id = engineerId });
        }
    }
}