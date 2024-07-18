using MDD4All.DevOpsObserver.DataModels;
using MDD4All.DevOpsObserver.StatusLightControl.Contracts;
using Q42.HueApi;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MDD4All.DevOpsObserver.StatusLightControl.Hue
{
    public class HueStatusLightController : IStatusLightController
    {
        private LocalHueClient _hueClient;

        private string _bulbID;

        public HueStatusLightController(string bridgeAddress, string apiKey, string bulbID)
        {
            _hueClient = new LocalHueClient(bridgeAddress, apiKey);
            _bulbID = bulbID;

            Task.Run(() => SetStatusLightAsync(CurrentStatus)).Wait();
        }

        public DevOpsStatus CurrentStatus { get; private set; } = DevOpsStatus.Unknown;

        public bool IsOn { get; private set; }

        public async Task ActivateAlertAsync()
        {
            if (IsOn)
            {
                LightCommand lightCommand = new LightCommand();

                lightCommand.Alert = Alert.Multiple;

                await _hueClient.SendCommandAsync(lightCommand, new List<string>
                {
                    _bulbID
                });

                await SetStatusLightAsync(CurrentStatus);
            }
        }

        public async Task SetStatusLightAsync(DevOpsStatus devOpsStatus)
        {
            LightCommand lightCommand = new LightCommand();

            lightCommand.Brightness = 50;

            switch (devOpsStatus)
            {
                case DevOpsStatus.Unknown:
                    lightCommand.SetColor(0.150, 0.060);
                    break;

                case DevOpsStatus.Fail:
                case DevOpsStatus.Error:
                    lightCommand.SetColor(0.650, 0.330);
                    break;

                case DevOpsStatus.Warning:
                    lightCommand.SetColor(0.513, 0.431);
                    break;

                case DevOpsStatus.Success:
                    lightCommand.SetColor(0.276, 0.512);
                    break;

                default:
                    lightCommand.SetColor(0.150, 0.060);
                    break;
            }

            await _hueClient.SendCommandAsync(lightCommand, new List<string>
            {
                _bulbID
            });

            CurrentStatus = devOpsStatus;

        }

        public async Task TurnLightOffAsync()
        {
            LightCommand lightCommand = new LightCommand();
            
            lightCommand.On = false;

            await _hueClient.SendCommandAsync(lightCommand, new List<string>
            {
                _bulbID
            });

            IsOn = false;
        }

        public async Task TurnLightOnAsync()
        {
            LightCommand lightCommand = new LightCommand();
            
            lightCommand.On = true;

            await _hueClient.SendCommandAsync(lightCommand, new List<string>
            {
                _bulbID
            });

            await SetStatusLightAsync(CurrentStatus);

            IsOn = true;
        }
    }
}
