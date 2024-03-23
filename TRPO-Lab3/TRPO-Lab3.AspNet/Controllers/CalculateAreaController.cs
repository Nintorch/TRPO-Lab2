using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TRPO_Lab3.AspNet.Models;
using TRPO_Lab3.Lib;

namespace TRPO_Lab3.AspNet.Controllers
{
    public class CalculateAreaController : Controller
    {
        // GET: CalculateAreaController/Edit/5
        public ActionResult Edit(double radius, double height)
        {
            double area = CalculateArea.CalculateConeArea(radius, height);
            return View(new CalculateAreaViewModel(radius, height, area));
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
                double area = CalculateArea.CalculateConeArea(radius, height); 
                return RedirectToAction(nameof(Edit), new CalculateAreaViewModel(radius, height, area));
            }
            catch
            {
                return RedirectToAction(nameof(HomeController.Error), "Home");
            }
        }
    }
}
