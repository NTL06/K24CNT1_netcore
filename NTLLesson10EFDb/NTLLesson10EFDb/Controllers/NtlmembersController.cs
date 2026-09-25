
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NTLLesson10EFDb.Models;

public class NtlmembersController : Controller
{
    private readonly Ntllesson10EfdbContext _context;

    public NtlmembersController(Ntllesson10EfdbContext context)
    {
        _context = context;
    }

    // GET: NTLMEMBERS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Ntlmembers.ToListAsync());
    }

    // GET: NTLMEMBERS/Details/5
    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ntlmember = await _context.Ntlmembers
            .FirstOrDefaultAsync(m => m.Id == id);
        if (ntlmember == null)
        {
            return NotFound();
        }

        return View(ntlmember);
    }

    // GET: NTLMEMBERS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: NTLMEMBERS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,NtluserName,Ntlpassword,NtlfullName,Ntlemail,Ntlphone,Ntlstatus")] Ntlmember ntlmember)
    {
        if (ModelState.IsValid)
        {
            _context.Add(ntlmember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(ntlmember);
    }

    // GET: NTLMEMBERS/Edit/5
    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ntlmember = await _context.Ntlmembers.FindAsync(id);
        if (ntlmember == null)
        {
            return NotFound();
        }
        return View(ntlmember);
    }

    // POST: NTLMEMBERS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long? id, [Bind("Id,NtluserName,Ntlpassword,NtlfullName,Ntlemail,Ntlphone,Ntlstatus")] Ntlmember ntlmember)
    {
        if (id != ntlmember.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(ntlmember);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NtlmemberExists(ntlmember.Id))
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
        return View(ntlmember);
    }

    // GET: NTLMEMBERS/Delete/5
    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ntlmember = await _context.Ntlmembers
            .FirstOrDefaultAsync(m => m.Id == id);
        if (ntlmember == null)
        {
            return NotFound();
        }

        return View(ntlmember);
    }

    // POST: NTLMEMBERS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long? id)
    {
        var ntlmember = await _context.Ntlmembers.FindAsync(id);
        if (ntlmember != null)
        {
            _context.Ntlmembers.Remove(ntlmember);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool NtlmemberExists(long? id)
    {
        return _context.Ntlmembers.Any(e => e.Id == id);
    }
}
