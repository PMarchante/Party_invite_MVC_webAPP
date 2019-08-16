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
        [HttpGet]
        public IActionResult RSVPForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RSVPForm(Guestresponse response)
        {
            Repository.AddResponse(response);
            return View("Thanks", response);
        }

        public IActionResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}