using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NTLLab6_EF.Models;
using NTLLab6_EF.Entities;

public class NTLCategoriesController : Controller
{
    private readonly NTLAppDbContext _context;

    public NTLCategoriesController(NTLAppDbContext context)
    {
        _context = context;
    }

    // GET: NTLCategories
    public async Task<IActionResult> Index()
    {
        var categories = await _context.Categories
            .Include(c => c.NTLProducts)
            .ToListAsync();

        return View(categories);
    }

    // GET: NTLCategories/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ntlcategory = await _context.Categories
            .Include(c => c.NTLProducts)
            .FirstOrDefaultAsync(c => c.NTLId == id);

        if (ntlcategory == null)
        {
            return NotFound();
        }

        return View(ntlcategory);
    }

    // GET: NTLCategories/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: NTLCategories/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(
        [Bind("NTLId,NTLName")] NTLCategory ntlcategory)
    {
        if (ModelState.IsValid)
        {
            ntlcategory.CreatedDate = DateTime.Now;

            _context.Categories.Add(ntlcategory);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        return View(ntlcategory);
    }

    // GET: NTLCategories/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ntlcategory = await _context.Categories.FindAsync(id);

        if (ntlcategory == null)
        {
            return NotFound();
        }

        return View(ntlcategory);
    }
    // POST: NTLCategories/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(
        int id,
        [Bind("NTLId,NTLName")] NTLCategory ntlcategory)
    {
        if (id != ntlcategory.NTLId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                ntlcategory.CreatedDate = DateTime.Now;

                _context.Categories.Update(ntlcategory);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NTLCategoryExists(ntlcategory.NTLId))
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

        return View(ntlcategory);
    }

    // GET: NTLCategories/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ntlcategory = await _context.Categories
            .FirstOrDefaultAsync(c => c.NTLId == id);

        if (ntlcategory == null)
        {
            return NotFound();
        }

        return View(ntlcategory);
    }

    // POST: NTLCategories/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var ntlcategory = await _context.Categories.FindAsync(id);

        if (ntlcategory != null)
        {
            _context.Categories.Remove(ntlcategory);
        }

        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    private bool NTLCategoryExists(int id)
    {
        return _context.Categories.Any(e => e.NTLId == id);
    }
}