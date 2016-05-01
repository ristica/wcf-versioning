using System.Configuration;
using System.Windows;
using Demo.Proxies;

namespace Demo.Client
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var configVersion = ConfigurationSettings.AppSettings["VER_NR"];
            var version = string.IsNullOrWhiteSpace(configVersion) ? null : configVersion;

            DemoClient.Version = version;
        }

        private void BtnVer1Clicked(object sender, RoutedEventArgs e)
        {
            var proxy = new DemoClient();
            proxy.DoSomething();
            proxy.Close();
        }
    }
}
