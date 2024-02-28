using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlogApp.Models;
using BlogApp.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BlogApp.Controllers
{
    public class BlogsController : Controller
    {
        private readonly IBlogService _blogSerivce;

        public BlogsController(IBlogService blogSerivce)
        {
            _blogSerivce= blogSerivce;
        }

        // GET: Blogs
        public async Task<IActionResult> Index()
        {
            return View(_blogSerivce.GetAll());
        }

        // GET: Blogs/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = _blogSerivce.GetById(id);

            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // GET: Blogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Blogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,SubTitle,Description,CreateTime")] Blog blog)
        {
            //BlogService blogService = new BlogService();
            if (ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty,"خطا در سمت سرور1");
                ModelState.AddModelError(string.Empty,"خطا در سمت سرور2");
                ModelState.AddModelError(string.Empty,"خطا در سمت سرور3");
                ModelState.AddModelError(string.Empty,"خطا در سمت سرور4");
                ModelState.AddModelError(string.Empty,"خطا در سمت سرور5");
                return View(blog);
            }
            else if (ModelState.IsValid)
            {
                _blogSerivce.Create(blog);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blog);
        }

        // GET: Blogs/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var blog = await _context.Blogs.FindAsync(id);
        //    if (blog == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(blog);
        //}

        //// POST: Blogs/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Title,SubTitle,Description,CreateTime")] Blog blog)
        //{
        //    if (id != blog.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(blog);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!BlogExists(blog.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(blog);
        //}

        //// GET: Blogs/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var blog = await _context.Blogs
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (blog == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(blog);
        //}

        //// POST: Blogs/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var blog = await _context.Blogs.FindAsync(id);
        //    _context.Blogs.Remove(blog);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool BlogExists(int id)
        //{
        //    return _context.Blogs.Any(e => e.Id == id);
        //}
    }
}
