using Autofac;
using Lykke.Common.Log;
using MAVN.Service.QuorumMonitoring.Services;
using MAVN.Service.QuorumMonitoring.Settings;
using Lykke.SettingsReader;

namespace MAVN.Service.QuorumMonitoring.Modules
{
    public class ServiceModule : Module
    {
        private readonly IReloadingManager<AppSettings> _appSettings;

        public ServiceModule(IReloadingManager<AppSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c=> new MonitoringService(
                    _appSettings.CurrentValue.QuorumMonitoringService.Nodes,
                    c.Resolve<ILogFactory>()))
                .As<IStartable>()
                .SingleInstance();
        }
    }
}
