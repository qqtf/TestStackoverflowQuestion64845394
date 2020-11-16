using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Test.Controllers
{
	public class A_StateController : Controller
    {
        private readonly MedicalContext _Db;

        public A_StateController(MedicalContext Db)
        {
            _Db = Db;
        }
        public IActionResult A_StateList()
        {
            try
            {
                var stList = _Db.StateTB.ToList();
                return View(stList);
            }
            catch (Exception e)
            {
                return View(e);
            }
        }
    }
}
