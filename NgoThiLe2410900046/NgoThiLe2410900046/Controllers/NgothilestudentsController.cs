
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NgoThiLe_2410900046.Models;

public class NgothilestudentsController : Controller
{
    private readonly NgothilestudentContext _context;

    public NgothilestudentsController(NgothilestudentContext context)
    {
        _context = context;
    }

    // GET: NGOTHILESTUDENTS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Ngothilestudents.ToListAsync());
    }

    // GET: NGOTHILESTUDENTS/Details/5
    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ngothilestudent = await _context.Ngothilestudents
            .FirstOrDefaultAsync(m => m.Id == id);
        if (ngothilestudent == null)
        {
            return NotFound();
        }

        return View(ngothilestudent);
    }

    // GET: NGOTHILESTUDENTS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: NGOTHILESTUDENTS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,NgothileName,NgothileGender,NgothileBirthday,NgothileEmail,NgothilePhone,NgothileActive")] Ngothilestudent ngothilestudent)
    {
        if (ModelState.IsValid)
        {
            _context.Add(ngothilestudent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(ngothilestudent);
    }

    // GET: NGOTHILESTUDENTS/Edit/5
    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ngothilestudent = await _context.Ngothilestudents.FindAsync(id);
        if (ngothilestudent == null)
        {
            return NotFound();
        }
        return View(ngothilestudent);
    }

    // POST: NGOTHILESTUDENTS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long? id, [Bind("Id,NgothileName,NgothileGender,NgothileBirthday,NgothileEmail,NgothilePhone,NgothileActive")] Ngothilestudent ngothilestudent)
    {
        if (id != ngothilestudent.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(ngothilestudent);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NgothilestudentExists(ngothilestudent.Id))
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
        return View(ngothilestudent);
    }

    // GET: NGOTHILESTUDENTS/Delete/5
    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ngothilestudent = await _context.Ngothilestudents
            .FirstOrDefaultAsync(m => m.Id == id);
        if (ngothilestudent == null)
        {
            return NotFound();
        }

        return View(ngothilestudent);
    }

    // POST: NGOTHILESTUDENTS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long? id)
    {
        var ngothilestudent = await _context.Ngothilestudents.FindAsync(id);
        if (ngothilestudent != null)
        {
            _context.Ngothilestudents.Remove(ngothilestudent);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool NgothilestudentExists(long? id)
    {
        return _context.Ngothilestudents.Any(e => e.Id == id);
    }
}
