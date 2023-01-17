// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
// using Factory.Models;
// using Factory.ViewModels;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc.Rendering;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.Logging;

// namespace Factory.Controllers
// {
//     public class IncidentsController : Controller
//     {

//         private readonly FactoryContext _db;

//         public IncidentsController(FactoryContext db)
//         {
//             _db = db;
//         }

//         public ActionResult Index()
//         {
//             List<Incident> model = _db.Incidents.ToList();
//             return View(model);
//         }

//         public ActionResult Create()
//         {   
//             ListAllViewModel model = new ListAllViewModel();
//             model.Engineers = _db.Engineers.ToList();
//             model.Machines = _db.Machines.ToList();
//             model.Locations = _db.Locations.ToList();
//             model.Incidents = _db.Incidents.ToList();
//             ViewBag.LocationId = new SelectList(_db.Locations, "LocationId", "Name");
//             return View(model);
//         }
        
//         [HttpPost]
//         public ActionResult Create(Incident Incident)
//         {   
//             if (!ModelState.IsValid)
//             {
//                 return View();
//             }
//             else 
//             {
//                 _db.Add(Incident);
//                 _db.SaveChanges();
//                 return RedirectToAction("Index");
//             }
//         }
            

//         public ActionResult Details(int id) 
//         {
//             Incident thisIncident = _db.Incidents
//                 .Include(Incident => Incident.Location)
//                 .FirstOrDefault(Incident => Incident.IncidentId == id);
//             return View(thisIncident);
//         }

//         public ActionResult Edit(int id)
//         {
//             Incident thisIncident = _db.Incidents
//                                 .Include(Incident => Incident.Location)                             
//                                 .FirstOrDefault(Incident => Incident.IncidentId == id);
//             ViewBag.LocationId = new SelectList(_db.Locations, "LocationId", "Name", thisIncident.Location.LocationId);
//             return View(thisIncident);
//         }

//         [HttpPost]
//         public ActionResult Edit(Incident Incident)
//         {
//             if (!ModelState.IsValid)
//             {
//                 return View(Incident);
//             }
//             else 
//             {
//                 _db.Incidents.Update(Incident);
//                 _db.SaveChanges();
//                 return RedirectToAction("Details", new { id = Incident.IncidentId });
//             }
//         }

//         public ActionResult Delete(int id)
//         {
//             Incident thisIncident = _db.Incidents.FirstOrDefault(Incident => Incident.IncidentId == id);
//             return View(thisIncident);
//         }

//         [HttpPost, ActionName("Delete")]
//         public ActionResult DeleteConfirmed(int id)
//         {
//             Incident thisIncident = _db.Incidents.FirstOrDefault(Incident => Incident.IncidentId == id);
//             _db.Incidents.Remove(thisIncident);
//             _db.SaveChanges();
//             return RedirectToAction("Index");
//         }

//         public ActionResult AssignMachine(int id)
//         {
//             Incident thisIncident = _db.Incidents.FirstOrDefault(Incident => Incident.IncidentId == id);
//             //List<Machine> allMachines = _db.Machines.ToList();
//             ViewBag.Machines = new List<Machine>();
//             ViewBag.Machines = _db.Machines.ToList();
            
//             ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Name");
//             return View(thisIncident);
//         }

//         [HttpPost]
//         public ActionResult AssignMachine(Incident Incident, int machineId)
//         {
//             #nullable enable
//             IncidentMachine? joinEntity = _db.IncidentMachines.FirstOrDefault(join => (join.MachineId == machineId && join.IncidentId == Incident.IncidentId));
//             #nullable disable
//             if (joinEntity == null && machineId != 0)
//             {
//                 _db.IncidentMachines.Add(new IncidentMachine() { MachineId = machineId, IncidentId = Incident.IncidentId });
//                 _db.SaveChanges();
//             }
//             return RedirectToAction("Details", new { id = Incident.IncidentId });
//         }

//         [HttpPost]
//         public ActionResult DeleteJoin(int joinId)
//         {
//             IncidentMachine joinEntry = _db.IncidentMachines.FirstOrDefault(entry => entry.IncidentMachineId == joinId);
//             int IncidentId = joinEntry.IncidentId;
//             _db.IncidentMachines.Remove(joinEntry);
//             _db.SaveChanges();
//             return RedirectToAction("Details", new { id = IncidentId });
//         }
//     }
// }