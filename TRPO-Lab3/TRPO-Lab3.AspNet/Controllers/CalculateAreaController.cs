using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TRPO_Lab3.AspNet.Models;

namespace TRPO_Lab3.AspNet.Controllers
{
    public class CalculateAreaController : Controller
    {
        private double radius = 0, height = 0;

        // GET: CalculateAreaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(new CalculateAreaViewModel(radius, height));
        }

        // POST: CalculateAreaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                collection.TryGetValue(nameof(CalculateAreaViewModel.Radius), out var new_radius);
                collection.TryGetValue(nameof(CalculateAreaViewModel.Height), out var new_height);
                radius = Convert.ToDouble(new_radius);
                height = Convert.ToDouble(new_height);
                return RedirectToAction(nameof(Edit));
            }
            catch
            {
                return View(new CalculateAreaViewModel(radius, height));
            }
        }
    }
}
