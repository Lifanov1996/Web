﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ClientController : Controller
    {
        
        public IActionResult Index(int id)
        {
            PersonModel model = new PersonModel();
            Persone persone = new Persone();
            model.PersonCollectoin = persone.GetClientsAllId(id);

            return View(model);
 
        }
    }
}