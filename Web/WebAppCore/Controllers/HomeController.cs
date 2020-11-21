/// <summary>
/// The home controller
/// </summary>

namespace WebAppCore.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using WebAppCore.Models;
    using WebAppCore.Repositories;

    /// <summary>
    /// The home controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeRepository _homeRepository;

        public HomeController(ILogger<HomeController> logger, IHomeRepository homeRepository)
        {
            _logger = logger;
            _homeRepository = homeRepository;
        }

        /// <summary>
        ///  Action method to get model
        /// </summary>
        /// <returns>The ActionResult</returns>
        public IActionResult Index()
        {
            return View(this._homeRepository.GetHomeModels());
        }

        /// <summary>
        /// Logins this instance.
        /// </summary>
        /// <returns>The Login</returns>
        [Authorize]
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Modals the pop up.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The IActionResult</returns>
        [HttpGet]
        public IActionResult ModalPopUp(int id)
        {
            var popup = new ModalPopup()
            {
                CloseButton = "Close",
                Footer = "Press Submit",
                SubmitButton = "Submit",
                Id = "EditStudent",
                Header = "Edit Student",
                PartialView = null,
            };

            return PartialView("_ModalPopUp", popup);
        }

        /// <summary>
        /// Privacies this instance.
        /// </summary>
        /// <returns>The privacy</returns>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// Errors this instance.
        /// </summary>
        /// <returns>The IAction Result</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}