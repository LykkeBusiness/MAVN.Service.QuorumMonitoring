using Lykke.SettingsReader.Attributes;

namespace MAVN.Service.QuorumMonitoring.Client 
{
    /// <summary>
    /// QuorumMonitoring client settings.
    /// </summary>
    public class QuorumMonitoringServiceClientSettings 
    {
        /// <summary>Service url.</summary>
        [HttpCheck("api/isalive")]
        public string ServiceUrl {get; set;}
    }
}
