using System;
using System.ServiceModel;
using System.Threading;
using System.Windows;

using Contract;

namespace Client
{
    public partial class MainWindow : Window
    {
        IContract calculator;

        public MainWindow()
        {
            InitializeComponent();

            Thread.Sleep(3000);

            calculator = ChannelFactory<IContract>.CreateChannel(
            new BasicHttpBinding(), new EndpointAddress("http://localhost:8080/MyService"));
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            tb3.Text = calculator.Divide(Double.Parse(tb1.Text), Double.Parse(tb2.Text)).ToString();
        }
    }
}
