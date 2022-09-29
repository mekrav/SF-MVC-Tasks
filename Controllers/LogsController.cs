using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Task.Models.Db;
using MVC_Task.Models.Db.Logs;
using System.Threading.Tasks;

namespace MVC_Task.Controllers
{
    public class LogsController : Controller
    {
        private readonly ILogRepository _repo;
        private readonly ILogger<LogsController> _logger;
        public LogsController(ILogger<LogsController> logger, ILogRepository repo)
        {
            _repo = repo;
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            var requests = await _repo.GetRequests();
            return View(requests);
        }
    }
}
