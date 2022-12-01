using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using DataAccess.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;
using System.Linq;

namespace AdminPanel.Controllers
{
    public class TaskController : Controller
    {
        ITaskService taskService;
        Context _context = new Context();

        public TaskController(ITaskService taskService)
        {
            this.taskService = taskService;
        }

        public IActionResult Index()
        {
            var result = taskService.ListAllTasks();
            return View(result);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(TaskTable task)
        {
            TaskValidation taskValidation = new TaskValidation();
            ValidationResult results = taskValidation.Validate(task);
            if (results.IsValid)
            {
                taskService.AddTask(task);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var t in results.Errors)
                {
                    ModelState.AddModelError(t.PropertyName, t.ErrorMessage);
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var result = taskService.GetById(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult Update(TaskTable task)
        {
            TaskValidation taskValidation = new TaskValidation();
            ValidationResult results = taskValidation.Validate(task);

            if (results.IsValid)
            {
                taskService.UpdateTask(task);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var t in results.Errors)
                {
                    ModelState.AddModelError(t.PropertyName, t.ErrorMessage);
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var result = _context.TaskTables.FirstOrDefault(x => x.taskId == id);
            taskService.DeleteTask(result);
            return RedirectToAction("Index");
        }


    }
}
