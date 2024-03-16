using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TRPO_Lab3.AspNet.Models;

namespace TRPO_Lab3.AspNet.Controllers
{
    public class CalculateAreaController : Controller
    {
        // GET: CalculateAreaController/Edit/5
        public ActionResult Edit(double radius, double height)
        {
            return View(new CalculateAreaViewModel(radius, height));
        }

        // POST: CalculateAreaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(double radius, double height, IFormCollection collection)
        {
            try
            {
                collection.TryGetValue(nameof(CalculateAreaViewModel.Radius), out var new_radius);
                collection.TryGetValue(nameof(CalculateAreaViewModel.Height), out var new_height);
                radius = Convert.ToDouble(new_radius);
                height = Convert.ToDouble(new_height);
                return RedirectToAction(nameof(Edit), new CalculateAreaViewModel(radius, height));
            }
            catch
            {
                return RedirectToAction(nameof(HomeController.Error), "Home");
            }
        }
    }
}
