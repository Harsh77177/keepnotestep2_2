using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Keepnote_Step2.Repository;
using Keepnote_Step2.Models;

namespace Keepnote_Step2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteConteroller : ControllerBase
    {
        private NoteRepository _repo;

        public NoteConteroller(NoteRepository repo)
        {
            _repo = repo;
        }   
        public ActionResult Index()
        {
            List<Note> notes = _repo.GetNotes();

            return View(notes);
        }
    }
}
