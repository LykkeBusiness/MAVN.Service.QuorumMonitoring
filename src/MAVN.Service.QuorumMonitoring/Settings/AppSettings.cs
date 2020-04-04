using JetBrains.Annotations;
using Lykke.Sdk.Settings;

namespace MAVN.Service.QuorumMonitoring.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class AppSettings : BaseAppSettings
    {
        public QuorumMonitoringSettings QuorumMonitoringService { get; set; }
    }
}
