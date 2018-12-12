using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinalExam.Models;

namespace FinalExam.Controllers
{
    public class IteamController : Controller {
        private IIteamRepository repository;
        public IteamController(IIteamRepsoitory repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.Iteam);
        }
    }
