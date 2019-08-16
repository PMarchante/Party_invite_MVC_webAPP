using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class RSVPController : Controller
    {
        Repository _dbcontext = new Repository();
        [HttpGet]
        public IActionResult RSVPForm()
        {
            _dbcontext.Database.EnsureCreated();
            return View();
        }
        [HttpPost]
        public IActionResult RSVPForm(Guestresponse response)
        {
            _dbcontext.Responses.Add(response);
            _dbcontext.SaveChanges();
            return View("Thanks", response);
        }

        public IActionResult ListResponses()
        {
            return View(_dbcontext.Responses.Where(r => r.WillAttend == true));
        }
    }
}