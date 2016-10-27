using RadacodeTask.Models;
using RadacodeTask.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RadacodeTask.Controllers
{
    [RequireHttps]
    public class IdeaController : Controller
    {
        private IIdeaRepository repository;

        public IdeaController(IIdeaRepository ideaRepository)
        {
            this.repository = ideaRepository;
        }
        public int PageSize = 4;


        // GET: Idea
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult List(int page = 1)
        {
            IdeaListViewModel model = new IdeaListViewModel
            {
                Ideas = repository.Ideas
                        .OrderBy(p => p.Id)
                        .Skip((page - 1) * PageSize)
                        .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Ideas.Count()
                }
            };
            return View(model);
        }

        //public PartialViewResult GetPeopleData(string selectedRole = "All")
        //{
        //    IEnumerable<Person> data = personData;
        //    if (selectedRole != "All")
        //    {
        //        Role selected = (Role)Enum.Parse(typeof(Role), selectedRole);
        //        data = personData.Where(p => p.Role == selected);
        //    }

        //    return PartialView(data);
        //}

        public PartialViewResult Vote(int ideaId, bool up)
        {
            Idea idea = repository.Ideas.Where(i => i.Id == ideaId).Single();
            //if (up)
            //{
            //    idea.Rating += 1;
            //}
            //else
            //{
            //    idea.Rating -= 1;
            //}
            return PartialView(idea.Rating);
        }

        public void VoteDown(int ideaId)
        {

        }
    }
}