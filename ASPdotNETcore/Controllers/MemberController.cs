using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASPdotNETcore.Models;

namespace ASPdotNETcore.Controllers
{
    public class MemberController : Controller
    {
        private readonly ILogger<MemberController> _logger;
        static List<Member> members = new List<Member>();
        public MemberController(ILogger<MemberController> logger)
        {
            _logger = logger;
     
            //   members.Add(new Member(){
            //     FirstName = "Le",   
            //     LastName = "Hai",
            //     Gender = "Female",
            //     DateOfBirth = new DateTime(1995,4,5).Date,
            //     PhoneNumber = "12243",
            //     BirthPlace = "Hanoi",
            //     isGraduate = true,
            //     _StarDate = new DateTime(2019,3,5).Date,
            //     _EndDate = null
            // });
            //   members.Add(new Member(){
            //     FirstName = "Nguyen",   
            //     LastName = "Ha",
            //     Gender = "Male",
            //     DateOfBirth = new DateTime(1998,4,5).Date,
            //     PhoneNumber = "1231223",
            //     BirthPlace = "Hanoi",
            //     isGraduate = true,
            //     _StarDate = new DateTime(2019,4,5).Date,
            //     _EndDate = null
            // });
            //   members.Add(new Member(){
            //     FirstName = "Dinh",   
            //     LastName = "Thi",
            //     Gender = "Female",
            //     DateOfBirth = new DateTime(1998,4,5).Date,
            //     PhoneNumber = "131223",
            //     BirthPlace = "Hanoi",
            //     isGraduate = true,
            //     _StarDate = new DateTime(2019,4,5).Date,
            //     _EndDate = null
            // });
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
        public IActionResult ListDetails()
        {
           
           
            return View(members);
        }
        public IActionResult Create()
        {
            return View();
        
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
         public IActionResult Create(Member mb)
        {
            if(ModelState.IsValid)
            {
                
               
                bool id = Insert(mb);
                if (id)
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
            catch(Exception e)
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
         public IActionResult Edit(Member mb)
        {
             if (ModelState.IsValid)
            {
            
                bool id = Update(mb);
                
                if (id)
                {
                   
                    return RedirectToAction("ListDetails", "Member");
                }
                else
                {
                    ModelState.AddModelError("", "Edit Error");
                    return RedirectToAction("Index", "Home");

                }
            }
            return View("Edit");
        }
        public bool Update(Member entity)
        {
            try
            {
                var mb = members.Find(x => x.LastName == entity.LastName);
                mb.LastName = entity.LastName;
                mb.FirstName = entity.FirstName;
                mb.Gender = entity.Gender;
                mb.PhoneNumber = entity.PhoneNumber;
                mb.DateOfBirth = entity.DateOfBirth;
                mb.BirthPlace = entity.BirthPlace;
                mb.isGraduate = entity.isGraduate;
                mb._StarDate = entity._StarDate;
                mb._EndDate = entity._EndDate;
                
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }


    }
}
