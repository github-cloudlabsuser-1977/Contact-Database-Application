using CRUD_application_2.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Razor.Generator;

namespace CRUD_application_2.Controllers
{
    public class UserController : Controller
    {
        public static System.Collections.Generic.List<User> userlist = new System.Collections.Generic.List<User>();
        // GET: User
        public ActionResult Index()
        {
            // Implement the Index method here
           // This method is responsible for displaying the list of users.
            // It retrieves the list of users from the userlist and passes it to the Index view.
            return View(userlist);
        }
 
        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            // Implement the details method here
           // This method is responsible for displaying the details of a specific user with the specified ID.
            // It retrieves the user from the userlist based on the provided ID and passes it to the Details view.
            return View(userlist.FirstOrDefault(x => x.Id == id));
        }
 
        // GET: User/Create
        public ActionResult Create()
        {
            //Implement the Create method here
           // This method is responsible for displaying the view to create a new user.
            // It returns the Create view, which contains a form to collect user information.
            return View();
        }
 
        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            // Implement the Create method (POST) here
            // This method is responsible for handling the HTTP POST request to create a new user.
            // It receives user input from the form submission and adds the new user to the userlist.
            // If successful, it redirects to the Index action to display the updated list of users.
            // If an error occurs during the process, it returns the Create view to display any validation errors.
            if (ModelState.IsValid)
            {
                userlist.Add(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }
 
        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            // This method is responsible for displaying the view to edit an existing user with the specified ID.
            // It retrieves the user from the userlist based on the provided ID and passes it to the Edit view.
            // If no user is found with the provided ID, it returns a HttpNotFoundResult.
            return View(userlist.FirstOrDefault(x => x.Id == id));
        }
 
        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User user)
        {
            // This method is responsible for handling the HTTP POST request to update an existing user with the specified ID.
            // It receives user input from the form submission and updates the corresponding user's information in the userlist.
            // If successful, it redirects to the Index action to display the updated list of users.
            // If no user is found with the provided ID, it returns a HttpNotFoundResult.
            // If an error occurs during the process, it returns the Edit view to display any validation errors.
            // Implement the Edit method (POST) here
            // Find the user in the list
           var userToUpdate = userlist.FirstOrDefault(x => x.Id == id);
            if (userToUpdate != null)
            {
                // Update the user properties
                userToUpdate.Name = user.Name;
                userToUpdate.Email = user.Email;
                return RedirectToAction("Index");
            }
            return HttpNotFound();
        }
 
        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            // Implement the Delete method here
            // This method is responsible for displaying the view to delete an existing user with the specified ID.
            // It retrieves the user from the userlist based on the provided ID and passes it to the Delete view.
            // If no user is found with the provided ID, it returns a HttpNotFoundResult.
            return View(userlist.FirstOrDefault(x => x.Id == id));

        }
 
        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            // Implement the Delete method (POST) here
            // This method is responsible for handling the HTTP POST request to delete an existing user with the specified ID.
            // It removes the user from the userlist based on the provided ID.
            // If successful, it redirects to the Index action to display the updated list of users.
            // If no user is found with the provided ID, it returns a HttpNotFoundResult.
            var userToDelete = userlist.FirstOrDefault(x => x.Id == id);
            if (userToDelete != null)
            {
                userlist.Remove(userToDelete);
                return RedirectToAction("Index");
            }
            return HttpNotFound();

        }

        // Search a user from the list
        public ActionResult Search(string term)
        {
           // search the user from the list then display the user matched
           var searchResult = userlist.Where(x => x.Name.Contains(term) || x.Email.Contains(term)).ToList();
            return View("Index", searchResult);
        }
    }
}


        