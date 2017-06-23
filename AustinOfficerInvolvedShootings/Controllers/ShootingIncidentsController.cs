using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AustinOfficerInvolvedShootings.Data;
using AustinOfficerInvolvedShootings.Models;

namespace AustinOfficerInvolvedShootings.Controllers
{
    public class ShootingIncidentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShootingIncidentsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: ShootingIncidents
        public async Task<IActionResult> Index(string searchString, int? page, int injFilter = 0, int ctFilter = 0 )
        {
            if (searchString != null)
            {
                page = 1;
            }

            ViewData["CurrentFilter"] = searchString;

            var ct = _context.CallType.Select(c => new { id = c.Id, value = c.Label }).Distinct().ToList();
            ViewBag.CtSelectList = new SelectList(ct, "id", "value");

            var inj = _context.SubjectInjuries.Select(i => new { id = i.Id, value = i.Label }).Distinct().ToList();
            ViewBag.InjSelectList = new SelectList(inj, "id", "value");

            IQueryable<ShootingIncident> incident;


            var allIncidents = _context.ShootingIncident.Include(s => s.CallType).Include(s => s.CaseNumber).Include(s => s.SubjectInjuries).
                 Include(s => s.WeekDay).Include(s => s.DrugsAlcohol).Include(s => s.OfficerEthnicity).Include(s => s.OfficerName).
                 Include(s => s.OfficerWeaponCaliber).Include(s => s.Rank).Include(s => s.SubjectEthnicity).
                 Include(s => s.SubjectWeapon).Include(s => s.YearsExperience).Select(s => s);
            //*  return View(await applicationDbContext.ToListAsync()); 

            if (!String.IsNullOrEmpty(searchString))
            {
                ctFilter = 0;

               allIncidents = allIncidents.Where(v => v.Premise.Contains(searchString));
            }

            if (ctFilter > 0)
            {
                incident = allIncidents.Where(s => s.CallTypeId == ctFilter);
            }
            else if (injFilter > 0)
            {
                incident = allIncidents.Where(s => s.SubjectInjuriesId == injFilter);
            }
            else
            {
                // do nothing, all
                incident = allIncidents.Select(s => s);
            }
            int pageSize = 15;
            return View(await PaginatedList<ShootingIncident>.CreateAsync(incident.AsNoTracking(), page ?? 1, pageSize));
          //  return View(incident.ToList());

        }

        // GET: ShootingIncidents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shootingIncident = await _context.ShootingIncident
                .Include(s => s.CallType)
                .Include(s => s.CaseNumber)
                .Include(s => s.WeekDay)
                .Include(s => s.DrugsAlcohol)
                .Include(s => s.OfficerEthnicity)
                .Include(s => s.OfficerName)
                .Include(s => s.OfficerWeaponCaliber)
                .Include(s => s.Rank)
                .Include(s => s.SubjectEthnicity)
                .Include(s => s.SubjectInjuries)
                .Include(s => s.SubjectWeapon)
                .Include(s => s.YearsExperience)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (shootingIncident == null)
            {
                return NotFound();
            }

