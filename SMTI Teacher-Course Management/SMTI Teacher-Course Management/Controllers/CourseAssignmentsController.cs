using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SMTI_Teacher_Course_Management.Models;

namespace SMTI_Teacher_Course_Management.Controllers
{
    public class CourseAssignmentsController : Controller
    {
        private readonly SMTITeacherCourseManagementDBContext _context;

        public CourseAssignmentsController(SMTITeacherCourseManagementDBContext context)
        {
            _context = context;
        }

        // GET: CourseAssignments
        public async Task<IActionResult> Index()
        {
            var sMTITeacherCourseManagementDBContext = _context.CourseAssignments.Include(c => c.CourseNumberNavigation).Include(c => c.EmployeeNumberNavigation).Include(c => c.GroupNumberNavigation);
            return View(await sMTITeacherCourseManagementDBContext.ToListAsync());
        }

        // GET: CourseAssignments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseAssignments = await _context.CourseAssignments
                .Include(c => c.CourseNumberNavigation)
                .Include(c => c.EmployeeNumberNavigation)
                .Include(c => c.GroupNumberNavigation)
                .FirstOrDefaultAsync(m => m.AssignId == id);
            if (courseAssignments == null)
            {
                return NotFound();
            }

            return View(courseAssignments);
        }

        // GET: CourseAssignments/Create
        public IActionResult Create()
        {
            ViewData["CourseNumber"] = new SelectList(_context.Courses, "CourseNumber", "CourseNumber");
            ViewData["EmployeeNumber"] = new SelectList(_context.Employees, "EmployeeNumber", "FirstName");
            ViewData["GroupNumber"] = new SelectList(_context.Groups, "GroupNumber", "Description");
            return View();
        }

        // POST: CourseAssignments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AssignId,EmployeeNumber,CourseNumber,GroupNumber")] CourseAssignments courseAssignments)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseAssignments);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseNumber"] = new SelectList(_context.Courses, "CourseNumber", "CourseNumber", courseAssignments.CourseNumber);
            ViewData["EmployeeNumber"] = new SelectList(_context.Employees, "EmployeeNumber", "FirstName", courseAssignments.EmployeeNumber);
            ViewData["GroupNumber"] = new SelectList(_context.Groups, "GroupNumber", "Description", courseAssignments.GroupNumber);
            return View(courseAssignments);
        }

        // GET: CourseAssignments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseAssignments = await _context.CourseAssignments.FindAsync(id);
            if (courseAssignments == null)
            {
                return NotFound();
            }
            ViewData["CourseNumber"] = new SelectList(_context.Courses, "CourseNumber", "CourseNumber", courseAssignments.CourseNumber);
            ViewData["EmployeeNumber"] = new SelectList(_context.Employees, "EmployeeNumber", "FirstName", courseAssignments.EmployeeNumber);
            ViewData["GroupNumber"] = new SelectList(_context.Groups, "GroupNumber", "Description", courseAssignments.GroupNumber);
            return View(courseAssignments);
        }

        // POST: CourseAssignments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AssignId,EmployeeNumber,CourseNumber,GroupNumber")] CourseAssignments courseAssignments)
        {
            if (id != courseAssignments.AssignId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseAssignments);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseAssignmentsExists(courseAssignments.AssignId))
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
            ViewData["CourseNumber"] = new SelectList(_context.Courses, "CourseNumber", "CourseNumber", courseAssignments.CourseNumber);
            ViewData["EmployeeNumber"] = new SelectList(_context.Employees, "EmployeeNumber", "FirstName", courseAssignments.EmployeeNumber);
            ViewData["GroupNumber"] = new SelectList(_context.Groups, "GroupNumber", "Description", courseAssignments.GroupNumber);
            return View(courseAssignments);
        }

        // GET: CourseAssignments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseAssignments = await _context.CourseAssignments
                .Include(c => c.CourseNumberNavigation)
                .Include(c => c.EmployeeNumberNavigation)
                .Include(c => c.GroupNumberNavigation)
                .FirstOrDefaultAsync(m => m.AssignId == id);
            if (courseAssignments == null)
            {
                return NotFound();
            }

            return View(courseAssignments);
        }

        // POST: CourseAssignments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseAssignments = await _context.CourseAssignments.FindAsync(id);
            _context.CourseAssignments.Remove(courseAssignments);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseAssignmentsExists(int id)
        {
            return _context.CourseAssignments.Any(e => e.AssignId == id);
        }
    }
}
