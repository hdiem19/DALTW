using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnWeb.Models;

namespace DoAnWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminLoaiTaiKhoansController : Controller
    {
        private readonly Applicationcs _context;

        public AdminLoaiTaiKhoansController(Applicationcs context)
        {
            _context = context;
        }

        // GET: Admin/AdminLoaiTaiKhoans
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoaiTaiKhoans.ToListAsync());
        }

        // GET: Admin/AdminLoaiTaiKhoans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiTaiKhoan = await _context.LoaiTaiKhoans
                .FirstOrDefaultAsync(m => m.IdLoaiTK == id);
            if (loaiTaiKhoan == null)
            {
                return NotFound();
            }

            return View(loaiTaiKhoan);
        }

        // GET: Admin/AdminLoaiTaiKhoans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminLoaiTaiKhoans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdLoaiTK,LoaiTK")] LoaiTaiKhoan loaiTaiKhoan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loaiTaiKhoan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loaiTaiKhoan);
        }

        // GET: Admin/AdminLoaiTaiKhoans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiTaiKhoan = await _context.LoaiTaiKhoans.FindAsync(id);
            if (loaiTaiKhoan == null)
            {
                return NotFound();
            }
            return View(loaiTaiKhoan);
        }

        // POST: Admin/AdminLoaiTaiKhoans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdLoaiTK,LoaiTK")] LoaiTaiKhoan loaiTaiKhoan)
        {
            if (id != loaiTaiKhoan.IdLoaiTK)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaiTaiKhoan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiTaiKhoanExists(loaiTaiKhoan.IdLoaiTK))
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
            return View(loaiTaiKhoan);
        }

        // GET: Admin/AdminLoaiTaiKhoans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiTaiKhoan = await _context.LoaiTaiKhoans
                .FirstOrDefaultAsync(m => m.IdLoaiTK == id);
            if (loaiTaiKhoan == null)
            {
                return NotFound();
            }

            return View(loaiTaiKhoan);
        }

        // POST: Admin/AdminLoaiTaiKhoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loaiTaiKhoan = await _context.LoaiTaiKhoans.FindAsync(id);
            if (loaiTaiKhoan != null)
            {
                _context.LoaiTaiKhoans.Remove(loaiTaiKhoan);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoaiTaiKhoanExists(int id)
        {
            return _context.LoaiTaiKhoans.Any(e => e.IdLoaiTK == id);
        }
    }
}
