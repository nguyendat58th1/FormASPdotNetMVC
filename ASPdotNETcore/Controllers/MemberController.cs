using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASPdotNETcore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPdotNETcore.Controllers
{
    public class MemberController : Controller
    {
        private readonly ILogger<MemberController> _logger;
        static List<Member> members;
        static void Initialize()
        {
            members = new List<Member>() {
                new Member {FirstName = "Le",   
                 LastName = "Hai",
                 Gender = "Female",
                 DateOfBirth = new DateTime(1995,4,5).Date,
                 PhoneNumber = "12243",
                 BirthPlace = "Hanoi",
                 isGraduate = true,
                 _StarDate = new DateTime(2019,3,5).Date,
                 _EndDate = null},
                 new Member {FirstName = "Nguyen",   
                 LastName = "Dat",
                 Gender = "Male",
                 DateOfBirth = new DateTime(1995,4,5).Date,
                 PhoneNumber = "12243",
                 BirthPlace = "Hanoi",
                 isGraduate = true,
                 _StarDate = new DateTime(2019,3,5).Date,
                 _EndDate = null},
            };

        }
        public MemberController(ILogger<MemberController> logger)
        {
            _logger = logger;
            Initialize();
            
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("Member/Details/{name}")]
        public IActionResult Details(string name)
        {

            var result = members.Find(x => x.LastName == name);
            return View(result);
        }
        public IActionResult ListDetails(string searchString)
        {
            var dt = from e in members select e;
            if (!String.IsNullOrEmpty(searchString))
            {
                dt = dt.Where(e => e.LastName.Contains(searchString) || e.FirstName.Contains(searchString));
            }


            ViewBag.CurrentFilter = searchString;
            return View(dt.ToList());
        }
        
        public IActionResult Create()
        {
            
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Member mb)
        {
            if (ModelState.IsValid)
            {


                bool check = Insert(mb);
                if (check)
                {

                    return RedirectToAction("ListDetails", "Member");
                }
                else
                {

                    ModelState.AddModelError("", "Create Error");
                }

            }
            return View(mb);
        }
        public bool Insert(Member mb)
        {
            try
            {
                members.Add(mb);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
 


        [Route("Member/Edit/{name}")]       
        public IActionResult Edit(string name)
        {
            var mb = members.Find(x => x.LastName == name);
            return View(mb);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Member mb )
        {
             if (ModelState.IsValid)
            {
                 bool check = Update(mb);
                    if (check)
                    {

                        return RedirectToAction("ListDetails", "Member");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Edit Error");
                    }
            }
            return View("Edit");

           
        }
        public bool Update(Member entity)
        {
            try
            {
                var mem = members.Where(c => c.LastName == entity.LastName).FirstOrDefault();

                mem.LastName = entity.LastName;
                mem.FirstName = entity.FirstName;
                mem.Gender = entity.Gender;
                mem.PhoneNumber = entity.PhoneNumber;
                mem.DateOfBirth = entity.DateOfBirth;
                mem.BirthPlace = entity.BirthPlace;
                mem.isGraduate = entity.isGraduate;
                mem._StarDate = entity._StarDate;
                mem._EndDate = entity._EndDate;

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //  [HttpDelete]
        // public ActionResult Delete(string name)
        // {
        //     DeleteMB(name);

        //     return RedirectToAction("ListDetails","Member");
        // }

        // public bool DeleteMB(string name)
        // {
        //     try
        //     {
        //         var mb = members.Find(x => x.LastName == name);
        //         members.Remove(mb);
        //         return true;
        //     }
        //     catch (Exception e)
        //     {
        //         return false;
        //     }

        // }
        public ActionResult Delete(string name)
        {

            Member mb = members.Find(x => x.LastName == name);

            return View(mb);
        }

        // POST: DocTin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string name)
        {
            Member mb = members.Find(x => x.LastName == name);
            members.Remove(mb);
            return RedirectToAction("ListDetails");
        }


    }
}
