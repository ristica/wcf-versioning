using System.Windows;
using Demo.Proxies;

namespace Demo.Client
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnVer1Clicked(object sender, RoutedEventArgs e)
        {
            var proxy = new DemoClient();
            proxy.DoSomething();
            proxy.Close();
        }

        private void BtnVer2Clicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
