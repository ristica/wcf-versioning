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
            if (string.IsNullOrWhiteSpace(configVersion)) return;

            DemoClient.Version = configVersion;
        }

        private void BtnClicked(object sender, RoutedEventArgs e)
        {
            var proxy = new DemoClient();
            proxy.DoSomething();
            proxy.Close();
        }
    }
}
