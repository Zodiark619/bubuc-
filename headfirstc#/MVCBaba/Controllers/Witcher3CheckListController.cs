using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCBaba.Data;
using MVCBaba.Models;

namespace MVCBaba.Controllers
{
    public class Witcher3CheckListController : Controller
    {
        private readonly MVCBabaContext _context;

        public Witcher3CheckListController(MVCBabaContext context)
        {
            _context = context;
        }

        // GET: Witcher3CheckList
        public async Task<IActionResult> Index()
        {
              return _context.Witcher3CheckList != null ? 
                          View(await _context.Witcher3CheckList.ToListAsync()) :
                          Problem("Entity set 'MVCBabaContext.Witcher3CheckList'  is null.");
        }

        // GET: Witcher3CheckList/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Witcher3CheckList == null)
            {
                return NotFound();
            }

            var witcher3CheckList = await _context.Witcher3CheckList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (witcher3CheckList == null)
            {
                return NotFound();
            }

            return View(witcher3CheckList);
        }

        // GET: Witcher3CheckList/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Witcher3CheckList/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Level,Location,Description")] Witcher3CheckList witcher3CheckList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(witcher3CheckList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(witcher3CheckList);
        }

        // GET: Witcher3CheckList/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Witcher3CheckList == null)
            {
                return NotFound();
            }

            var witcher3CheckList = await _context.Witcher3CheckList.FindAsync(id);
            if (witcher3CheckList == null)
            {
                return NotFound();
            }
            return View(witcher3CheckList);
        }

        // POST: Witcher3CheckList/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Level,Location,Description")] Witcher3CheckList witcher3CheckList)
        {
            if (id != witcher3CheckList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(witcher3CheckList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Witcher3CheckListExists(witcher3CheckList.Id))
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
            return View(witcher3CheckList);
        }

        // GET: Witcher3CheckList/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Witcher3CheckList == null)
            {
                return NotFound();
            }

            var witcher3CheckList = await _context.Witcher3CheckList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (witcher3CheckList == null)
            {
                return NotFound();
            }

            return View(witcher3CheckList);
        }

        // POST: Witcher3CheckList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Witcher3CheckList == null)
            {
                return Problem("Entity set 'MVCBabaContext.Witcher3CheckList'  is null.");
            }
            var witcher3CheckList = await _context.Witcher3CheckList.FindAsync(id);
            if (witcher3CheckList != null)
            {
                _context.Witcher3CheckList.Remove(witcher3CheckList);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Witcher3CheckListExists(int id)
        {
          return (_context.Witcher3CheckList?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
