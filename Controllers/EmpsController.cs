using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OurWebAppSecond.Models;

namespace OurWebAppSecond.Controllers
{
    public class EmpsController : Controller
    {
        public IActionResult Index()
        {
            List<Emp> objemplist = new List<Emp>() { 
            new Emp{ 
            Id=1,Name="Sam",Desig="Manager"} ,
             new Emp{
            Id=2,Name="Jatin",Desig="Manager"},
             new Emp{
            Id=4,Name="Mohan",Desig="Manager"},
             new Emp{
            Id=7,Name="Anoop",Desig="Manager"}};
            return View(objemplist);
        }
    }
}