            return View(shootingIncident);
        }

        // GET: ShootingIncidents/Create
        public IActionResult Create()
        {
            ViewData["CallTypeId"] = new SelectList(_context.Set<CallType>(), "Id", "Label");
            ViewData["CaseNumberId"] = new SelectList(_context.Set<CaseNumber>(), "Id", "Label");
            ViewData["WeekDayId"] = new SelectList(_context.Set<WeekDay>(), "Id", "Label");
            ViewData["DrugsAlcoholId"] = new SelectList(_context.Set<DrugsAlcohol>(), "Id", "Label");
            ViewData["OfficerEthnicityId"] = new SelectList(_context.Set<OfficerEthnicity>(), "Id", "Label");
            ViewData["OfficerNameId"] = new SelectList(_context.Set<OfficerName>(), "Id", "Label");
            ViewData["OfficerWeaponCaliberId"] = new SelectList(_context.Set<OfficerWeaponCaliber>(), "Id", "Label");
            ViewData["RankId"] = new SelectList(_context.Set<Rank>(), "Id", "Label");
            ViewData["SubjectEthnicityId"] = new SelectList(_context.Set<SubjectEthnicity>(), "Id", "Label");
            ViewData["SubjectInjuriesId"] = new SelectList(_context.Set<SubjectInjuries>(), "Id", "Label");
            ViewData["SubjectWeaponId"] = new SelectList(_context.Set<SubjectWeapon>(), "Id", "Label");
            ViewData["YearsExperienceId"] = new SelectList(_context.Set<YearsExperience>(), "Id", "Label");
            return View();
        }

        // POST: ShootingIncidents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CaseNumberId,Date,WeekDayId,DayPart,Premise,InsideOutisde,SubjectWeaponId,NumberOfficerShooters,CallTypeId,NumberOfficerPresent,NumberHits,OfficerNameId,RankId,OfficerEthnicityId,OfficerGender,OfficerAge,Jurisdiction,YearsExperienceId,PreviousOIS,OfficerWeaponCaliberId,OfficerWeaponType,NumberShotsFired,HowCleared,SubjectEthnicityId,SubjectGender,SubjectAge,SubjectInjuriesId,DrugsAlcoholId,Location")] ShootingIncident shootingIncident)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shootingIncident);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["CallTypeId"] = new SelectList(_context.Set<CallType>(), "Id", "Label", shootingIncident.CallTypeId);
            ViewData["CaseNumberId"] = new SelectList(_context.Set<CaseNumber>(), "Id", "Label", shootingIncident.CaseNumberId);
            ViewData["WeekDayId"] = new SelectList(_context.Set<WeekDay>(), "Id", "Label", shootingIncident.WeekDayId);
            ViewData["DrugsAlcoholId"] = new SelectList(_context.Set<DrugsAlcohol>(), "Id", "Label", shootingIncident.DrugsAlcoholId);
            ViewData["OfficerEthnicityId"] = new SelectList(_context.Set<OfficerEthnicity>(), "Id", "Label", shootingIncident.OfficerEthnicityId);
            ViewData["OfficerNameId"] = new SelectList(_context.Set<OfficerName>(), "Id", "Label", shootingIncident.OfficerNameId);
            ViewData["OfficerWeaponCaliberId"] = new SelectList(_context.Set<OfficerWeaponCaliber>(), "Id", "Label", shootingIncident.OfficerWeaponCaliberId);
            ViewData["RankId"] = new SelectList(_context.Set<Rank>(), "Id", "Label", shootingIncident.RankId);
            ViewData["SubjectEthnicityId"] = new SelectList(_context.Set<SubjectEthnicity>(), "Id", "Label", shootingIncident.SubjectEthnicityId);
            ViewData["SubjectInjuriesId"] = new SelectList(_context.Set<SubjectInjuries>(), "Id", "Label", shootingIncident.SubjectInjuriesId);
            ViewData["SubjectWeaponId"] = new SelectList(_context.Set<SubjectWeapon>(), "Id", "Label", shootingIncident.SubjectWeaponId);
            ViewData["YearsExperienceId"] = new SelectList(_context.Set<YearsExperience>(), "Id", "Label", shootingIncident.YearsExperienceId);
            return View(shootingIncident);
        }

        // GET: ShootingIncidents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shootingIncident = await _context.ShootingIncident.SingleOrDefaultAsync(m => m.Id == id);
            if (shootingIncident == null)
            {
                return NotFound();
            }
            ViewData["CallTypeId"] = new SelectList(_context.Set<CallType>(), "Id", "Label", shootingIncident.CallTypeId);
            ViewData["CaseNumberId"] = new SelectList(_context.Set<CaseNumber>(), "Id", "Label", shootingIncident.CaseNumberId);
            ViewData["WeekDayId"] = new SelectList(_context.Set<WeekDay>(), "Id", "Label", shootingIncident.WeekDayId);
            ViewData["DrugsAlcoholId"] = new SelectList(_context.Set<DrugsAlcohol>(), "Id", "Label", shootingIncident.DrugsAlcoholId);
            ViewData["OfficerEthnicityId"] = new SelectList(_context.Set<OfficerEthnicity>(), "Id", "Label", shootingIncident.OfficerEthnicityId);
            ViewData["OfficerNameId"] = new SelectList(_context.Set<OfficerName>(), "Id", "Label", shootingIncident.OfficerNameId);
            ViewData["OfficerWeaponCaliberId"] = new SelectList(_context.Set<OfficerWeaponCaliber>(), "Id", "Label", shootingIncident.OfficerWeaponCaliberId);
            ViewData["RankId"] = new SelectList(_context.Set<Rank>(), "Id", "Label", shootingIncident.RankId);
            ViewData["SubjectEthnicityId"] = new SelectList(_context.Set<SubjectEthnicity>(), "Id", "Label", shootingIncident.SubjectEthnicityId);
            ViewData["SubjectInjuriesId"] = new SelectList(_context.Set<SubjectInjuries>(), "Id", "Label", shootingIncident.SubjectInjuriesId);
            ViewData["SubjectWeaponId"] = new SelectList(_context.Set<SubjectWeapon>(), "Id", "Label", shootingIncident.SubjectWeaponId);
            ViewData["YearsExperienceId"] = new SelectList(_context.Set<YearsExperience>(), "Id", "Label", shootingIncident.YearsExperienceId);
            return View(shootingIncident);
        }

        // POST: ShootingIncidents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CaseNumberId,Date,WeekDayId,DayPart,Premise,InsideOutisde,SubjectWeaponId,NumberOfficerShooters,CallTypeId,NumberOfficerPresent,NumberHits,OfficerNameId,RankId,OfficerEthnicityId,OfficerGender,OfficerAge,Jurisdiction,YearsExperienceId,PreviousOIS,OfficerWeaponCaliberId,OfficerWeaponType,NumberShotsFired,HowCleared,SubjectEthnicityId,SubjectGender,SubjectAge,SubjectInjuriesId,DrugsAlcoholId,Location")] ShootingIncident shootingIncident)
        {
            if (id != shootingIncident.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shootingIncident);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShootingIncidentExists(shootingIncident.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewData["CallTypeId"] = new SelectList(_context.Set<CallType>(), "Id", "Label", shootingIncident.CallTypeId);
            ViewData["CaseNumberId"] = new SelectList(_context.Set<CaseNumber>(), "Id", "Label", shootingIncident.CaseNumberId);
            ViewData["WeekDayId"] = new SelectList(_context.Set<WeekDay>(), "Id", "Label", shootingIncident.WeekDayId);
            ViewData["DrugsAlcoholId"] = new SelectList(_context.Set<DrugsAlcohol>(), "Id", "Label", shootingIncident.DrugsAlcoholId);
            ViewData["OfficerEthnicityId"] = new SelectList(_context.Set<OfficerEthnicity>(), "Id", "Label", shootingIncident.OfficerEthnicityId);
            ViewData["OfficerNameId"] = new SelectList(_context.Set<OfficerName>(), "Id", "Label", shootingIncident.OfficerNameId);
            ViewData["OfficerWeaponCaliberId"] = new SelectList(_context.Set<OfficerWeaponCaliber>(), "Id", "Label", shootingIncident.OfficerWeaponCaliberId);
            ViewData["RankId"] = new SelectList(_context.Set<Rank>(), "Id", "Label", shootingIncident.RankId);
            ViewData["SubjectEthnicityId"] = new SelectList(_context.Set<SubjectEthnicity>(), "Id", "Label", shootingIncident.SubjectEthnicityId);
            ViewData["SubjectInjuriesId"] = new SelectList(_context.Set<SubjectInjuries>(), "Id", "Label", shootingIncident.SubjectInjuriesId);
            ViewData["SubjectWeaponId"] = new SelectList(_context.Set<SubjectWeapon>(), "Id", "Label", shootingIncident.SubjectWeaponId);
            ViewData["YearsExperienceId"] = new SelectList(_context.Set<YearsExperience>(), "Id", "Label", shootingIncident.YearsExperienceId);
            return View(shootingIncident);
        }

        // GET: ShootingIncidents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shootingIncident = await _context.ShootingIncident
                .Include(s => s.CallType)
                .Include(s => s.CaseNumber)
                .Include(s => s.WeekDay)
                .Include(s => s.DrugsAlcohol)
                .Include(s => s.OfficerEthnicity)
                .Include(s => s.OfficerName)
                .Include(s => s.OfficerWeaponCaliber)
                .Include(s => s.Rank)
                .Include(s => s.SubjectEthnicity)
                .Include(s => s.SubjectInjuries)
                .Include(s => s.SubjectWeapon)
                .Include(s => s.YearsExperience)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (shootingIncident == null)
            {
                return NotFound();
            }

            return View(shootingIncident);
        }

        // POST: ShootingIncidents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shootingIncident = await _context.ShootingIncident.SingleOrDefaultAsync(m => m.Id == id);
            _context.ShootingIncident.Remove(shootingIncident);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ShootingIncidentExists(int id)
        {
            return _context.ShootingIncident.Any(e => e.Id == id);
        }
    }
}
