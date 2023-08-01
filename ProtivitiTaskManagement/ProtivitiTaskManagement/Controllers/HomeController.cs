using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProtivitiTaskManagement.Models;
using System.Diagnostics;
namespace ProtivitiTaskManagement.Controllers
{

    public class HomeController : Controller
    {
        /*private readonly ILogger<HomeController> _logger;

public HomeController(ILogger<HomeController> logger)
{
_logger = logger;
}*/

        private readonly UserDBContext userDB;

        public HomeController(UserDBContext userDB)
        {
            this.userDB = userDB;
        }

        //HomePage
        public IActionResult Index()
        {   

            return View();
        }

        //UserMasterPage
        public async Task<IActionResult> UserMaster()
        {
            var userData = await userDB.Users.ToListAsync();            
            return View(userData);
        }
        
        //AddNewUserPage
        public IActionResult AddUser()
        {
            return View();
        }

      /*var userData = await userDB.Users.ToListAsync();
        var userName = userData.Select(t => t.UserFirstName + t.UserLastName).ToList();*/
        
        [HttpPost]
        public async Task <IActionResult> AddUser(User usr)
        {
            if(ModelState.IsValid)
            {
                await userDB.Users.AddAsync(usr);
                await userDB.SaveChangesAsync();
                TempData["insert_success"] = "Inserted...";
                return RedirectToAction("UserMaster","Home");
            }
            return View(usr);
        }
        //UserDetails
        public async Task<IActionResult> Details(int id)
        {
            if(id == null || userDB.Users == null)
            {
                return NotFound();
            }
            var userData = await userDB.Users.FirstOrDefaultAsync(x => x.UserId == id);

            if(userData == null)
            {
                return NotFound();
            }
            return View(userData);
        }


        //Edit UserMaster
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || userDB.Users == null)
            {
                return NotFound();
            }
            var userData = await userDB.Users.FindAsync(id);
            if (userData == null)
            {
                return NotFound();
            }
            return View(userData);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, User usr)
        {
            if(id != usr.UserId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                userDB.Update(usr);
                await userDB.SaveChangesAsync();
                TempData["update-success"] = "Updated...";
                return RedirectToAction("UserMaster", "Home");
            }
            return View(usr);
        }
        //Deleting UserMaster
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || userDB.Users == null)
            {
                return NotFound();
            }
            var userData = await userDB.Users.FirstOrDefaultAsync(x => x.UserId == id);
            if (userData == null)
            {
                return NotFound();
            }
            return View(userData);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var userData = await userDB.Users.FindAsync(id);
            if(userData != null)
            {
                userDB.Users.Remove(userData);
            }
            await userDB.SaveChangesAsync();
            TempData["delete_success"] = "Deleted...";
            return RedirectToAction("UserMaster", "Home");
        }


        // 
        //
        // 
        // 
        //

        //CustomerMasterPage
        public async Task<IActionResult> CustomerMaster()
        {
            var customerData = await userDB.Customers.ToListAsync();
            return View(customerData);
        }
        //AddNewCustomerPage
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCustomer(Customer cst)
        {
            if (ModelState.IsValid)
            {
                await userDB.Customers.AddAsync(cst);
                await userDB.SaveChangesAsync();
                TempData["insert_success"] = "Inserted...";
                return RedirectToAction("CustomerMaster", "Home");
            }
            return View(cst);
        }
        //CustomerDetails
        public async Task<IActionResult> CustomerDetails(int id)
        {
            if (id == null || userDB.Customers == null)
            {
                return NotFound();
            }
            var customerData = await userDB.Customers.FirstOrDefaultAsync(x => x.CustomerId == id);

            if (customerData == null)
            {
                return NotFound();
            }
            return View(customerData);
        }


        //Edit CustomerData
        public async Task<IActionResult> CustomerEdit(int? id)
        {
            if (id == null || userDB.Customers == null)
            {
                return NotFound();
            }
            var customerData = await userDB.Customers.FindAsync(id);
            if (customerData == null)
            {
                return NotFound();
            }
            return View(customerData);
        }

        [HttpPost]
        public async Task<IActionResult> CustomerEdit(int? id, Customer cst)
        {
            if (id != cst.CustomerId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                userDB.Update(cst);
                await userDB.SaveChangesAsync();
                TempData["update-success"] = "Updated...";
                return RedirectToAction("UserMaster", "Home");
            }
            return View(cst);
        }
        //Deleting CustomerMaster
        public async Task<IActionResult> CustomerDelete(int? id)
        {
            if (id == null || userDB.Customers == null)
            {
                return NotFound();
            }
            var customerData = await userDB.Customers.FirstOrDefaultAsync(x => x.CustomerId == id);
            if (customerData == null)
            {
                return NotFound();
            }
            return View(customerData);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> CustomerDeleteConfirmed(int? id)
        {
            var customerData = await userDB.Customers.FindAsync(id);
            if (customerData != null)
            {
                userDB.Customers.Remove(customerData);
            }
            await userDB.SaveChangesAsync();
            TempData["delete_success"] = "Deleted...";
            return RedirectToAction("CustomerMaster", "Home");
        }


        //
        //
        //
        //
        //
        //

        //TaskMaster
        public async Task<IActionResult> TaskMaster()
        {
            var taskData = await userDB.Tasks.ToListAsync();
            return View(taskData);
        }
        //AddNewTask
        public IActionResult AddTask()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddTask(Taask t)
        {
            if (ModelState.IsValid)
            {
                await userDB.Tasks.AddAsync(t);
                await userDB.SaveChangesAsync();
                TempData["insert_success"] = "Inserted...";
                return RedirectToAction("TaskMaster", "Home");
            }
            return View(t);
        }
        //CustomerDetails
        public async Task<IActionResult> TaskDetails(int id)
        {
            if (id == null || userDB.Tasks == null)
            {
                return NotFound();
            }
            var taskData = await userDB.Tasks.FirstOrDefaultAsync(x => x.TaskId == id);

            if (taskData == null)
            {
                return NotFound();
            }
            return View(taskData);
        }


        //Edit CustomerData
        public async Task<IActionResult> TaskEdit(int? id)
        {
            if (id == null || userDB.Tasks == null)
            {
                return NotFound();
            }
            var taskData = await userDB.Tasks.FindAsync(id);
            if (taskData == null)
            {
                return NotFound();
            }
            return View(taskData);
        }

        [HttpPost]
        public async Task<IActionResult> TaskEdit(int? id, Taask t)
        {
            if (id != t.TaskId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                userDB.Update(t);
                await userDB.SaveChangesAsync();
                TempData["update-success"] = "Updated...";
                return RedirectToAction("TaskMaster", "Home");
            }
            return View(t);
        }
        //Deleting CustomerMaster
        public async Task<IActionResult> TaskDelete(int? id)
        {
            if (id == null || userDB.Tasks == null)
            {
                return NotFound();
            }
            var taskData = await userDB.Tasks.FirstOrDefaultAsync(x => x.TaskId == id);
            if (taskData == null)
            {
                return NotFound();
            }
            return View(taskData);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> TaskDeleteConfirmed(int? id)
        {
            var taskData = await userDB.Tasks.FindAsync(id);
            if (taskData != null)
            {
                userDB.Tasks.Remove(taskData);
            }
            await userDB.SaveChangesAsync();
            TempData["delete_success"] = "Deleted...";
            return RedirectToAction("TaskMaster", "Home");
        }

        //
        //
        //
        //
        //
        //
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