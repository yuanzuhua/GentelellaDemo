﻿using Gentelella.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Gentelella.Interface;
using Gentelella.Models;
using Gentelella.Extensions;

namespace Gentelella.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserLogic _userLogic;

        public HomeController(IUserLogic userLogic)
        {
            this._userLogic = userLogic;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CredentialModel credential)
        {
            var posCredential = credential.ToPosCredential();
            var isSuccess = _userLogic.Login(posCredential);
            return View();
        }
    }
}