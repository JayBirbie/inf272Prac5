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
                List<Models.PersonModel> members = new List<Models.PersonModel>();

                members.Add(new Models.PersonModel { stuNum = "u20467207", fName = "Raelene", lName = "Dookkoo", email = "raelene.d@tuks.co.za" });
                members.Add(new Models.PersonModel { stuNum = "u23854830", fName = "Dakalo", lName = "Nemamilwe", email = "u23854830@tuks.co.za" });
                members.Add(new Models.PersonModel { stuNum = "u23959094", fName = "Jessica", lName = "Turner", email = "u23959094@tuks.co.za" });
                members.Add(new Models.PersonModel { stuNum = "u22500333", fName = "Jay", lName = "Mashele", email = "njl.mashele@tuks.co.za" });
                members.Add(new Models.PersonModel { stuNum = "u24596385", fName = "Ryan", lName = "van Wyk", email = "r.vanwyk@tuks.co.za" });

                Session["MemberList"] = members;
            }
            return View((List<Models.PersonModel>)Session["MemberList"]);
        }

        // GET: People/AddPerson
        public ActionResult AddPerson()
        {
            return View();
        }

        // POST: People/AddPerson
        [HttpPost]
        public ActionResult AddPerson(Models.PersonModel person)
        {
            if (ModelState.IsValid)
            {
                List<Models.PersonModel> members = (List<Models.PersonModel>)Session["MemberList"];
                if (members == null || members.Count == 0)
                {
                    members = new List<Models.PersonModel>();
                }

                members.Add(person);
                Session["MemberList"] = members;

                return RedirectToAction("List");
            }
            return View(person);
        }
    }
}