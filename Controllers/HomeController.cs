using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LiveErrorDisplayApp.Models;
using LiveErrorDisplayApp.Data;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.SignalR;

namespace LiveErrorDisplayApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IHubContext<SignalServer> _hubContext;

        public HomeController(ILogger<HomeController> logger,
                                ApplicationDbContext context,
                                IHubContext<SignalServer> hubContext)
        {
            _logger = logger;
            _context = context;
            _hubContext = hubContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var errors = _context.Errors.Where(x => !x.IsResolved).OrderByDescending(x => x.CreatedAt).ToList();
            return View(errors);
        }

        [HttpGet]
        public IActionResult SolvedErrors(){
            var errors = _context.Errors.Where(x=>x.IsResolved).OrderByDescending(x=>x.CreatedAt).ToList();
            return View(errors);
        }

        [HttpPost]
        public async Task<IActionResult> New([FromBody] Error error)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                _context.Errors.Add(error);
                await _context.SaveChangesAsync();

                await _hubContext.Clients.All.SendAsync("RefreshError", "");

                return Ok("success");
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }

        }

        public IActionResult Resolve(int id)
        {
            var error = _context.Errors.FirstOrDefault(x => x.Id == id);
            return View(error);
        }

        [HttpPost]
        public async Task<IActionResult> Resolve(Error error)
        {
            if (!ModelState.IsValid)
                return View(error);

            var savedError = _context.Errors.FirstOrDefault(x => x.Id == error.Id);
            savedError.Description = error.Description;
            savedError.ResolvedBy = error.ResolvedBy;
            savedError.IsResolved = true;
            savedError.ResolvedOn = DateTime.Now;

            _context.Errors.Update(savedError);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
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
