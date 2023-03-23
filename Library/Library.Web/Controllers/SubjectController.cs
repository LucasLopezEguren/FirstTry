using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Library.BusinessLogic;
using Library.BusinessLogic.Entidades;
using Library.AccessData.InMemory;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Library.BusinessLogic.Interfaces;
using Library.AccessData;

namespace Library.Web.Controllers
{
    public class SubjectController : Controller
    {
        private ISubjectRepository subjectRepository;

        public SubjectController(ISubjectRepository subjectRepository) {
            this.subjectRepository = subjectRepository;
        }

        // GET: SubjectController
        public ActionResult Index()
        {
            return View(subjectRepository.GetAll());
        }

        // GET: SubjectController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SubjectController/Create
        public ActionResult Create()
        {
            return View(new Subject(3));
        }

        // POST: SubjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Subject subject)
        {
            try
            {
                subjectRepository.Add(subject);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return View();
            }
        }

        // GET: SubjectController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubjectController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SubjectController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(subjectRepository.GetById(id));
        }

        // POST: SubjectController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Subject subject)
        {
            try
            {
                subjectRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
