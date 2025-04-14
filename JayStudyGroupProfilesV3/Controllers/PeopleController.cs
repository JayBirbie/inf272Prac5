using JayStudyGroupProfilesV3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JayStudyGroupProfilesV3.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult List()
        {
            if (Session["MemberList"] == null)
            {
                Session["MemberList"] = new List<Models.PersonModel>();
            }
            return View((List<Models.PersonModel>)Session["MemberList"]);
        }

        // GET: People/AddPerson
        public ActionResult AddPerson()
        {
            if (Session["MemberList"] == null)
            {
                Session["MemberList"] = new List<Models.PersonModel>();
            }
            return View();
        }

        // POST: People/AddPerson
        [HttpPost]
        public ActionResult AddPerson(Models.PersonModel person)
        {
            if (ModelState.IsValid)
            {
                List<PersonModel> members = (List<PersonModel>)Session["MemberList"];
                members.Add(person);
                Session["MemberList"] = members;
                return RedirectToAction("List");
            }

            return View(person);
        }
    }
}