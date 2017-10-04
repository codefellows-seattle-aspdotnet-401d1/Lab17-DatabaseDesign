using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab17DatabaseDesign.Models;

namespace Lab17DatabaseDesign.Controllers
{
    public class EquipmentSetController : Controller
    {
        private readonly Lab17DatabaseDesignContext _context;

        public EquipmentSetController(Lab17DatabaseDesignContext context)
        {
            _context = context;
        }

        // GET: EquipmentSet
        public async Task<IActionResult> Index()
        {
            return View(await _context.EquipmentSet.ToListAsync());
        }

        // GET: EquipmentSet/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentSet = await _context.EquipmentSet
                .SingleOrDefaultAsync(m => m.ID == id);
            if (equipmentSet == null)
            {
                return NotFound();
            }

            return View(equipmentSet);
        }

        // GET: EquipmentSet/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EquipmentSet/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,SetName")] EquipmentSet equipmentSet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipmentSet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(equipmentSet);
        }

        // GET: EquipmentSet/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentSet = await _context.EquipmentSet.SingleOrDefaultAsync(m => m.ID == id);
            if (equipmentSet == null)
            {
                return NotFound();
            }
            return View(equipmentSet);
        }

        // POST: EquipmentSet/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,SetName")] EquipmentSet equipmentSet)
        {
            if (id != equipmentSet.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipmentSet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipmentSetExists(equipmentSet.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(equipmentSet);
        }

        // GET: EquipmentSet/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentSet = await _context.EquipmentSet
                .SingleOrDefaultAsync(m => m.ID == id);
            if (equipmentSet == null)
            {
                return NotFound();
            }

            return View(equipmentSet);
        }

        // POST: EquipmentSet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipmentSet = await _context.EquipmentSet.SingleOrDefaultAsync(m => m.ID == id);
            _context.EquipmentSet.Remove(equipmentSet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipmentSetExists(int id)
        {
            return _context.EquipmentSet.Any(e => e.ID == id);
        }
    }
}
