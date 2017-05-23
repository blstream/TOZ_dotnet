﻿using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using Toz.Dotnet.Core.Interfaces;
using Toz.Dotnet.Extensions;
using Toz.Dotnet.Models;
using Toz.Dotnet.Resources.Configuration;
using Toz.Dotnet.Authorization;

namespace Toz.Dotnet.Controllers
{
    public class ProposalsController : TozControllerBase<ProposalsController>
    {
        private readonly IProposalsManagementService _proposalsManagementService;

        public ProposalsController(IProposalsManagementService proposalsManagementService, IBackendErrorsService backendErrorsService, 
            IStringLocalizer<ProposalsController> localizer, IOptions<AppSettings> appSettings, IAuthService authService) 
            : base(backendErrorsService, localizer, appSettings, authService)
        {
            _proposalsManagementService = proposalsManagementService;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var activationError = TempData.Get<string>("ActivationError");
            if (!string.IsNullOrEmpty(activationError))
            {
                ViewData["ActivationError"] = activationError;
            }
            var proposals = await _proposalsManagementService.GetAllProposals(AuthService.ReadCookie(HttpContext, AppSettings.CookieTokenName), cancellationToken);
            return View(proposals.OrderByDescending(prop => prop.CreationTime));
        }

        public IActionResult Add()
        {
            return PartialView(new Proposal());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(Proposal proposal, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return PartialView(proposal);
            }

            if (await _proposalsManagementService.CreateProposal(proposal, AuthService.ReadCookie(HttpContext, AppSettings.CookieTokenName), cancellationToken))
            {
                return Json(new {success = true});
            }

            CheckUnexpectedErrors();
            return PartialView(proposal);
        }

        public async Task<IActionResult> Edit(string id, CancellationToken cancellationToken)
        {
            return PartialView("Edit", await _proposalsManagementService.GetProposal(id, AuthService.ReadCookie(HttpContext, AppSettings.CookieTokenName), cancellationToken));
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Proposal proposal, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return PartialView(proposal);
            }

            if (await _proposalsManagementService.UpdateProposal(proposal, AuthService.ReadCookie(HttpContext, AppSettings.CookieTokenName), cancellationToken))
            {
                return Json(new { success = true });
            }

            CheckUnexpectedErrors();
            return PartialView(proposal);
        }

        public async Task<IActionResult> Delete(string id, CancellationToken cancellationToken)
        {
            var proposal = await _proposalsManagementService.GetProposal(id, AuthService.ReadCookie(HttpContext, AppSettings.CookieTokenName), cancellationToken);
            if (proposal != null && await _proposalsManagementService.DeleteProposal(proposal, AuthService.ReadCookie(HttpContext, AppSettings.CookieTokenName), cancellationToken))
            {
                return Json(new {success = true});
            }
            CheckUnexpectedErrors();
            return PartialView("Edit", proposal);
        }

        public async Task<IActionResult> Activate(string id, CancellationToken cancellationToken)
        {
            var result = await _proposalsManagementService.SendActivationEmail(id, AuthService.ReadCookie(HttpContext, AppSettings.CookieTokenName), cancellationToken);
            if (!result)
            {
                TempData.Put<string>("ActivationError", StringLocalizer["FailedToSendActivationMail"]);            
            }
            return RedirectToAction("Index");
        }

    }
}
