using MDD4All.DevOpsObserver.DataModels;
using MDD4All.DevOpsObserver.StatusLightControl.Hue;

namespace TestHueStatusLightController
{
    public partial class Form1 : Form
    {

        private HueStatusLightController _hueController;

        public Form1()
        {
            InitializeComponent();

            _hueController = new HueStatusLightController("169.254.9.130", "C83xfY4ZLU5WKQoygUKwuOJnxgs8HgNn05jwLusu", "4");

        }

        private async void onButton_Click(object sender, EventArgs e)
        {
            await _hueController.TurnLightOnAsync();
        }

        private async void OffButton_Click(object sender, EventArgs e)
        {
            await _hueController.TurnLightOffAsync();
        }

        private async void RedButton_Click(object sender, EventArgs e)
        {
            await _hueController.SetStatusLightAsync(DevOpsStatus.Fail);
        }

        private async void YellowButton_Click(object sender, EventArgs e)
        {
            await _hueController.SetStatusLightAsync(DevOpsStatus.Warning);
        }

        private async void greenButton_Click(object sender, EventArgs e)
        {
            await _hueController.SetStatusLightAsync(DevOpsStatus.Success);
        }

        private async void UnknownButton_Click(object sender, EventArgs e)
        {
            await _hueController.SetStatusLightAsync(DevOpsStatus.Unknown);
        }

        private async void AlertButton_Click(object sender, EventArgs e)
        {
            await _hueController.ActivateAlertAsync();
        }
    }
}
