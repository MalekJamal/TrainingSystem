using TrainingSystem.Core.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using TrainingSystem.Core.Interfaces;
using TrainingSystem.Core.Models;
using TrainingSystem.Core.ViewModels;
using Microsoft.AspNetCore.Http;

namespace TrainingSystem.Presentation.Controllers
{
    public class SessionController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBaseRepository<Session> _sessionRepository;
        public SessionController(ILogger<HomeController> logger, IBaseRepository<Session> sessionRepository)
        {
            _sessionRepository = sessionRepository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var session = await _sessionRepository.GetAllAsync();

                if (session == null)
                {
                    return NotFound();

                }
                return View(session);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving sessions.");
                return View(nameof(ErrorViewModel));
            }

        }


        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var session = await _sessionRepository.GetByIdAsync(id);

            if (session == null)
            {
                return NotFound();
            }

            return View(session);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Session session)
        {
            if (!ModelState.IsValid)
            {
                return View(session);
            }
            try
            {
                // Call the repository layer to add the entity.
                var result = await _sessionRepository.AddAsync(session);

                // Handle success and redirection.
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                // Log the exception.
                _logger.LogError(ex, "An error occurred while adding a session.");

                // Handle the exception, display a generic error message, and possibly redirect to an error page.
                ModelState.AddModelError(string.Empty, "An error occurred while processing your request.");
                return View(session);
            }

        }

        public async Task<IActionResult> Search(SessionViewModel session)
        {
            if (session.Year != 0 || session.TrainingType == 0 &&
                session.TrainerName == 0 && session.TraineeName == null &&
                session.Status == 0 && session.Result == 0 &&
                session.StartDate == null && session.ExpectedEndDate == null)
            {
                var sessions = await _sessionRepository.FindAllAsync(b => (int)b.Year == (int)session.Year);
                return View(sessions);
            }

            if (session.Year == 0 && session.TrainingType != 0 ||
               session.TrainerName == 0 && session.TraineeName == null &&
               session.Status == 0 && session.Result == 0 &&
               session.StartDate == null && session.ExpectedEndDate == null)
            {
                var sessions = await _sessionRepository.FindAllAsync(b => (int)b.TrainingType == (int)session.TrainingType);
                return View(sessions);
            }

            if (session.Year == 0 && session.TrainingType == 0 &&
              session.TrainerName != 0 || session.TraineeName == null &&
              session.Status == 0 && session.Result == 0 &&
              session.StartDate == null && session.ExpectedEndDate == null)
            {
                var sessions = await _sessionRepository.FindAllAsync(b => (int)b.TrainerName == (int)session.TrainerName);
                return View(sessions);
            }

            if (session.Year == 0 && session.TrainingType == 0 &&
              session.TrainerName == 0 && session.TraineeName != null ||
              session.Status == 0 && session.Result == 0 &&
              session.StartDate == null && session.ExpectedEndDate == null)
            {
                var sessions = await _sessionRepository.FindAllAsync(b => b.TraineeName.Contains(session.TraineeName));
                return View(sessions);
            }

            if (session.Year == 0 && session.TrainingType == 0 &&
              session.TrainerName == 0 && session.TraineeName == null &&
              session.Status != 0 || session.Result == 0 &&
              session.StartDate == null && session.ExpectedEndDate == null)
            {
                var sessions = await _sessionRepository.FindAllAsync(b => (int)b.Status == (int)session.Status);
                return View(sessions);
            }

            if (session.Year == 0 && session.TrainingType == 0 &&
              session.TrainerName == 0 && session.TraineeName == null &&
              session.Status == 0 && session.Result != 0 ||
              session.StartDate == null && session.ExpectedEndDate == null)
            {
                var sessions = await _sessionRepository.FindAllAsync(b => (int)b.Result == (int)session.Result);
                return View(sessions);
            }

            if (session.Year == 0 && session.TrainingType == 0 &&
              session.TrainerName == 0 && session.TraineeName == null &&
              session.Status == 0 && session.Result == 0 &&
              session.StartDate != null || session.ExpectedEndDate == null)
            {
                var sessions = await _sessionRepository.FindAllAsync(b => b.StartDate.Date == session.StartDate);
                return View(sessions);
            }

            if (session.Year == 0 && session.TrainingType == 0 &&
              session.TrainerName == 0 && session.TraineeName == null &&
              session.Status == 0 && session.Result == 0 &&
              session.StartDate == null || session.ExpectedEndDate != null)
            {
                var sessions = await _sessionRepository.FindAllAsync(b => b.ExpectedEndDate.Date == session.ExpectedEndDate);
                return View(sessions);
            }

            return View();
        }
    }
}
