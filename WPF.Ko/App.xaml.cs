using System.Windows;
using WPF.Ko.ResourceLibrary;

namespace WPF.Ko
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            new ResourceLibraryModule();
        }
    }

}
