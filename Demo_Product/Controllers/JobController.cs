using BusinessLayer.Concrete;
using BusinessLayer.FluendValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;

namespace Demo_Product.Controllers
{
    public class JobController : Controller
    {
        JobManager jobManager=new JobManager(new EfJobDal());
        public IActionResult Index()
        {
            var value = jobManager.TGetList();
            return View(value);
        }
        [HttpGet]

        public IActionResult AddJob()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddJob(Job p)
        {
            JobValidator validationRules = new JobValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
                jobManager.TInsert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(p);
        }

        public IActionResult DeleteJob(int id)
        {
            var value = jobManager.GetById(id);
            jobManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            var value = jobManager.GetById(id);
            return View(value);
        }
        [HttpPost]

        public IActionResult UpdateJob(Job p)
        {
            jobManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
