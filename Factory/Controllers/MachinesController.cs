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
    public class MachinesController : Controller
    {

        private readonly FactoryContext _db;

        public MachinesController(FactoryContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Machine> model = _db.Machines.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.LocationId = new SelectList(_db.Locations, "LocationId", "Name");
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Machine machine)
        {   
            if (!ModelState.IsValid)
            {
                return View();
            }
            else 
            {
                _db.Add(machine);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public ActionResult Details(int id) 
        {
            Machine thisMachine = _db.Machines
                .Include(machine => machine.Location)
                .Include(machine => machine.JoinEntities)
                .ThenInclude(join => join.Engineer)
                .FirstOrDefault(machine => machine.MachineId == id);
            return View(thisMachine);
        }

        public ActionResult Edit(int id)
        {
            Machine thisMachine = _db.Machines
                                .Include(machine => machine.JoinEntities)
                                .ThenInclude(join => join.Engineer)
                                .FirstOrDefault(machine => machine.MachineId == id);
            return View(thisMachine);
        }

        [HttpPost]
        public ActionResult Edit(Machine machine)
        {
            if (!ModelState.IsValid)
            {
                return View(machine);
            }
            else 
            {
                _db.Machines.Update(machine);
                _db.SaveChanges();
                return RedirectToAction("Details", new { id = machine.MachineId });
            }
        }

        public ActionResult Delete(int id)
        {
            Machine thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
            return View(thisMachine);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Machine thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
            _db.Machines.Remove(thisMachine);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AssignEngineer(int id)
        {
            Machine thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
            ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
            return View(thisMachine);
        }

        [HttpPost]
        public ActionResult AssignEngineer(Machine Machine, int engineerId)
        {
            #nullable enable
            EngineerMachine? joinEntity = _db.EngineerMachines.FirstOrDefault(join => (join.EngineerId == engineerId && join.MachineId == Machine.MachineId));
            #nullable disable
            if (joinEntity == null && engineerId != 0)
            {
                _db.EngineerMachines.Add(new EngineerMachine() { EngineerId = engineerId, MachineId = Machine.MachineId });
                _db.SaveChanges();
            }
            return RedirectToAction("Details", new { id = Machine.MachineId });
        }

        [HttpPost]
        public ActionResult DeleteJoin(int joinId)
        {
            EngineerMachine joinEntry = _db.EngineerMachines.FirstOrDefault(entry => entry.EngineerMachineId == joinId);
            int machineId = joinEntry.MachineId;
            _db.EngineerMachines.Remove(joinEntry);
            _db.SaveChanges();
            return RedirectToAction("Details", new { id = machineId });
        }
    }
}