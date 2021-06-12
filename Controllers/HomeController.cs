using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyFirstDB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MyFirstDB.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace MyFirstDB.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public async Task<ViewResult> Index()
        {

            //Hops hop1 = new Hops { name = "Amarillo" };
            //Hops hop2 = new Hops { name = "Cascade" };
            //Hops hop3 = new Hops { name = "Galaxy" };
            //Hops hop4 = new Hops { name = "Simcoe" };

            //Beer beer1 = new Beer { name = "Dogfish Head 60 Minute", style = "IPA", hops = new List<Hops> { hop1, hop4 } };
            //Beer beer2 = new Beer { name = "Sierra Nevada", style = "Pale Ale", hops = new List<Hops> { hop2} };
            //Beer beer3 = new Beer { name = "Smash Galaxy", style = "IPA", hops = new List<Hops> { hop3} };
            //Beer beer4 = new Beer { name = "Mirror Pond", style = "Pale Ale", hops = new List<Hops> { hop2 } };

            //dbContext.Hops.Add(hop1);
            //dbContext.Hops.Add(hop2);
            //dbContext.Hops.Add(hop3);
            //dbContext.Hops.Add(hop4);

            //dbContext.Beers.Add(beer1);
            //dbContext.Beers.Add(beer2);
            //dbContext.Beers.Add(beer3);
            //dbContext.Beers.Add(beer4);

            //dbContext.SaveChanges();

            //// READ operation
            //Company CompanyRead1 = dbContext.Companies
            //                        .Where(c => c.symbol == "MCOB")
            //                        .First();

            //Company CompanyRead2 = dbContext.Companies
            //                        .Include(c => c.Quotes)
            //                        .Where(c => c.symbol == "MCOB")
            //                        .First();

            //Beer read2 = dbContext.Beers
            //            .Where(c => c.name == "Dogfish Head 60 Minute")
            //            .First();

            //read2.rating = 8.5M;
            //dbContext.Beers.Update(read2);
            //Beer read3 = dbContext.Beers
            //            .Where(c => c.name == "Sierra Nevada")
            //            .First();

            //read3.rating = 8.0M;
            //dbContext.Beers.Update(read3);
            //Beer read4 = dbContext.Beers
            //            .Where(c => c.name == "Smash Galaxy")
            //            .First();

            //read4.rating = 7.5M;
            //dbContext.Beers.Update(read4);

            //await dbContext.SaveChangesAsync();

            //LINQ queries


            //// DELETE operation
            ////dbContext.Companies.Remove(CompanyRead1);
            ////await dbContext.SaveChangesAsync();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
