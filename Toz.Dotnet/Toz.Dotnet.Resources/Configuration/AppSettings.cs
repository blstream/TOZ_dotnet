namespace Toz.Dotnet.Resources.Configuration
{
    public class AppSettings
    {
        public string[] AcceptPhotoTypes { get; set; }

        public string BackendBaseUrl { get; set; }
        public string BackendPetsUrl { get; set; }
        public string BackendNewsUrl { get; set; }
        public string BackendUsersUrl { get; set; }
        public string BackendScheduleUrl { get; set; }
        public string BackendOrganizationInfoUrl { get; set; }
        public string BackendJwtUrl { get; set; }
        public string BackendProposalsUrl { get; set; }
        public string BackendActivationUserUrl { get; set; }
        public string BackendBecomeVolunteerUrl { get; set; }
        public string BackendDonateInfoUrl { get; set; }

        public string PolicyName { get; set; }
        public string[] AcceptUserRole { get; set; }
        public string DataProtectorName { get; set; }
        public string LoginControllerName { get; set; }
        public string CookieTokenName { get; set; }
    }
}