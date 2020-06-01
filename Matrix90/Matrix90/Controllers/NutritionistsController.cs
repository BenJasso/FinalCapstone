using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Matrix90.Data;
using Matrix90.Models;
using Matrix90.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.Extensions.Hosting;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Matrix90.Controllers
{
    public class NutritionistsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;
        public NutritionistsController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Nutritionists
        public async Task<IActionResult> Index()
        {
            ViewBag.NutritionPlans = _context.NutritionPlans.ToList();
            List<Customer> newCustomers = new List<Customer>();
            var customers = _context.Customers.ToList();
            CustomerViewModel temp = new CustomerViewModel();
            temp.customers = customers;
            foreach(var item in customers)
            {
                if(_context.NutritionPlans.Where(n=> n.CustomerId == item.CustomerId).SingleOrDefault() == null)
                {
                    newCustomers.Add(item);
                }
            }
            ViewBag.NewCustomers = newCustomers;
            ViewBag.Notifications = _context.Notifications.Where(n => n.Id == User.FindFirstValue(ClaimTypes.NameIdentifier)).ToList();


            return View(temp);
        }

        [HttpPost]

        public async Task<IActionResult> Index(CustomerViewModel filteredCustomers)
        {
            List<Customer> Customers = _context.Customers.ToList();
            List<Customer> newCustomers = new List<Customer>();
            foreach (var item in Customers)
            {
                if (_context.NutritionPlans.Where(n => n.CustomerId == item.CustomerId).SingleOrDefault() == null)
                {
                    newCustomers.Add(item);
                }
            }
            ViewBag.NewCustomers = newCustomers;
            ViewBag.Notifications = _context.Notifications.Where(n => n.Id == User.FindFirstValue(ClaimTypes.NameIdentifier)).ToList();
            Customers.OrderByDescending(x => x.LastName);
            CustomerViewModel temp = new CustomerViewModel();
            temp.customers = Customers.Where(c => c.LastName.ToLower() == filteredCustomers.LastName.ToLower()).ToList();
            return View(temp);
        }



        [HttpGet]
        public async Task<IActionResult> ViewNewCustomer(int customerId)
        {
            ViewBag.CustomerId = customerId;
            Customer currentCustomer = _context.Customers.Where(c => c.CustomerId == customerId).SingleOrDefault();
            ViewBag.Customer = currentCustomer;
            List<CustomerMeasurements> customerMeasurements = _context.CustomerMeasurementss.Where(m => m.IdentityUserId == currentCustomer.IdentityUserId).ToList();
            List<CustomerMeasurements> sortedMeasurements = customerMeasurements.OrderByDescending(x => x.uploadDate).ToList();
            int weightDifference = sortedMeasurements.First().GoalWeight - sortedMeasurements.First().StartingWeight;
            int weightProgress = sortedMeasurements.First().CurrentWeight - sortedMeasurements.First().StartingWeight;
            double progressBarPercentage = (double)weightProgress / (double)weightDifference * 100.0;
            ViewBag.progress = progressBarPercentage;
            ViewBag.Measurements = sortedMeasurements;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ViewNewCustomer(NutritionPlan newPlan)
        {
            Notification notification = new Notification();
            Customer current = _context.Customers.Where(c => c.CustomerId == newPlan.CustomerId).SingleOrDefault();
            notification.Id = current.IdentityUserId;
            notification.notificationInfo = "Your customized nutritrion plan is now completed";
            notification.controllerAction = "CustomerNutritionPlan";
            _context.Notifications.Add(notification);

            _context.NutritionPlans.Add(newPlan);
           
            _context.SaveChanges();
            return RedirectToAction("ViewCustomer", new { customerId = newPlan.CustomerId });
        }

        [HttpGet]
        public async Task<IActionResult> ViewCustomer(int customerId)
        {
            ViewBag.CustomerId = customerId;
            Customer currentCustomer = _context.Customers.Where(c => c.CustomerId == customerId).SingleOrDefault();
            NutritionPlan currentPlan = _context.NutritionPlans.Where(n => n.CustomerId == customerId).SingleOrDefault();
            ViewBag.Customer = currentCustomer;
            ViewBag.Measurements = _context.CustomerMeasurementss.Where(m => m.IdentityUserId == currentCustomer.IdentityUserId).ToList();
            return View(currentPlan);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ViewCustomer(NutritionPlan newPlan)
        {
            Notification notification = new Notification();
            Customer current = _context.Customers.Where(c => c.CustomerId == newPlan.CustomerId).SingleOrDefault();
            notification.Id = current.IdentityUserId;
            notification.controllerAction = "CustomerNutritionPlan";
            notification.notificationInfo = "Your customized nutritrion plan has been updated";
            NutritionPlan currentNP = _context.NutritionPlans.Where(n => n.CustomerId == newPlan.CustomerId).SingleOrDefault();

            currentNP.CustomerId = newPlan.CustomerId;
            currentNP.Meal1Time = newPlan.Meal1Time;
            currentNP.Meal1Entree = newPlan.Meal1Entree;
            currentNP.Meal1EntreeSize = newPlan.Meal1EntreeSize;
            currentNP.Meal1Vegetable = newPlan.Meal1Vegetable;
            currentNP.Meal1VegetableSize = newPlan.Meal1VegetableSize;
            currentNP.Meal1Carb = newPlan.Meal1Carb;
            currentNP.Meal1CarbSize = newPlan.Meal1CarbSize;
            currentNP.Meal2Time = newPlan.Meal2Time;
            currentNP.Meal2Entree = newPlan.Meal2Entree;
            currentNP.Meal2EntreeSize = newPlan.Meal2EntreeSize;
            currentNP.Meal2Vegetable = newPlan.Meal2Vegetable;
            currentNP.Meal2VegetableSize = newPlan.Meal2VegetableSize;
            currentNP.Meal2Carb = newPlan.Meal2Carb;
            currentNP.Meal2CarbSize = newPlan.Meal2CarbSize;
            currentNP.Meal3Time = newPlan.Meal3Time;
            currentNP.Meal3Entree = newPlan.Meal3Entree;
            currentNP.Meal3EntreeSize = newPlan.Meal3EntreeSize;
            currentNP.Meal3Vegetable = newPlan.Meal3Vegetable;
            currentNP.Meal3VegetableSize = newPlan.Meal3VegetableSize;
            currentNP.Meal3Carb = newPlan.Meal3Carb;
            currentNP.Meal3CarbSize = newPlan.Meal3CarbSize;
            currentNP.Meal4Time = newPlan.Meal4Time;
            currentNP.Meal4Entree = newPlan.Meal4Entree;
            currentNP.Meal4EntreeSize = newPlan.Meal4EntreeSize;
            currentNP.Meal4Vegetable = newPlan.Meal4Vegetable;
            currentNP.Meal4VegetableSize = newPlan.Meal4VegetableSize;
            currentNP.Meal4Carb = newPlan.Meal4Carb;
            currentNP.Meal4CarbSize = newPlan.Meal4CarbSize;
            currentNP.Meal5Time = newPlan.Meal5Time;
            currentNP.Meal5Entree = newPlan.Meal5Entree;
            currentNP.Meal5EntreeSize = newPlan.Meal5EntreeSize;
            currentNP.Meal5Vegetable = newPlan.Meal5Vegetable;
            currentNP.Meal5VegetableSize = newPlan.Meal5VegetableSize;
            currentNP.Meal5Carb = newPlan.Meal5Carb;
            currentNP.Meal5CarbSize = newPlan.Meal5CarbSize;
            currentNP.Meal6Time = newPlan.Meal6Time;
            currentNP.Meal6Entree = newPlan.Meal6Entree;
            currentNP.Meal6EntreeSize = newPlan.Meal6EntreeSize;
            currentNP.Meal6Vegetable = newPlan.Meal6Vegetable;
            currentNP.Meal6VegetableSize = newPlan.Meal6VegetableSize;
            currentNP.Meal6Carb = newPlan.Meal6Carb;
            currentNP.Meal6CarbSize = newPlan.Meal6CarbSize;
            currentNP.Snack1Time = newPlan.Snack1Time;
            currentNP.Snack1 = newPlan.Snack1;
            currentNP.Snack1Size = newPlan.Snack1Size;
            currentNP.Snack2Time = newPlan.Snack2Time;
            currentNP.Snack2 = newPlan.Snack2;
            currentNP.Snack2Size = newPlan.Snack2Size;
            currentNP.Snack3Time = newPlan.Snack3Time;
            currentNP.Snack3 = newPlan.Snack3;
            currentNP.Snack3Size = newPlan.Snack3Size;
            currentNP.Supplement1 = newPlan.Supplement1;
            currentNP.Supplement2 = newPlan.Supplement2;
            currentNP.Supplement3 = newPlan.Supplement3;
            _context.Notifications.Add(notification);
            _context.SaveChanges();
            return RedirectToAction("ViewCustomer", new { customerId = newPlan.CustomerId });
        }


        // GET: Nutritionists/Details/5
        public ActionResult ViewCustomerMedicalInfo(int customerId)
        {
            Customer current = _context.Customers.Where(c => c.CustomerId == customerId).SingleOrDefault();
            return View(_context.CustomerMedicalInfos.Where(m=> m.IdentityUserId == current.IdentityUserId).SingleOrDefault());
        }

        public ActionResult ViewCustomerWorkInfo(int customerId)
        {
            Customer current = _context.Customers.Where(c => c.CustomerId == customerId).SingleOrDefault();
            return View(_context.CustomerWorkInfos.Where(m => m.IdentityUserId == current.IdentityUserId).SingleOrDefault());
        }

        public ActionResult ViewCustomerMeasurements(int customerId)
        {
            Customer current = _context.Customers.Where(c => c.CustomerId == customerId).SingleOrDefault();
            return View(_context.CustomerMeasurementss.Where(m => m.IdentityUserId == current.IdentityUserId).SingleOrDefault());
        }

        public ActionResult ViewCustomerEatingHabits(int customerId)
        {
            Customer current = _context.Customers.Where(c => c.CustomerId == customerId).SingleOrDefault();
            return View(_context.CustomerEatingHabitss.Where(m => m.IdentityUserId == current.IdentityUserId).SingleOrDefault());
        }
        public ActionResult ViewCustomerTypicalDay(int customerId)
        {
            Customer current = _context.Customers.Where(c => c.CustomerId == customerId).SingleOrDefault();
            return View(_context.CustomerTypicalDayInfos.Where(m => m.IdentityUserId == current.IdentityUserId).SingleOrDefault());
        }

        public ActionResult ViewCustomerActivityInfo(int customerId)
        {
            Customer current = _context.Customers.Where(c => c.CustomerId == customerId).SingleOrDefault();
            return View(_context.CustomerActivityInfos.Where(m => m.IdentityUserId == current.IdentityUserId).SingleOrDefault());
        }






        // GET: Nutritionists/Create
        public ActionResult CreateTip()
        {
            return View();
        }

        // POST: Nutritionists/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateTip(TipOfWeek newTip)
        {
            try
            {
                // TODO: Add insert logic here
                
                
                
                var customers = _context.Customers.ToList();
                foreach(var item in customers)
                {
                    Notification notification = new Notification();
                    notification.Id = item.IdentityUserId;
                    notification.notificationInfo = "A new Matrix90 has been added.";
                    notification.controllerAction = "Matrix90Tips";
                    _context.Notifications.Add(notification);
                    _context.SaveChanges();
                }
                newTip.uploadDate = DateTime.Now;
                _context.TipOfWeeks.Add(newTip);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Nutritionists/Create
        public ActionResult CreateRecipe()
        {
            return View();
        }

        // POST: Nutritionists/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateRecipe(RecipeViewModel model)
        {
            try
            {
                var customers = _context.Customers.ToList();
                foreach (var item in customers)
                {
                    Notification notification = new Notification();
                    notification.Id = item.IdentityUserId;
                    notification.notificationInfo = "A new Matrix90 recipe has been added.";
                    notification.controllerAction = "Matrix90Recipes";
                    _context.Notifications.Add(notification);
                    _context.SaveChanges();
                }
                string RecipeFileName = null;
                if (model.RecipeImage != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Images");
                    RecipeFileName = Guid.NewGuid().ToString() + "_" + model.RecipeImage.FileName;
                    string filePath = Path.Combine(uploadsFolder, RecipeFileName);
                    model.RecipeImage.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                // TODO: Add insert logic here
                model.uploadDate = DateTime.Now;
                Recipe newRecipe = new Recipe();
                newRecipe.RecipeInfo = model.RecipeInfo;
                newRecipe.Type = model.Type;
                newRecipe.uploadDate = model.uploadDate;
                newRecipe.RecipeImage = RecipeFileName;
                _context.Recipes.Add(newRecipe);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Nutritionists/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Nutritionists/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Nutritionists/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Nutritionists/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public async Task<IActionResult> RemoveNotification(Notification notification)
        {
            int _customerId = _context.Customers.Where(c => c.IdentityUserId == notification.Id).SingleOrDefault().CustomerId;
            string controllerAction = notification.controllerAction;
            _context.Notifications.Remove(notification);
            _context.SaveChanges();

            if (notification.controllerAction == "ViewNewCustomer")
            {
                return RedirectToAction(controllerAction, _customerId);
            }
            else
            {
                return RedirectToAction(controllerAction);
            }

        }
    }
}