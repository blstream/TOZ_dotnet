﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Toz.Dotnet.Core.Interfaces;
using Toz.Dotnet.Models;
using Toz.Dotnet.Resources.Configuration;

namespace Toz.Dotnet.Core.Services
{
    public class OrganizationManagementService : IOrganizationManagementService
    {
        private readonly IRestService _restService;
        public string RequestUri { get; set; }

        public OrganizationManagementService(IRestService restService, IOptions<AppSettings> appSettings)
        {
            _restService = restService;
            RequestUri = appSettings.Value.BackendBaseUrl + appSettings.Value.BackendOrganizationInfoUrl;
        }

        public async Task<bool> UpdateOrCreateInfo(Organization organizationInfo, string token, CancellationToken cancelationToken = default(CancellationToken))
        {
            // Always pass backend-acceptable value (without country code and/or spaces)
            string number = organizationInfo.BankAccount.Number.Replace(" ", string.Empty);
            organizationInfo.BankAccount.Number = number.StartsWith("PL") ? number.Substring(2, 26) : number;

            Func<string, Organization, string, CancellationToken, Task<bool>> methodToExecute = _restService.ExecutePutAction;

            if (await GetOrganizationInfo(token, cancelationToken) == null)
            {
                methodToExecute = _restService.ExecutePostAction;
            }

            return await methodToExecute(RequestUri, organizationInfo, token, cancelationToken);
        }

        public async Task<Organization> GetOrganizationInfo(string token, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await _restService.ExecuteGetAction<Organization>(RequestUri, token, cancellationToken);
        }
    }
}
