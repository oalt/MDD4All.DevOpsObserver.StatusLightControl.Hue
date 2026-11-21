using MDD4All.DevOpsObserver.DataModels;
using MDD4All.DevOpsObserver.StatusLightControl.Contracts;
using System.Threading.Tasks;

namespace MDD4All.DevOpsObserver.StatusLightControl.Hue
{
    /// <summary>
    /// Mickup class for Hue light contreoller. Used when no hardware is connected.
    /// </summary>
    public class MockupHueLightController : IStatusLightController
    {
        public DevOpsStatus CurrentStatus { get; private set; } = DevOpsStatus.Unknown;

        public bool IsOn { get; private set; }

        public Task ActivateAlertAsync()
        {
            return Task.CompletedTask;
        }

        public Task SetStatusLightAsync(DevOpsStatus devOpsStatus)
        {
            return Task.CompletedTask;
        }

        public Task TurnLightOffAsync()
        {
            return Task.CompletedTask;
        }

        public Task TurnLightOnAsync()
        {
            return Task.CompletedTask;
        }
    }
}
