﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Matrix90.Data;
using Matrix90.Models;
using System.Security.Claims;
using Matrix90.ViewModels;
using System.IO;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Matrix90.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public CustomersController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            
            var UserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var Customer = _context.Customers.Where(c => c.IdentityUserId == UserId).SingleOrDefault();
            
            if (_context.Customers.Where(c=> c.IdentityUserId == UserId).SingleOrDefault() == null)
            {
                return View("CreateCustomer");
            }
            else if(_context.CustomerMeasurementss.Where(c=> c.IdentityUserId == UserId).ToList().Count() == 0)
            {
                return View("CreateCustomerMeasurements");
            }
            else if(_context.CustomerEatingHabitss.Where(c=> c.IdentityUserId ==UserId).SingleOrDefault() == null)
            {
                return View("CreateCustomerEatingHabits");
            }
            else if(_context.CustomerWorkInfos.Where(c=> c.IdentityUserId == UserId).SingleOrDefault() == null)
            {
                return View("CreateCustomerWorkInfo");
            }
            else if (_context.CustomerTypicalDayInfos.Where(c=> c.IdentityUserId == UserId).SingleOrDefault() == null)
            {
                return View("CreateCustomerTypicalDay");
            }
            else if(_context.CustomerActivityInfos.Where(c=> c.IdentityUserId == UserId).SingleOrDefault() == null)
            {
                return View("CreateCustomerActivityInfo");
            }
            else if(_context.CustomerMedicalInfos.Where(c=> c.IdentityUserId == UserId).SingleOrDefault() == null)
            {
                return View("CreateCustomerMedicalInfo");
            }
            List<CustomerMeasurements> measurements = _context.CustomerMeasurementss.Where(m => m.IdentityUserId == UserId).ToList();


    
            List<CustomerMeasurements> sortedMeasurements = measurements.OrderByDescending(x => x.uploadDate).ToList();
            DateTime d1 = sortedMeasurements.First().uploadDate;
            DateTime d2 = DateTime.Now;
            TimeSpan difference = d2 - d1;
            
            if(difference.TotalDays > 7)
            {
                if(measurements.First().uploadDate != DateTime.Today)
                {
                    Notification notification = new Notification();
                    notification.controllerAction = "UpdateMeasurements";
                    notification.Id = Customer.IdentityUserId;
                    notification.notificationInfo = "Its time for your weekly measurements update!! Please Update!";
                    _context.Notifications.Add(notification);
                    _context.SaveChanges();
                }
                
            }
            int weightDifference = sortedMeasurements.First().GoalWeight - sortedMeasurements.First().StartingWeight;
            int weightProgress = sortedMeasurements.First().CurrentWeight - sortedMeasurements.First().StartingWeight;
            double progressBarPercentage = (double)weightProgress / (double)weightDifference * 100.0;
            ViewBag.Notifications = _context.Notifications.Where(n=> n.Id == Customer.IdentityUserId).ToList();
            ViewBag.progress = progressBarPercentage;
            ViewBag.NutritrtionPlan = _context.NutritionPlans.Where(n => n.CustomerId == Customer.CustomerId).SingleOrDefault();
            ViewBag.Measurements = sortedMeasurements;

            return View(Customer);
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]  
        [ValidateAntiForgeryToken]
        [RequestSizeLimit(40000000)]
        public async Task<IActionResult> Create(CustomerViewModel model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {
                string FrontUniqueFileName = null;
                if(model.FrontImage != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Images");
                   FrontUniqueFileName =  Guid.NewGuid().ToString() + "_" + model.FrontImage.FileName;
                    string filePath = Path.Combine(uploadsFolder, FrontUniqueFileName);
                    model.FrontImage.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                string BackUniqueFileName = null;
                if (model.BackImage != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Images");
                    BackUniqueFileName = Guid.NewGuid().ToString() + "_" + model.BackImage.FileName;
                    string filePath = Path.Combine(uploadsFolder, BackUniqueFileName);
                    model.BackImage.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                string LeftUniqueFileName = null;
                if (model.ProfileLeft != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Images");
                    LeftUniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProfileLeft.FileName;
                    string filePath = Path.Combine(uploadsFolder, LeftUniqueFileName);
                    model.ProfileLeft.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                string RightUniqueFileName = null;
                if (model.ProfileRight != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Images");
                    RightUniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProfileRight.FileName;
                    string filePath = Path.Combine(uploadsFolder, RightUniqueFileName);
                    
                    model.ProfileRight.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Customer newCustomer = new Customer
                { 
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    StreetAddress = model.StreetAddress,
                    ZipAddress = model.ZipAddress,
                    StateAddress = model.StateAddress,
                    PrefferedMethodOfContact = model.PrefferedMethodOfContact,
                    BestTimeToReach = model.BestTimeToReach,
                    PhoneNumber = model.PhoneNumber,
                    CityAddress = model.CityAddress,
                    FrontImage = FrontUniqueFileName,
                    BackImage = BackUniqueFileName,
                    ProfileLeft = LeftUniqueFileName,
                    ProfileRight = RightUniqueFileName,
                    IdentityUserId = userId
                    
                };

                _context.Customers.Add(newCustomer);
                _context.SaveChanges();
                return RedirectToAction("index");

            }
            return View();
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,FirstName,LastName,StreetAddress,CityAddress,StateAddress,ZipAddress,Email,PhoneNumber,PrefferedMethodOfContact,BestTimeToReach,FrontImage,BackImage,ProfileRight,ProfileLeft,IdentityUserId")] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.CustomerId == id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCustomerActivityInfo(CustomerActivityInfo model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            CustomerActivityInfo temp = new CustomerActivityInfo
            {
                AccessToFacility = model.AccessToFacility,
                IdentityUserId = userId,
                RoutineDaysAWeek = model.RoutineDaysAWeek,
                RoutineTimePerDay = model.RoutineTimePerDay,
                WorkoutRoutine = model.WorkoutRoutine
            };

            _context.CustomerActivityInfos.Add(temp);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCustomerMeasurements(CustomerMeasurements model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            CustomerMeasurements temp = new CustomerMeasurements
            {
                StartingWeight = model.StartingWeight,
                CurrentWeight = model.StartingWeight,
                GoalWeight = model.GoalWeight,
                Height = model.Height,
                Arms = model.Arms,
                Waist = model.Waist,
                Hips = model.Hips,
                Neck = model.Neck,
                Chest = model.Chest,
                Thigh = model.Thigh,
                Calves = model.Calves,
                IdentityUserId = userId,
                uploadDate = DateTime.Now
                
            };

            _context.CustomerMeasurementss.Add(temp);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCustomerEatingHabits(CustomerEatingHabits model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            CustomerEatingHabits temp = new CustomerEatingHabits
            {
                IdentityUserId = userId,
                TypicalBreakfast = model.TypicalBreakfast,
                TypicalLunch = model.TypicalLunch,
                TypicalDinner = model.TypicalDinner,
                TypicalSnack = model.TypicalSnack,
                DrinkSodaAmount = model.DrinkSodaAmount,
                DrinkAlcoholAmount = model.DrinkAlcoholAmount,
                FoodAllergies = model.FoodAllergies,
                KindOfFoodAllergies = model.KindOfFoodAllergies,
                FavoriteFoods = model.FavoriteFoods,
                NonFavoriteFoods = model.NonFavoriteFoods,
                AdditionalInfo = model.AdditionalInfo

            };

            _context.CustomerEatingHabitss.Add(temp);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCustomerWorkInfo(CustomerWorkInfo model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            CustomerWorkInfo temp = new CustomerWorkInfo
            {
                IdentityUserId = userId,
                Occupation = model.Occupation,
                Shift = model.Shift,
                WorkDays = model.WorkDays,
                DailyWorkHours = model.DailyWorkHours,
                ScheduledBreaks = model.ScheduledBreaks,
                BringLunchAbility = model.BringLunchAbility,
                ActivityLevel = model.ActivityLevel,
                AdditionalInfo = model.AdditionalInfo

            };

            _context.CustomerWorkInfos.Add(temp);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCustomerTypicalDay(CustomerTypicalDayInfo model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            CustomerTypicalDayInfo temp = new CustomerTypicalDayInfo
            {
              IdentityUserId = userId,
              WakeUpTime = model.WakeUpTime,
              BedTime = model.BedTime,
              SleepDifficulty = model.SleepDifficulty,
              NightlyWakeUps = model.NightlyWakeUps,
              BreakfastTime = model.BreakfastTime,
              LunchTime = model.LunchTime,
              DinnerTime = model.DinnerTime ,
              SnackDuringDay = model.SnackDuringDay,
              SnackDuringDayTimes = model.SnackDuringDayTimes,
              EatingTimeFlexibility = model.EatingTimeFlexibility,
              AdditionalInfo = model.AdditionalInfo

            };

            _context.CustomerTypicalDayInfos.Add(temp);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCustomerMedicalInfo(CustomerMedicalInfo model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            CustomerMedicalInfo temp = new CustomerMedicalInfo
            {
               IdentityUserId = userId,
               MedicalConditions = model.MedicalConditions,
               Injuries = model.Injuries,
               PhysicalActivityLimitations = model.PhysicalActivityLimitations,
               GastroIntestinalDiscomfort = model.GastroIntestinalDiscomfort,
               GastroInfo = model.GastroInfo,
               AdditionalInfo = model.AdditionalInfo

            };
            Customer current = _context.Customers.Where(c => c.IdentityUserId == model.IdentityUserId).SingleOrDefault();
            var nutritionists = _context.Nutritionists.ToList();
            foreach(var item in nutritionists)
            {
                Notification notification = new Notification();
                notification.Id = item.IdentityUserId;
                notification.notificationInfo = $"{current.FirstName} {current.LastName} completed the forms and is ready for a customized nutrition plan.";
                notification.controllerAction = "ViewNewCustomer";
                _context.Notifications.Add(notification);
            }

            
          

            _context.CustomerMedicalInfos.Add(temp);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        [HttpGet]
        public async Task<IActionResult> CustomerNutritionPlan()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var currentCustomer = _context.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            var nutritionPlan = _context.NutritionPlans.Where(n => n.CustomerId == currentCustomer.CustomerId).SingleOrDefault();
            return View(nutritionPlan);
        }

        [HttpGet]

        public async Task<IActionResult> Matrix90Tips()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Customer current = _context.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            List<TipOfWeek> Tips = _context.TipOfWeeks.ToList();
            Tips.OrderByDescending(x => x.uploadDate);
            TipOfWeekViewModel temp = new TipOfWeekViewModel();
            temp.tips = Tips.ToList();
            ViewBag.FavoriteTips = _context.FavoriteTips.Where(f => f.CustomerId == current.CustomerId).ToList();
            ViewBag.CustomerId = current.CustomerId;
            return View(temp);
        }
        [HttpPost]

        public async Task<IActionResult> Matrix90Tips(TipOfWeekViewModel _tips)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Customer current = _context.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            List<TipOfWeek> Tips = _context.TipOfWeeks.ToList();
            Tips.OrderByDescending(x => x.uploadDate);
            TipOfWeekViewModel temp = new TipOfWeekViewModel();
            temp.tips = Tips.Where(t => t.SubjectName == _tips.subject).ToList();
            ViewBag.FavoriteTips = _context.FavoriteTips.Where(f => f.CustomerId == current.CustomerId).ToList();
            ViewBag.CustomerId = current.CustomerId;
            return View(temp);
        }

        [HttpGet]

        public async Task<IActionResult> Matrix90Recipes()
        {
            List<Recipe> Recipes = _context.Recipes.ToList();
            Recipes.OrderByDescending(x => x.uploadDate);
            RecipeViewModel temp = new RecipeViewModel();
            temp.recipes = Recipes.ToList();

            return View(temp);
        }

        [HttpPost]

        public async Task<IActionResult> Matrix90Recipes(RecipeViewModel _recipes)
        {
            List<Recipe> Recipes = _context.Recipes.ToList();
            Recipes.OrderByDescending(x => x.uploadDate);
            RecipeViewModel temp = new RecipeViewModel();
            temp.recipes = Recipes.Where(t => t.Type == _recipes.subject).ToList();
            return View(temp);
        }

        [HttpGet]

        public async Task<IActionResult> AddFavoriteTip(int CustomerId, int TipId)
        {
            FavoriteTip newFavoriteTip = new FavoriteTip();
            newFavoriteTip.TipOfWeekId = TipId;
            newFavoriteTip.CustomerId = CustomerId;
            _context.FavoriteTips.Add(newFavoriteTip);
            _context.SaveChanges();
            return RedirectToAction(nameof(Matrix90Tips));
        }

        [HttpPost]

        public async Task<IActionResult> RemoveFavoriteTip(int CustomerId, int TipId)
        {
            FavoriteTip newFavoriteTip = _context.FavoriteTips.Where(t => t.CustomerId == CustomerId && t.TipOfWeekId == TipId).SingleOrDefault();
          
            _context.FavoriteTips.Remove(newFavoriteTip);
            _context.SaveChanges();
            return RedirectToAction(nameof(Matrix90Tips));
        }

        public async Task<IActionResult> ViewNotifications(List<Notification> notifications)
        {
            List<Notification> _notifications = _context.Notifications.Where(n => n.Id == User.FindFirstValue(ClaimTypes.NameIdentifier)).ToList();
            return View(_notifications);
        }

        public async Task<IActionResult> RemoveNotification(int notificationId)
        {
            Notification currentNotification = _context.Notifications.Where(n => n.notificationId == notificationId).SingleOrDefault();
            string controllerAction = currentNotification.controllerAction;
            _context.Notifications.Remove(currentNotification);
            _context.SaveChanges();
            return RedirectToAction(controllerAction);
        }

        public async Task<IActionResult> UpdateMeasurements()
        {
            Customer current = _context.Customers.Where(c => c.IdentityUserId == User.FindFirstValue(ClaimTypes.NameIdentifier)).SingleOrDefault();
            CustomerMeasurements measurements = _context.CustomerMeasurementss.Where(m => m.IdentityUserId == current.IdentityUserId).SingleOrDefault();
            return View(measurements);
        }

        

        public async Task<IActionResult> Favorites()
        {
            Customer current = _context.Customers.Where(c => c.IdentityUserId == User.FindFirstValue(ClaimTypes.NameIdentifier)).SingleOrDefault();
            List<FavoriteTip> favoriteTips = _context.FavoriteTips.Where(t => t.CustomerId == current.CustomerId).ToList();
            List<TipOfWeek> tips = new List<TipOfWeek>();
            foreach(var item in favoriteTips)
            {
                TipOfWeek tip = _context.TipOfWeeks.Where(t=> t.TipOfWeekId == item.TipOfWeekId).SingleOrDefault();
                if(tip != null)
                {
                    tips.Add(tip);
                }
                
            }
            return View(tips);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateMeasurements(CustomerMeasurements newMeasurements)
        {
            CustomerMeasurements NewMeasurement = newMeasurements;
           
            NewMeasurement.uploadDate = DateTime.Now;
            NewMeasurement.IdentityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _context.CustomerMeasurementss.Add(NewMeasurement);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
