using System.Windows;

namespace Helper
{
    public partial class App
    {
        private Bootstrapper.Bootstrapper? _bootstrapper;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            _bootstrapper = new Bootstrapper.Bootstrapper();

            _bootstrapper.Run();
        }
    }
}
